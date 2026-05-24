using System;

namespace core.config
{
	// Token: 0x020026F7 RID: 9975
	public class IStory1023Info : IConfigItem
	{
		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06013792 RID: 79762 RVA: 0x005267FC File Offset: 0x005249FC
		// (set) Token: 0x06013793 RID: 79763 RVA: 0x00526804 File Offset: 0x00524A04
		public string param1 { get; set; }

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06013794 RID: 79764 RVA: 0x0052680D File Offset: 0x00524A0D
		// (set) Token: 0x06013795 RID: 79765 RVA: 0x00526815 File Offset: 0x00524A15
		public string param2 { get; set; }

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06013796 RID: 79766 RVA: 0x0052681E File Offset: 0x00524A1E
		// (set) Token: 0x06013797 RID: 79767 RVA: 0x00526826 File Offset: 0x00524A26
		public string param3 { get; set; }

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06013798 RID: 79768 RVA: 0x0052682F File Offset: 0x00524A2F
		// (set) Token: 0x06013799 RID: 79769 RVA: 0x00526837 File Offset: 0x00524A37
		public string param4 { get; set; }

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0601379A RID: 79770 RVA: 0x00526840 File Offset: 0x00524A40
		// (set) Token: 0x0601379B RID: 79771 RVA: 0x00526848 File Offset: 0x00524A48
		public string param5 { get; set; }

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0601379C RID: 79772 RVA: 0x00526851 File Offset: 0x00524A51
		// (set) Token: 0x0601379D RID: 79773 RVA: 0x00526859 File Offset: 0x00524A59
		public float control { get; set; }

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0601379E RID: 79774 RVA: 0x00526862 File Offset: 0x00524A62
		// (set) Token: 0x0601379F RID: 79775 RVA: 0x0052686A File Offset: 0x00524A6A
		public int id { get; set; }

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x060137A0 RID: 79776 RVA: 0x00526873 File Offset: 0x00524A73
		// (set) Token: 0x060137A1 RID: 79777 RVA: 0x0052687B File Offset: 0x00524A7B
		public int logic { get; set; }

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x060137A2 RID: 79778 RVA: 0x00526884 File Offset: 0x00524A84
		// (set) Token: 0x060137A3 RID: 79779 RVA: 0x0052688C File Offset: 0x00524A8C
		public int next { get; set; }

		// Token: 0x060137A4 RID: 79780 RVA: 0x00526898 File Offset: 0x00524A98
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
