using System;

namespace core.config
{
	// Token: 0x02001DCC RID: 7628
	public class IPrivateTrainExtraRewardInfo : IConfigItem
	{
		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x0600E09A RID: 57498 RVA: 0x003D9780 File Offset: 0x003D7980
		// (set) Token: 0x0600E09B RID: 57499 RVA: 0x003D9788 File Offset: 0x003D7988
		public string reward { get; set; }

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x0600E09C RID: 57500 RVA: 0x003D9791 File Offset: 0x003D7991
		// (set) Token: 0x0600E09D RID: 57501 RVA: 0x003D9799 File Offset: 0x003D7999
		public int id { get; set; }

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x0600E09E RID: 57502 RVA: 0x003D97A2 File Offset: 0x003D79A2
		// (set) Token: 0x0600E09F RID: 57503 RVA: 0x003D97AA File Offset: 0x003D79AA
		public int value { get; set; }

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x003D97B3 File Offset: 0x003D79B3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
