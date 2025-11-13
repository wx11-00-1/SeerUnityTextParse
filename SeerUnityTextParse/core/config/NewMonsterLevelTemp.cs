using System;

namespace core.config
{
	// Token: 0x02001DAD RID: 7597
	public class NewMonsterLevelTemp : XlsConfigBase<NewMonsterLevelTemp, INewMonsterLevelTempInfo>
	{
		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x003D7DF5 File Offset: 0x003D5FF5
		public override string fileName
		{
			get
			{
				return "new_monster_level_temp";
			}
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x003D7DFC File Offset: 0x003D5FFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewMonsterLevelTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewMonsterLevelTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF46 RID: 57158 RVA: 0x003D7E50 File Offset: 0x003D6050
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
