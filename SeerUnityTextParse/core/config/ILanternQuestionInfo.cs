using System;

namespace core.config
{
	// Token: 0x02002001 RID: 8193
	public class ILanternQuestionInfo : IConfigItem
	{
		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600F5EE RID: 62958 RVA: 0x00439BBC File Offset: 0x00437DBC
		// (set) Token: 0x0600F5EF RID: 62959 RVA: 0x00439BC4 File Offset: 0x00437DC4
		public string Achoose { get; set; }

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600F5F0 RID: 62960 RVA: 0x00439BCD File Offset: 0x00437DCD
		// (set) Token: 0x0600F5F1 RID: 62961 RVA: 0x00439BD5 File Offset: 0x00437DD5
		public string Bchoose { get; set; }

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x0600F5F2 RID: 62962 RVA: 0x00439BDE File Offset: 0x00437DDE
		// (set) Token: 0x0600F5F3 RID: 62963 RVA: 0x00439BE6 File Offset: 0x00437DE6
		public string Cchoose { get; set; }

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600F5F4 RID: 62964 RVA: 0x00439BEF File Offset: 0x00437DEF
		// (set) Token: 0x0600F5F5 RID: 62965 RVA: 0x00439BF7 File Offset: 0x00437DF7
		public string Dchoose { get; set; }

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x0600F5F6 RID: 62966 RVA: 0x00439C00 File Offset: 0x00437E00
		// (set) Token: 0x0600F5F7 RID: 62967 RVA: 0x00439C08 File Offset: 0x00437E08
		public string describe { get; set; }

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600F5F8 RID: 62968 RVA: 0x00439C11 File Offset: 0x00437E11
		// (set) Token: 0x0600F5F9 RID: 62969 RVA: 0x00439C19 File Offset: 0x00437E19
		public int answer { get; set; }

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600F5FA RID: 62970 RVA: 0x00439C22 File Offset: 0x00437E22
		// (set) Token: 0x0600F5FB RID: 62971 RVA: 0x00439C2A File Offset: 0x00437E2A
		public int id { get; set; }

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600F5FC RID: 62972 RVA: 0x00439C33 File Offset: 0x00437E33
		// (set) Token: 0x0600F5FD RID: 62973 RVA: 0x00439C3B File Offset: 0x00437E3B
		public int title { get; set; }

		// Token: 0x0600F5FE RID: 62974 RVA: 0x00439C44 File Offset: 0x00437E44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Achoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Bchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Cchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Dchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.answer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
