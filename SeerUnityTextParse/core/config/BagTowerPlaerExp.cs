using System;

namespace core.config
{
	// Token: 0x02001EFC RID: 7932
	public class BagTowerPlaerExp : XlsConfigBase<BagTowerPlaerExp, IBagTowerPlaerExpInfo>
	{
		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x0042C5EC File Offset: 0x0042A7EC
		public override string fileName
		{
			get
			{
				return "bagTower_PlaerExp";
			}
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x0042C5F4 File Offset: 0x0042A7F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerPlaerExpInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerPlaerExpInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x0042C648 File Offset: 0x0042A848
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
