using System;

namespace core.config
{
	// Token: 0x02001D88 RID: 7560
	public class ILuckyrocketItemInfo : IConfigItem
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600DDB4 RID: 56756 RVA: 0x003D5D34 File Offset: 0x003D3F34
		// (set) Token: 0x0600DDB5 RID: 56757 RVA: 0x003D5D3C File Offset: 0x003D3F3C
		public string describe { get; set; }

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x0600DDB6 RID: 56758 RVA: 0x003D5D45 File Offset: 0x003D3F45
		// (set) Token: 0x0600DDB7 RID: 56759 RVA: 0x003D5D4D File Offset: 0x003D3F4D
		public string name { get; set; }

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x003D5D56 File Offset: 0x003D3F56
		// (set) Token: 0x0600DDB9 RID: 56761 RVA: 0x003D5D5E File Offset: 0x003D3F5E
		public int @class { get; set; }

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x0600DDBA RID: 56762 RVA: 0x003D5D67 File Offset: 0x003D3F67
		// (set) Token: 0x0600DDBB RID: 56763 RVA: 0x003D5D6F File Offset: 0x003D3F6F
		public int id { get; set; }

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x003D5D78 File Offset: 0x003D3F78
		// (set) Token: 0x0600DDBD RID: 56765 RVA: 0x003D5D80 File Offset: 0x003D3F80
		public int itemicon { get; set; }

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x003D5D89 File Offset: 0x003D3F89
		// (set) Token: 0x0600DDBF RID: 56767 RVA: 0x003D5D91 File Offset: 0x003D3F91
		public int output { get; set; }

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x003D5D9A File Offset: 0x003D3F9A
		// (set) Token: 0x0600DDC1 RID: 56769 RVA: 0x003D5DA2 File Offset: 0x003D3FA2
		public int priority { get; set; }

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x003D5DAB File Offset: 0x003D3FAB
		// (set) Token: 0x0600DDC3 RID: 56771 RVA: 0x003D5DB3 File Offset: 0x003D3FB3
		public int rare { get; set; }

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x003D5DBC File Offset: 0x003D3FBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@class = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
