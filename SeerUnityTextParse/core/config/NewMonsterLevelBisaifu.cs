using System;

namespace core.config
{
	// Token: 0x02001DAB RID: 7595
	public class NewMonsterLevelBisaifu : XlsConfigBase<NewMonsterLevelBisaifu, INewMonsterLevelBisaifuInfo>
	{
		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x0600DF1C RID: 57116 RVA: 0x003D7ADA File Offset: 0x003D5CDA
		public override string fileName
		{
			get
			{
				return "new_monster_level_bisaifu";
			}
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x003D7AE4 File Offset: 0x003D5CE4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewMonsterLevelBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewMonsterLevelBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x003D7B38 File Offset: 0x003D5D38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
