using System;

namespace core.config.effectDes
{
	// Token: 0x0200205A RID: 8282
	public class IItemItem : IConfigItem
	{
		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600FCF7 RID: 64759 RVA: 0x00402954 File Offset: 0x00400B54
		// (set) Token: 0x0600FCF8 RID: 64760 RVA: 0x0040295C File Offset: 0x00400B5C
		public string desc { get; set; }

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600FCF9 RID: 64761 RVA: 0x00402965 File Offset: 0x00400B65
		// (set) Token: 0x0600FCFA RID: 64762 RVA: 0x0040296D File Offset: 0x00400B6D
		public string kinddes { get; set; }

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600FCFB RID: 64763 RVA: 0x00402976 File Offset: 0x00400B76
		// (set) Token: 0x0600FCFC RID: 64764 RVA: 0x0040297E File Offset: 0x00400B7E
		public string monster { get; set; }

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600FCFD RID: 64765 RVA: 0x00402987 File Offset: 0x00400B87
		// (set) Token: 0x0600FCFE RID: 64766 RVA: 0x0040298F File Offset: 0x00400B8F
		public int icon { get; set; }

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600FCFF RID: 64767 RVA: 0x00402998 File Offset: 0x00400B98
		// (set) Token: 0x0600FD00 RID: 64768 RVA: 0x004029A0 File Offset: 0x00400BA0
		public int id { get; set; }

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600FD01 RID: 64769 RVA: 0x004029A9 File Offset: 0x00400BA9
		// (set) Token: 0x0600FD02 RID: 64770 RVA: 0x004029B1 File Offset: 0x00400BB1
		public int kind { get; set; }

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600FD03 RID: 64771 RVA: 0x004029BA File Offset: 0x00400BBA
		// (set) Token: 0x0600FD04 RID: 64772 RVA: 0x004029C2 File Offset: 0x00400BC2
		public int tab { get; set; }

		// Token: 0x0600FD05 RID: 64773 RVA: 0x004029CC File Offset: 0x00400BCC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.kinddes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
