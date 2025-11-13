using System;

namespace core.config
{
	// Token: 0x02001D0D RID: 7437
	public class CrystalLegendDice : XlsConfigBase<CrystalLegendDice, ICrystalLegendDiceInfo>
	{
		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x0600D906 RID: 55558 RVA: 0x003D005E File Offset: 0x003CE25E
		public override string fileName
		{
			get
			{
				return "crystalLegendDice";
			}
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x003D0068 File Offset: 0x003CE268
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendDiceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendDiceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x003D00BC File Offset: 0x003CE2BC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
