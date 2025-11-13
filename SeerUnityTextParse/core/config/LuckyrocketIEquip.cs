using System;

namespace core.config
{
	// Token: 0x02001D85 RID: 7557
	public class LuckyrocketIEquip : XlsConfigBase<LuckyrocketIEquip, ILuckyrocketIEquipInfo>
	{
		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600DD94 RID: 56724 RVA: 0x003D5AC9 File Offset: 0x003D3CC9
		public override string fileName
		{
			get
			{
				return "luckyrocketIEquip";
			}
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x003D5AD0 File Offset: 0x003D3CD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILuckyrocketIEquipInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILuckyrocketIEquipInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x003D5B24 File Offset: 0x003D3D24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
