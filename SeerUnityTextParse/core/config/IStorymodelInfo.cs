using System;

namespace core.config
{
	// Token: 0x02001E46 RID: 7750
	public class IStorymodelInfo : IConfigItem
	{
		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x003E0248 File Offset: 0x003DE448
		// (set) Token: 0x0600E5CF RID: 58831 RVA: 0x003E0250 File Offset: 0x003DE450
		public string CharacterID { get; set; }

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600E5D0 RID: 58832 RVA: 0x003E0259 File Offset: 0x003DE459
		// (set) Token: 0x0600E5D1 RID: 58833 RVA: 0x003E0261 File Offset: 0x003DE461
		public string emoji { get; set; }

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x003E026A File Offset: 0x003DE46A
		// (set) Token: 0x0600E5D3 RID: 58835 RVA: 0x003E0272 File Offset: 0x003DE472
		public string emojixy { get; set; }

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x003E027B File Offset: 0x003DE47B
		// (set) Token: 0x0600E5D5 RID: 58837 RVA: 0x003E0283 File Offset: 0x003DE483
		public string head { get; set; }

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x003E028C File Offset: 0x003DE48C
		// (set) Token: 0x0600E5D7 RID: 58839 RVA: 0x003E0294 File Offset: 0x003DE494
		public string initialposition { get; set; }

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x003E029D File Offset: 0x003DE49D
		// (set) Token: 0x0600E5D9 RID: 58841 RVA: 0x003E02A5 File Offset: 0x003DE4A5
		public string name { get; set; }

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x003E02AE File Offset: 0x003DE4AE
		// (set) Token: 0x0600E5DB RID: 58843 RVA: 0x003E02B6 File Offset: 0x003DE4B6
		public string portrait { get; set; }

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x003E02BF File Offset: 0x003DE4BF
		// (set) Token: 0x0600E5DD RID: 58845 RVA: 0x003E02C7 File Offset: 0x003DE4C7
		public int id { get; set; }

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x0600E5DE RID: 58846 RVA: 0x003E02D0 File Offset: 0x003DE4D0
		// (set) Token: 0x0600E5DF RID: 58847 RVA: 0x003E02D8 File Offset: 0x003DE4D8
		public float scale { get; set; }

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x003E02E4 File Offset: 0x003DE4E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.CharacterID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.emoji = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.emojixy = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.portrait = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.scale = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
