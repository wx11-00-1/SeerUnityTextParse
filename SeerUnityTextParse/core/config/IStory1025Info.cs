using System;

namespace core.config
{
	// Token: 0x0200284B RID: 10315
	public class IStory1025Info : IConfigItem
	{
		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x060149AF RID: 84399 RVA: 0x0056D5C8 File Offset: 0x0056B7C8
		// (set) Token: 0x060149B0 RID: 84400 RVA: 0x0056D5D0 File Offset: 0x0056B7D0
		public string param1 { get; set; }

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x060149B1 RID: 84401 RVA: 0x0056D5D9 File Offset: 0x0056B7D9
		// (set) Token: 0x060149B2 RID: 84402 RVA: 0x0056D5E1 File Offset: 0x0056B7E1
		public string param2 { get; set; }

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x060149B3 RID: 84403 RVA: 0x0056D5EA File Offset: 0x0056B7EA
		// (set) Token: 0x060149B4 RID: 84404 RVA: 0x0056D5F2 File Offset: 0x0056B7F2
		public string param3 { get; set; }

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x060149B5 RID: 84405 RVA: 0x0056D5FB File Offset: 0x0056B7FB
		// (set) Token: 0x060149B6 RID: 84406 RVA: 0x0056D603 File Offset: 0x0056B803
		public string param4 { get; set; }

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x060149B7 RID: 84407 RVA: 0x0056D60C File Offset: 0x0056B80C
		// (set) Token: 0x060149B8 RID: 84408 RVA: 0x0056D614 File Offset: 0x0056B814
		public string param5 { get; set; }

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x060149B9 RID: 84409 RVA: 0x0056D61D File Offset: 0x0056B81D
		// (set) Token: 0x060149BA RID: 84410 RVA: 0x0056D625 File Offset: 0x0056B825
		public float control { get; set; }

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x060149BB RID: 84411 RVA: 0x0056D62E File Offset: 0x0056B82E
		// (set) Token: 0x060149BC RID: 84412 RVA: 0x0056D636 File Offset: 0x0056B836
		public int id { get; set; }

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x060149BD RID: 84413 RVA: 0x0056D63F File Offset: 0x0056B83F
		// (set) Token: 0x060149BE RID: 84414 RVA: 0x0056D647 File Offset: 0x0056B847
		public int logic { get; set; }

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x060149BF RID: 84415 RVA: 0x0056D650 File Offset: 0x0056B850
		// (set) Token: 0x060149C0 RID: 84416 RVA: 0x0056D658 File Offset: 0x0056B858
		public int next { get; set; }

		// Token: 0x060149C1 RID: 84417 RVA: 0x0056D664 File Offset: 0x0056B864
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
