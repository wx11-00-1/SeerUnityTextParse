using System;

namespace core.config
{
	// Token: 0x02001DA9 RID: 7593
	public class NewMonsterLevel : XlsConfigBase<NewMonsterLevel, INewMonsterLevelInfo>
	{
		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x0600DEF2 RID: 57074 RVA: 0x003D77BA File Offset: 0x003D59BA
		public override string fileName
		{
			get
			{
				return "new_monster_level";
			}
		}

		// Token: 0x0600DEF3 RID: 57075 RVA: 0x003D77C4 File Offset: 0x003D59C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewMonsterLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewMonsterLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x003D7818 File Offset: 0x003D5A18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
