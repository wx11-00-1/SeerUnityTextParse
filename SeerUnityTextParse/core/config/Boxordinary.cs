using System;

namespace core.config
{
	// Token: 0x02001CCD RID: 7373
	public class Boxordinary : XlsConfigBase<Boxordinary, IBoxordinaryInfo>
	{
		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x0600D60E RID: 54798 RVA: 0x003CC6E0 File Offset: 0x003CA8E0
		public override string fileName
		{
			get
			{
				return "boxordinary";
			}
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x003CC6E8 File Offset: 0x003CA8E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBoxordinaryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBoxordinaryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x003CC73C File Offset: 0x003CA93C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
