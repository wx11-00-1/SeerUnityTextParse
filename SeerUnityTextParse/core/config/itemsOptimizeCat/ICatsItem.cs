using System;

namespace core.config.itemsOptimizeCat
{
	// Token: 0x0200201B RID: 8219
	public class ICatsItem
	{
		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600F9D7 RID: 63959 RVA: 0x003FF150 File Offset: 0x003FD350
		// (set) Token: 0x0600F9D8 RID: 63960 RVA: 0x003FF158 File Offset: 0x003FD358
		public string Name { get; set; }

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600F9D9 RID: 63961 RVA: 0x003FF161 File Offset: 0x003FD361
		// (set) Token: 0x0600F9DA RID: 63962 RVA: 0x003FF169 File Offset: 0x003FD369
		public string url { get; set; }

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600F9DB RID: 63963 RVA: 0x003FF172 File Offset: 0x003FD372
		// (set) Token: 0x0600F9DC RID: 63964 RVA: 0x003FF17A File Offset: 0x003FD37A
		public int DbCatID { get; set; }

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x0600F9DD RID: 63965 RVA: 0x003FF183 File Offset: 0x003FD383
		// (set) Token: 0x0600F9DE RID: 63966 RVA: 0x003FF18B File Offset: 0x003FD38B
		public int ID { get; set; }

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x0600F9DF RID: 63967 RVA: 0x003FF194 File Offset: 0x003FD394
		// (set) Token: 0x0600F9E0 RID: 63968 RVA: 0x003FF19C File Offset: 0x003FD39C
		public int Max { get; set; }

		// Token: 0x0600F9E1 RID: 63969 RVA: 0x003FF1A8 File Offset: 0x003FD3A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DbCatID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
