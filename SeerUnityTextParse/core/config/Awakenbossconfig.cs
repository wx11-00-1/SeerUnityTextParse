using System;

namespace core.config
{
	// Token: 0x02001CA9 RID: 7337
	public class Awakenbossconfig : XlsConfigBase<Awakenbossconfig, IAwakenbossconfigInfo>
	{
		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600D4A4 RID: 54436 RVA: 0x003CAC5F File Offset: 0x003C8E5F
		public override string fileName
		{
			get
			{
				return "awakenbossconfig";
			}
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x003CAC68 File Offset: 0x003C8E68
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenbossconfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenbossconfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x003CACBC File Offset: 0x003C8EBC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
