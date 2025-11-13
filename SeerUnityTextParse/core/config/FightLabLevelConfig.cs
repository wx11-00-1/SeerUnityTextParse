using System;

namespace core.config
{
	// Token: 0x02001D4B RID: 7499
	public class FightLabLevelConfig : XlsConfigBase<FightLabLevelConfig, IFightLabLevelConfigInfo>
	{
		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600DB62 RID: 56162 RVA: 0x003D2D06 File Offset: 0x003D0F06
		public override string fileName
		{
			get
			{
				return "fightLabLevelConfig";
			}
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x003D2D10 File Offset: 0x003D0F10
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightLabLevelConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightLabLevelConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x003D2D64 File Offset: 0x003D0F64
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
