using System;

namespace core.config
{
	// Token: 0x02002774 RID: 10100
	public class ArmorHeroNWMonster : XlsConfigBase<ArmorHeroNWMonster, IArmorHeroNWMonsterInfo>
	{
		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06013FCA RID: 81866 RVA: 0x005A4F36 File Offset: 0x005A3136
		public override string fileName
		{
			get
			{
				return "armorHeroNWMonster";
			}
		}

		// Token: 0x06013FCB RID: 81867 RVA: 0x005A4F40 File Offset: 0x005A3140
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArmorHeroNWMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArmorHeroNWMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013FCC RID: 81868 RVA: 0x005A4F94 File Offset: 0x005A3194
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
