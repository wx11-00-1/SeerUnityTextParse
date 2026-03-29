using System;

namespace core.config
{
	// Token: 0x02002125 RID: 8485
	public class IAutoCardbookInfo : IConfigItem
	{
		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600FBF0 RID: 64496 RVA: 0x0047C4A0 File Offset: 0x0047A6A0
		// (set) Token: 0x0600FBF1 RID: 64497 RVA: 0x0047C4A8 File Offset: 0x0047A6A8
		public string BuffIcon { get; set; }

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600FBF2 RID: 64498 RVA: 0x0047C4B1 File Offset: 0x0047A6B1
		// (set) Token: 0x0600FBF3 RID: 64499 RVA: 0x0047C4B9 File Offset: 0x0047A6B9
		public string CardRecom { get; set; }

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600FBF4 RID: 64500 RVA: 0x0047C4C2 File Offset: 0x0047A6C2
		// (set) Token: 0x0600FBF5 RID: 64501 RVA: 0x0047C4CA File Offset: 0x0047A6CA
		public string Title { get; set; }

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600FBF6 RID: 64502 RVA: 0x0047C4D3 File Offset: 0x0047A6D3
		// (set) Token: 0x0600FBF7 RID: 64503 RVA: 0x0047C4DB File Offset: 0x0047A6DB
		public int id { get; set; }

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600FBF8 RID: 64504 RVA: 0x0047C4E4 File Offset: 0x0047A6E4
		// (set) Token: 0x0600FBF9 RID: 64505 RVA: 0x0047C4EC File Offset: 0x0047A6EC
		public int NatureId { get; set; }

		// Token: 0x0600FBFA RID: 64506 RVA: 0x0047C4F8 File Offset: 0x0047A6F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BuffIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.CardRecom = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.NatureId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
