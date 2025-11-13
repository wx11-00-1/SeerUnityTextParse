using System;

namespace core.config
{
	// Token: 0x02001DAF RID: 7599
	public class Npc : XlsConfigBase<Npc, INpcInfo>
	{
		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x003D810D File Offset: 0x003D630D
		public override string fileName
		{
			get
			{
				return "npc";
			}
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x003D8114 File Offset: 0x003D6314
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INpcInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INpcInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x003D8168 File Offset: 0x003D6368
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
