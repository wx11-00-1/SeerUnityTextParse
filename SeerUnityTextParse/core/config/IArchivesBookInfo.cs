using System;

namespace core.config
{
	// Token: 0x02001CA2 RID: 7330
	public class IArchivesBookInfo : IConfigItem
	{
		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x003CA644 File Offset: 0x003C8844
		// (set) Token: 0x0600D457 RID: 54359 RVA: 0x003CA64C File Offset: 0x003C884C
		public string chaptername { get; set; }

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600D458 RID: 54360 RVA: 0x003CA655 File Offset: 0x003C8855
		// (set) Token: 0x0600D459 RID: 54361 RVA: 0x003CA65D File Offset: 0x003C885D
		public string[] txt { get; set; }

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600D45A RID: 54362 RVA: 0x003CA666 File Offset: 0x003C8866
		// (set) Token: 0x0600D45B RID: 54363 RVA: 0x003CA66E File Offset: 0x003C886E
		public int[] txtdivide { get; set; }

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600D45C RID: 54364 RVA: 0x003CA677 File Offset: 0x003C8877
		// (set) Token: 0x0600D45D RID: 54365 RVA: 0x003CA67F File Offset: 0x003C887F
		public int bookid { get; set; }

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600D45E RID: 54366 RVA: 0x003CA688 File Offset: 0x003C8888
		// (set) Token: 0x0600D45F RID: 54367 RVA: 0x003CA690 File Offset: 0x003C8890
		public int chapterid { get; set; }

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600D460 RID: 54368 RVA: 0x003CA699 File Offset: 0x003C8899
		// (set) Token: 0x0600D461 RID: 54369 RVA: 0x003CA6A1 File Offset: 0x003C88A1
		public int id { get; set; }

		// Token: 0x0600D462 RID: 54370 RVA: 0x003CA6AC File Offset: 0x003C88AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bookid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.chaptername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.txt = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.txt[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.txtdivide = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.txtdivide[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
