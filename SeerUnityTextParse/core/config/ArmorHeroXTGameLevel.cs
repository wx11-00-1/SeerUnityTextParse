using System;

namespace core.config
{
	// Token: 0x02002778 RID: 10104
	public class ArmorHeroXTGameLevel : XlsConfigBase<ArmorHeroXTGameLevel, IArmorHeroXTGameLevelInfo>
	{
		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06013FEC RID: 81900 RVA: 0x005A51A7 File Offset: 0x005A33A7
		public override string fileName
		{
			get
			{
				return "armorHeroXTGameLevel";
			}
		}

		// Token: 0x06013FED RID: 81901 RVA: 0x005A51B0 File Offset: 0x005A33B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArmorHeroXTGameLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArmorHeroXTGameLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013FEE RID: 81902 RVA: 0x005A5204 File Offset: 0x005A3404
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
