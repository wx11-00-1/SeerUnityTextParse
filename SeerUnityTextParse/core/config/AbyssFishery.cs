using System;

namespace core.config
{
	// Token: 0x020026B0 RID: 9904
	public class AbyssFishery : XlsConfigBase<AbyssFishery, IAbyssFisheryInfo>
	{
		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06013777 RID: 79735 RVA: 0x005837BC File Offset: 0x005819BC
		public override string fileName
		{
			get
			{
				return "AbyssFishery";
			}
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x005837C4 File Offset: 0x005819C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAbyssFisheryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAbyssFisheryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013779 RID: 79737 RVA: 0x00583818 File Offset: 0x00581A18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
