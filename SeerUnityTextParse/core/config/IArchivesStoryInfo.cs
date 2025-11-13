using System;

namespace core.config
{
	// Token: 0x02001CA4 RID: 7332
	public class IArchivesStoryInfo : IConfigItem
	{
		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600D468 RID: 54376 RVA: 0x003CA7F0 File Offset: 0x003C89F0
		// (set) Token: 0x0600D469 RID: 54377 RVA: 0x003CA7F8 File Offset: 0x003C89F8
		public string classname { get; set; }

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600D46A RID: 54378 RVA: 0x003CA801 File Offset: 0x003C8A01
		// (set) Token: 0x0600D46B RID: 54379 RVA: 0x003CA809 File Offset: 0x003C8A09
		public string monname { get; set; }

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600D46C RID: 54380 RVA: 0x003CA812 File Offset: 0x003C8A12
		// (set) Token: 0x0600D46D RID: 54381 RVA: 0x003CA81A File Offset: 0x003C8A1A
		public string txt { get; set; }

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600D46E RID: 54382 RVA: 0x003CA823 File Offset: 0x003C8A23
		// (set) Token: 0x0600D46F RID: 54383 RVA: 0x003CA82B File Offset: 0x003C8A2B
		public int[] samemonid { get; set; }

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600D470 RID: 54384 RVA: 0x003CA834 File Offset: 0x003C8A34
		// (set) Token: 0x0600D471 RID: 54385 RVA: 0x003CA83C File Offset: 0x003C8A3C
		public int classid { get; set; }

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600D472 RID: 54386 RVA: 0x003CA845 File Offset: 0x003C8A45
		// (set) Token: 0x0600D473 RID: 54387 RVA: 0x003CA84D File Offset: 0x003C8A4D
		public int id { get; set; }

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600D474 RID: 54388 RVA: 0x003CA856 File Offset: 0x003C8A56
		// (set) Token: 0x0600D475 RID: 54389 RVA: 0x003CA85E File Offset: 0x003C8A5E
		public int isrec { get; set; }

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600D476 RID: 54390 RVA: 0x003CA867 File Offset: 0x003C8A67
		// (set) Token: 0x0600D477 RID: 54391 RVA: 0x003CA86F File Offset: 0x003C8A6F
		public int monid { get; set; }

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x0600D478 RID: 54392 RVA: 0x003CA878 File Offset: 0x003C8A78
		// (set) Token: 0x0600D479 RID: 54393 RVA: 0x003CA880 File Offset: 0x003C8A80
		public int storyid { get; set; }

		// Token: 0x0600D47A RID: 54394 RVA: 0x003CA88C File Offset: 0x003C8A8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.classid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.classname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isrec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.samemonid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.samemonid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.txt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
