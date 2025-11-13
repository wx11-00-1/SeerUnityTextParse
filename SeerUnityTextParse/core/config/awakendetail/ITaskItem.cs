using System;

namespace core.config.awakendetail
{
	// Token: 0x0200206E RID: 8302
	public class ITaskItem
	{
		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600FD81 RID: 64897 RVA: 0x00403349 File Offset: 0x00401549
		// (set) Token: 0x0600FD82 RID: 64898 RVA: 0x00403351 File Offset: 0x00401551
		public IAdvances Advances { get; set; }

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x0600FD83 RID: 64899 RVA: 0x0040335A File Offset: 0x0040155A
		// (set) Token: 0x0600FD84 RID: 64900 RVA: 0x00403362 File Offset: 0x00401562
		public int ID { get; set; }

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600FD85 RID: 64901 RVA: 0x0040336B File Offset: 0x0040156B
		// (set) Token: 0x0600FD86 RID: 64902 RVA: 0x00403373 File Offset: 0x00401573
		public int NewEffID { get; set; }

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600FD87 RID: 64903 RVA: 0x0040337C File Offset: 0x0040157C
		// (set) Token: 0x0600FD88 RID: 64904 RVA: 0x00403384 File Offset: 0x00401584
		public int OldEffID { get; set; }

		// Token: 0x0600FD89 RID: 64905 RVA: 0x00403390 File Offset: 0x00401590
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Advances = new IAdvances();
				this.Advances.Parse(bytes, ref byteIndex);
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewEffID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.OldEffID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
