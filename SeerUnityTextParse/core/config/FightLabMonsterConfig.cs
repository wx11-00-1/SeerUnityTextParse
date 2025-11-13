using System;

namespace core.config
{
	// Token: 0x02001D4D RID: 7501
	public class FightLabMonsterConfig : XlsConfigBase<FightLabMonsterConfig, IFightLabMonsterConfigInfo>
	{
		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x003D2F1C File Offset: 0x003D111C
		public override string fileName
		{
			get
			{
				return "fightLabMonsterConfig";
			}
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x003D2F24 File Offset: 0x003D1124
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightLabMonsterConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightLabMonsterConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x003D2F78 File Offset: 0x003D1178
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
