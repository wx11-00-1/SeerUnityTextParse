using System;

namespace core.config.effectbuff
{
	// Token: 0x0200205D RID: 8285
	public class IBuffItem
	{
		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600FD11 RID: 64785 RVA: 0x00402B1C File Offset: 0x00400D1C
		// (set) Token: 0x0600FD12 RID: 64786 RVA: 0x00402B24 File Offset: 0x00400D24
		public string Desc { get; set; }

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600FD13 RID: 64787 RVA: 0x00402B2D File Offset: 0x00400D2D
		// (set) Token: 0x0600FD14 RID: 64788 RVA: 0x00402B35 File Offset: 0x00400D35
		public string Name { get; set; }

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600FD15 RID: 64789 RVA: 0x00402B3E File Offset: 0x00400D3E
		// (set) Token: 0x0600FD16 RID: 64790 RVA: 0x00402B46 File Offset: 0x00400D46
		public int ID { get; set; }

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600FD17 RID: 64791 RVA: 0x00402B4F File Offset: 0x00400D4F
		// (set) Token: 0x0600FD18 RID: 64792 RVA: 0x00402B57 File Offset: 0x00400D57
		public int Kind { get; set; }

		// Token: 0x0600FD19 RID: 64793 RVA: 0x00402B60 File Offset: 0x00400D60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
