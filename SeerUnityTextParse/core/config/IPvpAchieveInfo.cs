using System;

namespace core.config
{
	// Token: 0x02001DD8 RID: 7640
	public class IPvpAchieveInfo : IConfigItem
	{
		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x0600E114 RID: 57620 RVA: 0x003DA1E0 File Offset: 0x003D83E0
		// (set) Token: 0x0600E115 RID: 57621 RVA: 0x003DA1E8 File Offset: 0x003D83E8
		public string describe { get; set; }

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x0600E116 RID: 57622 RVA: 0x003DA1F1 File Offset: 0x003D83F1
		// (set) Token: 0x0600E117 RID: 57623 RVA: 0x003DA1F9 File Offset: 0x003D83F9
		public string rewardinfo { get; set; }

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600E118 RID: 57624 RVA: 0x003DA202 File Offset: 0x003D8402
		// (set) Token: 0x0600E119 RID: 57625 RVA: 0x003DA20A File Offset: 0x003D840A
		public string title { get; set; }

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x0600E11A RID: 57626 RVA: 0x003DA213 File Offset: 0x003D8413
		// (set) Token: 0x0600E11B RID: 57627 RVA: 0x003DA21B File Offset: 0x003D841B
		public int foreverType { get; set; }

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600E11C RID: 57628 RVA: 0x003DA224 File Offset: 0x003D8424
		// (set) Token: 0x0600E11D RID: 57629 RVA: 0x003DA22C File Offset: 0x003D842C
		public int id { get; set; }

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600E11E RID: 57630 RVA: 0x003DA235 File Offset: 0x003D8435
		// (set) Token: 0x0600E11F RID: 57631 RVA: 0x003DA23D File Offset: 0x003D843D
		public int value { get; set; }

		// Token: 0x0600E120 RID: 57632 RVA: 0x003DA248 File Offset: 0x003D8448
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.foreverType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
