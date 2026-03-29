using System;

namespace core.config.mainLine_chapter
{
	// Token: 0x02002579 RID: 9593
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06012A5D RID: 76381 RVA: 0x004BDA54 File Offset: 0x004BBC54
		// (set) Token: 0x06012A5E RID: 76382 RVA: 0x004BDA5C File Offset: 0x004BBC5C
		public string firstRewardID { get; set; }

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06012A5F RID: 76383 RVA: 0x004BDA65 File Offset: 0x004BBC65
		// (set) Token: 0x06012A60 RID: 76384 RVA: 0x004BDA6D File Offset: 0x004BBC6D
		public string firstRewardNum { get; set; }

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06012A61 RID: 76385 RVA: 0x004BDA76 File Offset: 0x004BBC76
		// (set) Token: 0x06012A62 RID: 76386 RVA: 0x004BDA7E File Offset: 0x004BBC7E
		public string index { get; set; }

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06012A63 RID: 76387 RVA: 0x004BDA87 File Offset: 0x004BBC87
		// (set) Token: 0x06012A64 RID: 76388 RVA: 0x004BDA8F File Offset: 0x004BBC8F
		public string intro { get; set; }

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06012A65 RID: 76389 RVA: 0x004BDA98 File Offset: 0x004BBC98
		// (set) Token: 0x06012A66 RID: 76390 RVA: 0x004BDAA0 File Offset: 0x004BBCA0
		public string name { get; set; }

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06012A67 RID: 76391 RVA: 0x004BDAA9 File Offset: 0x004BBCA9
		// (set) Token: 0x06012A68 RID: 76392 RVA: 0x004BDAB1 File Offset: 0x004BBCB1
		public string nextSection { get; set; }

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06012A69 RID: 76393 RVA: 0x004BDABA File Offset: 0x004BBCBA
		// (set) Token: 0x06012A6A RID: 76394 RVA: 0x004BDAC2 File Offset: 0x004BBCC2
		public int chapterID { get; set; }

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06012A6B RID: 76395 RVA: 0x004BDACB File Offset: 0x004BBCCB
		// (set) Token: 0x06012A6C RID: 76396 RVA: 0x004BDAD3 File Offset: 0x004BBCD3
		public int id { get; set; }

		// Token: 0x06012A6D RID: 76397 RVA: 0x004BDADC File Offset: 0x004BBCDC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chapterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.firstRewardID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.firstRewardNum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.index = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.nextSection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
