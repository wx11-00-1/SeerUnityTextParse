using System;

namespace core.config
{
	// Token: 0x020026E9 RID: 9961
	public class IStory1016Info : IConfigItem
	{
		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x060136EA RID: 79594 RVA: 0x00525BA0 File Offset: 0x00523DA0
		// (set) Token: 0x060136EB RID: 79595 RVA: 0x00525BA8 File Offset: 0x00523DA8
		public string param1 { get; set; }

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x060136EC RID: 79596 RVA: 0x00525BB1 File Offset: 0x00523DB1
		// (set) Token: 0x060136ED RID: 79597 RVA: 0x00525BB9 File Offset: 0x00523DB9
		public string param2 { get; set; }

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x060136EE RID: 79598 RVA: 0x00525BC2 File Offset: 0x00523DC2
		// (set) Token: 0x060136EF RID: 79599 RVA: 0x00525BCA File Offset: 0x00523DCA
		public string param3 { get; set; }

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060136F0 RID: 79600 RVA: 0x00525BD3 File Offset: 0x00523DD3
		// (set) Token: 0x060136F1 RID: 79601 RVA: 0x00525BDB File Offset: 0x00523DDB
		public string param4 { get; set; }

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x060136F2 RID: 79602 RVA: 0x00525BE4 File Offset: 0x00523DE4
		// (set) Token: 0x060136F3 RID: 79603 RVA: 0x00525BEC File Offset: 0x00523DEC
		public string param5 { get; set; }

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x060136F4 RID: 79604 RVA: 0x00525BF5 File Offset: 0x00523DF5
		// (set) Token: 0x060136F5 RID: 79605 RVA: 0x00525BFD File Offset: 0x00523DFD
		public float control { get; set; }

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x060136F6 RID: 79606 RVA: 0x00525C06 File Offset: 0x00523E06
		// (set) Token: 0x060136F7 RID: 79607 RVA: 0x00525C0E File Offset: 0x00523E0E
		public int id { get; set; }

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x060136F8 RID: 79608 RVA: 0x00525C17 File Offset: 0x00523E17
		// (set) Token: 0x060136F9 RID: 79609 RVA: 0x00525C1F File Offset: 0x00523E1F
		public int logic { get; set; }

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x060136FA RID: 79610 RVA: 0x00525C28 File Offset: 0x00523E28
		// (set) Token: 0x060136FB RID: 79611 RVA: 0x00525C30 File Offset: 0x00523E30
		public int next { get; set; }

		// Token: 0x060136FC RID: 79612 RVA: 0x00525C3C File Offset: 0x00523E3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
