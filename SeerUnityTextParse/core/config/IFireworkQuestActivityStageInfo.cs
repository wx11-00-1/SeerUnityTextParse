using System;

namespace core.config
{
	// Token: 0x02001FDD RID: 8157
	public class IFireworkQuestActivityStageInfo : IConfigItem
	{
		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x0600F4AC RID: 62636 RVA: 0x00438230 File Offset: 0x00436430
		// (set) Token: 0x0600F4AD RID: 62637 RVA: 0x00438238 File Offset: 0x00436438
		public string stageAward { get; set; }

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x0600F4AE RID: 62638 RVA: 0x00438241 File Offset: 0x00436441
		// (set) Token: 0x0600F4AF RID: 62639 RVA: 0x00438249 File Offset: 0x00436449
		public string stageBlockPool { get; set; }

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x0600F4B0 RID: 62640 RVA: 0x00438252 File Offset: 0x00436452
		// (set) Token: 0x0600F4B1 RID: 62641 RVA: 0x0043825A File Offset: 0x0043645A
		public string stageSetting { get; set; }

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600F4B2 RID: 62642 RVA: 0x00438263 File Offset: 0x00436463
		// (set) Token: 0x0600F4B3 RID: 62643 RVA: 0x0043826B File Offset: 0x0043646B
		public string stageStory { get; set; }

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600F4B4 RID: 62644 RVA: 0x00438274 File Offset: 0x00436474
		// (set) Token: 0x0600F4B5 RID: 62645 RVA: 0x0043827C File Offset: 0x0043647C
		public string stageTarget { get; set; }

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x0600F4B6 RID: 62646 RVA: 0x00438285 File Offset: 0x00436485
		// (set) Token: 0x0600F4B7 RID: 62647 RVA: 0x0043828D File Offset: 0x0043648D
		public string stageTutorial { get; set; }

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x0600F4B8 RID: 62648 RVA: 0x00438296 File Offset: 0x00436496
		// (set) Token: 0x0600F4B9 RID: 62649 RVA: 0x0043829E File Offset: 0x0043649E
		public int chapterId { get; set; }

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600F4BA RID: 62650 RVA: 0x004382A7 File Offset: 0x004364A7
		// (set) Token: 0x0600F4BB RID: 62651 RVA: 0x004382AF File Offset: 0x004364AF
		public int id { get; set; }

		// Token: 0x0600F4BC RID: 62652 RVA: 0x004382B8 File Offset: 0x004364B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chapterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageAward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageBlockPool = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageSetting = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageStory = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageTarget = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageTutorial = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
