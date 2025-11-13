using System;

namespace core.config.product_diamond
{
	// Token: 0x02001F39 RID: 7993
	public class product_diamonditemDef
	{
		// Token: 0x0600EFC0 RID: 61376 RVA: 0x003F3F68 File Offset: 0x003F2168
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vip = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}

		// Token: 0x0400F12A RID: 61738
		public string name;

		// Token: 0x0400F12B RID: 61739
		public int productID;

		// Token: 0x0400F12C RID: 61740
		public string itemID;

		// Token: 0x0400F12D RID: 61741
		public int price;

		// Token: 0x0400F12E RID: 61742
		public float vip;

		// Token: 0x0400F12F RID: 61743
		public string icon;
	}
}
