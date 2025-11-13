using System;

namespace core.config
{
	// Token: 0x02001DC6 RID: 7622
	public class IPrivateCostDiamondRewardInfo : IConfigItem
	{
		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x003D92C8 File Offset: 0x003D74C8
		// (set) Token: 0x0600E05D RID: 57437 RVA: 0x003D92D0 File Offset: 0x003D74D0
		public string reward { get; set; }

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600E05E RID: 57438 RVA: 0x003D92D9 File Offset: 0x003D74D9
		// (set) Token: 0x0600E05F RID: 57439 RVA: 0x003D92E1 File Offset: 0x003D74E1
		public int id { get; set; }

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x0600E060 RID: 57440 RVA: 0x003D92EA File Offset: 0x003D74EA
		// (set) Token: 0x0600E061 RID: 57441 RVA: 0x003D92F2 File Offset: 0x003D74F2
		public int step { get; set; }

		// Token: 0x0600E062 RID: 57442 RVA: 0x003D92FB File Offset: 0x003D74FB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
