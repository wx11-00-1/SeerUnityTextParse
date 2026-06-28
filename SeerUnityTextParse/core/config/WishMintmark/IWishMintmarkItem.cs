using System;

namespace core.config.WishMintmark
{
	// Token: 0x020028F3 RID: 10483
	public class IWishMintmarkItem
	{
		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0601511A RID: 86298 RVA: 0x0057ECD4 File Offset: 0x0057CED4
		// (set) Token: 0x0601511B RID: 86299 RVA: 0x0057ECDC File Offset: 0x0057CEDC
		public string MintmarkName { get; set; }

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0601511C RID: 86300 RVA: 0x0057ECE5 File Offset: 0x0057CEE5
		// (set) Token: 0x0601511D RID: 86301 RVA: 0x0057ECED File Offset: 0x0057CEED
		public int MintmarkID { get; set; }

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0601511E RID: 86302 RVA: 0x0057ECF6 File Offset: 0x0057CEF6
		// (set) Token: 0x0601511F RID: 86303 RVA: 0x0057ECFE File Offset: 0x0057CEFE
		public int WishMintmarkID { get; set; }

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x06015120 RID: 86304 RVA: 0x0057ED07 File Offset: 0x0057CF07
		// (set) Token: 0x06015121 RID: 86305 RVA: 0x0057ED0F File Offset: 0x0057CF0F
		public int WishrankID { get; set; }

		// Token: 0x06015122 RID: 86306 RVA: 0x0057ED18 File Offset: 0x0057CF18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MintmarkName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.WishMintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
