using System;

namespace core.config.equip
{
	// Token: 0x02002041 RID: 8257
	public class IEquips
	{
		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600FC2F RID: 64559 RVA: 0x004019FD File Offset: 0x003FFBFD
		// (set) Token: 0x0600FC30 RID: 64560 RVA: 0x00401A05 File Offset: 0x003FFC05
		public IEquipItem[] Equip { get; set; }

		// Token: 0x0600FC31 RID: 64561 RVA: 0x00401A10 File Offset: 0x003FFC10
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Equip = new IEquipItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Equip[i] = new IEquipItem();
					this.Equip[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
