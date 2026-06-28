using System;

namespace core.config
{
	// Token: 0x02002573 RID: 9587
	public class IAutocarddiduoRewardInfo : IConfigItem
	{
		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06012963 RID: 76131 RVA: 0x00546410 File Offset: 0x00544610
		// (set) Token: 0x06012964 RID: 76132 RVA: 0x00546418 File Offset: 0x00544618
		public string diduoReward { get; set; }

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06012965 RID: 76133 RVA: 0x00546421 File Offset: 0x00544621
		// (set) Token: 0x06012966 RID: 76134 RVA: 0x00546429 File Offset: 0x00544629
		public int coinNum { get; set; }

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06012967 RID: 76135 RVA: 0x00546432 File Offset: 0x00544632
		// (set) Token: 0x06012968 RID: 76136 RVA: 0x0054643A File Offset: 0x0054463A
		public int id { get; set; }

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06012969 RID: 76137 RVA: 0x00546443 File Offset: 0x00544643
		// (set) Token: 0x0601296A RID: 76138 RVA: 0x0054644B File Offset: 0x0054464B
		public int rewardrank { get; set; }

		// Token: 0x0601296B RID: 76139 RVA: 0x00546454 File Offset: 0x00544654
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coinNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.diduoReward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardrank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
