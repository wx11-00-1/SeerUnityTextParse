using System;

namespace core.config
{
	// Token: 0x020026F9 RID: 9977
	public class IStory1024Info : IConfigItem
	{
		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x060137AA RID: 79786 RVA: 0x005269C0 File Offset: 0x00524BC0
		// (set) Token: 0x060137AB RID: 79787 RVA: 0x005269C8 File Offset: 0x00524BC8
		public string param1 { get; set; }

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x060137AC RID: 79788 RVA: 0x005269D1 File Offset: 0x00524BD1
		// (set) Token: 0x060137AD RID: 79789 RVA: 0x005269D9 File Offset: 0x00524BD9
		public string param2 { get; set; }

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x060137AE RID: 79790 RVA: 0x005269E2 File Offset: 0x00524BE2
		// (set) Token: 0x060137AF RID: 79791 RVA: 0x005269EA File Offset: 0x00524BEA
		public string param3 { get; set; }

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x060137B0 RID: 79792 RVA: 0x005269F3 File Offset: 0x00524BF3
		// (set) Token: 0x060137B1 RID: 79793 RVA: 0x005269FB File Offset: 0x00524BFB
		public string param4 { get; set; }

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x060137B2 RID: 79794 RVA: 0x00526A04 File Offset: 0x00524C04
		// (set) Token: 0x060137B3 RID: 79795 RVA: 0x00526A0C File Offset: 0x00524C0C
		public string param5 { get; set; }

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x060137B4 RID: 79796 RVA: 0x00526A15 File Offset: 0x00524C15
		// (set) Token: 0x060137B5 RID: 79797 RVA: 0x00526A1D File Offset: 0x00524C1D
		public float control { get; set; }

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x060137B6 RID: 79798 RVA: 0x00526A26 File Offset: 0x00524C26
		// (set) Token: 0x060137B7 RID: 79799 RVA: 0x00526A2E File Offset: 0x00524C2E
		public int id { get; set; }

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x060137B8 RID: 79800 RVA: 0x00526A37 File Offset: 0x00524C37
		// (set) Token: 0x060137B9 RID: 79801 RVA: 0x00526A3F File Offset: 0x00524C3F
		public int logic { get; set; }

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x060137BA RID: 79802 RVA: 0x00526A48 File Offset: 0x00524C48
		// (set) Token: 0x060137BB RID: 79803 RVA: 0x00526A50 File Offset: 0x00524C50
		public int next { get; set; }

		// Token: 0x060137BC RID: 79804 RVA: 0x00526A5C File Offset: 0x00524C5C
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
