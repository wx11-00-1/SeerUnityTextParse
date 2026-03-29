using System;

namespace core.config
{
	// Token: 0x0200231A RID: 8986
	public class PvpMonsterConfig : XlsConfigBase<PvpMonsterConfig, IPvpMonsterConfigInfo>
	{
		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x060111B4 RID: 70068 RVA: 0x0049692B File Offset: 0x00494B2B
		public override string fileName
		{
			get
			{
				return "pvp_MonsterConfig";
			}
		}

		// Token: 0x060111B5 RID: 70069 RVA: 0x00496934 File Offset: 0x00494B34
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpMonsterConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpMonsterConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060111B6 RID: 70070 RVA: 0x00496988 File Offset: 0x00494B88
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
