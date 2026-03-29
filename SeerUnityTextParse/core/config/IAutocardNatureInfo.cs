using System;

namespace core.config
{
	// Token: 0x02002137 RID: 8503
	public class IAutocardNatureInfo : IConfigItem
	{
		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600FC96 RID: 64662 RVA: 0x0047D0E0 File Offset: 0x0047B2E0
		// (set) Token: 0x0600FC97 RID: 64663 RVA: 0x0047D0E8 File Offset: 0x0047B2E8
		public string name { get; set; }

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600FC98 RID: 64664 RVA: 0x0047D0F1 File Offset: 0x0047B2F1
		// (set) Token: 0x0600FC99 RID: 64665 RVA: 0x0047D0F9 File Offset: 0x0047B2F9
		public string picID { get; set; }

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600FC9A RID: 64666 RVA: 0x0047D102 File Offset: 0x0047B302
		// (set) Token: 0x0600FC9B RID: 64667 RVA: 0x0047D10A File Offset: 0x0047B30A
		public int id { get; set; }

		// Token: 0x0600FC9C RID: 64668 RVA: 0x0047D113 File Offset: 0x0047B313
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.picID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
