using System;

namespace core.config
{
	// Token: 0x02002248 RID: 8776
	public class FightLabBossConfig : XlsConfigBase<FightLabBossConfig, IFightLabBossConfigInfo>
	{
		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060108BE RID: 67774 RVA: 0x0048B586 File Offset: 0x00489786
		public override string fileName
		{
			get
			{
				return "fightLabBossConfig";
			}
		}

		// Token: 0x060108BF RID: 67775 RVA: 0x0048B590 File Offset: 0x00489790
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightLabBossConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightLabBossConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060108C0 RID: 67776 RVA: 0x0048B5E4 File Offset: 0x004897E4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
