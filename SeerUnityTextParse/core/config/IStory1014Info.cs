using System;

namespace core.config
{
	// Token: 0x020026E5 RID: 9957
	public class IStory1014Info : IConfigItem
	{
		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x060136BA RID: 79546 RVA: 0x00525818 File Offset: 0x00523A18
		// (set) Token: 0x060136BB RID: 79547 RVA: 0x00525820 File Offset: 0x00523A20
		public string param1 { get; set; }

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x060136BC RID: 79548 RVA: 0x00525829 File Offset: 0x00523A29
		// (set) Token: 0x060136BD RID: 79549 RVA: 0x00525831 File Offset: 0x00523A31
		public string param2 { get; set; }

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x060136BE RID: 79550 RVA: 0x0052583A File Offset: 0x00523A3A
		// (set) Token: 0x060136BF RID: 79551 RVA: 0x00525842 File Offset: 0x00523A42
		public string param3 { get; set; }

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x060136C0 RID: 79552 RVA: 0x0052584B File Offset: 0x00523A4B
		// (set) Token: 0x060136C1 RID: 79553 RVA: 0x00525853 File Offset: 0x00523A53
		public string param4 { get; set; }

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x060136C2 RID: 79554 RVA: 0x0052585C File Offset: 0x00523A5C
		// (set) Token: 0x060136C3 RID: 79555 RVA: 0x00525864 File Offset: 0x00523A64
		public string param5 { get; set; }

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x060136C4 RID: 79556 RVA: 0x0052586D File Offset: 0x00523A6D
		// (set) Token: 0x060136C5 RID: 79557 RVA: 0x00525875 File Offset: 0x00523A75
		public int control { get; set; }

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x060136C6 RID: 79558 RVA: 0x0052587E File Offset: 0x00523A7E
		// (set) Token: 0x060136C7 RID: 79559 RVA: 0x00525886 File Offset: 0x00523A86
		public int id { get; set; }

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x060136C8 RID: 79560 RVA: 0x0052588F File Offset: 0x00523A8F
		// (set) Token: 0x060136C9 RID: 79561 RVA: 0x00525897 File Offset: 0x00523A97
		public int logic { get; set; }

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x060136CA RID: 79562 RVA: 0x005258A0 File Offset: 0x00523AA0
		// (set) Token: 0x060136CB RID: 79563 RVA: 0x005258A8 File Offset: 0x00523AA8
		public int next { get; set; }

		// Token: 0x060136CC RID: 79564 RVA: 0x005258B4 File Offset: 0x00523AB4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
