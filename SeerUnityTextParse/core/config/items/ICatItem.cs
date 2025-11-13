using System;

namespace core.config.items
{
	// Token: 0x0200201D RID: 8221
	public class ICatItem
	{
		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x0600F9E9 RID: 63977 RVA: 0x003FF298 File Offset: 0x003FD498
		// (set) Token: 0x0600F9EA RID: 63978 RVA: 0x003FF2A0 File Offset: 0x003FD4A0
		public int DbCatID { get; set; }

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x0600F9EB RID: 63979 RVA: 0x003FF2A9 File Offset: 0x003FD4A9
		// (set) Token: 0x0600F9EC RID: 63980 RVA: 0x003FF2B1 File Offset: 0x003FD4B1
		public int ID { get; set; }

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600F9ED RID: 63981 RVA: 0x003FF2BA File Offset: 0x003FD4BA
		// (set) Token: 0x0600F9EE RID: 63982 RVA: 0x003FF2C2 File Offset: 0x003FD4C2
		public IItemItem[] Item { get; set; }

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600F9EF RID: 63983 RVA: 0x003FF2CB File Offset: 0x003FD4CB
		// (set) Token: 0x0600F9F0 RID: 63984 RVA: 0x003FF2D3 File Offset: 0x003FD4D3
		public int Max { get; set; }

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600F9F1 RID: 63985 RVA: 0x003FF2DC File Offset: 0x003FD4DC
		// (set) Token: 0x0600F9F2 RID: 63986 RVA: 0x003FF2E4 File Offset: 0x003FD4E4
		public string Name { get; set; }

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600F9F3 RID: 63987 RVA: 0x003FF2ED File Offset: 0x003FD4ED
		// (set) Token: 0x0600F9F4 RID: 63988 RVA: 0x003FF2F5 File Offset: 0x003FD4F5
		public string url { get; set; }

		// Token: 0x0600F9F5 RID: 63989 RVA: 0x003FF300 File Offset: 0x003FD500
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DbCatID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}

		// Token: 0x0400F4DD RID: 62685
		private bool b;
	}
}
