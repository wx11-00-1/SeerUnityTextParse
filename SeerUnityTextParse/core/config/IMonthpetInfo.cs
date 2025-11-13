using System;

namespace core.config
{
	// Token: 0x02001D9C RID: 7580
	public class IMonthpetInfo : IConfigItem
	{
		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x0600DE78 RID: 56952 RVA: 0x003D6DEC File Offset: 0x003D4FEC
		// (set) Token: 0x0600DE79 RID: 56953 RVA: 0x003D6DF4 File Offset: 0x003D4FF4
		public string title { get; set; }

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x0600DE7A RID: 56954 RVA: 0x003D6DFD File Offset: 0x003D4FFD
		// (set) Token: 0x0600DE7B RID: 56955 RVA: 0x003D6E05 File Offset: 0x003D5005
		public int id { get; set; }

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x003D6E0E File Offset: 0x003D500E
		// (set) Token: 0x0600DE7D RID: 56957 RVA: 0x003D6E16 File Offset: 0x003D5016
		public int month { get; set; }

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600DE7E RID: 56958 RVA: 0x003D6E1F File Offset: 0x003D501F
		// (set) Token: 0x0600DE7F RID: 56959 RVA: 0x003D6E27 File Offset: 0x003D5027
		public int reward { get; set; }

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x0600DE80 RID: 56960 RVA: 0x003D6E30 File Offset: 0x003D5030
		// (set) Token: 0x0600DE81 RID: 56961 RVA: 0x003D6E38 File Offset: 0x003D5038
		public int showpet { get; set; }

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x0600DE82 RID: 56962 RVA: 0x003D6E41 File Offset: 0x003D5041
		// (set) Token: 0x0600DE83 RID: 56963 RVA: 0x003D6E49 File Offset: 0x003D5049
		public int showskill { get; set; }

		// Token: 0x0600DE84 RID: 56964 RVA: 0x003D6E54 File Offset: 0x003D5054
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showpet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showskill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
