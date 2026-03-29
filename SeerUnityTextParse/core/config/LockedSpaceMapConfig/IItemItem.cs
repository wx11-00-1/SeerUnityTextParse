using System;

namespace core.config.LockedSpaceMapConfig
{
	// Token: 0x0200257F RID: 9599
	public class IItemItem : IConfigItem
	{
		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06012A99 RID: 76441 RVA: 0x004BDE70 File Offset: 0x004BC070
		// (set) Token: 0x06012A9A RID: 76442 RVA: 0x004BDE78 File Offset: 0x004BC078
		public string isHide { get; set; }

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06012A9B RID: 76443 RVA: 0x004BDE81 File Offset: 0x004BC081
		// (set) Token: 0x06012A9C RID: 76444 RVA: 0x004BDE89 File Offset: 0x004BC089
		public string mainlineType { get; set; }

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06012A9D RID: 76445 RVA: 0x004BDE92 File Offset: 0x004BC092
		// (set) Token: 0x06012A9E RID: 76446 RVA: 0x004BDE9A File Offset: 0x004BC09A
		public string outlevel { get; set; }

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06012A9F RID: 76447 RVA: 0x004BDEA3 File Offset: 0x004BC0A3
		// (set) Token: 0x06012AA0 RID: 76448 RVA: 0x004BDEAB File Offset: 0x004BC0AB
		public string param { get; set; }

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06012AA1 RID: 76449 RVA: 0x004BDEB4 File Offset: 0x004BC0B4
		// (set) Token: 0x06012AA2 RID: 76450 RVA: 0x004BDEBC File Offset: 0x004BC0BC
		public string showDialog { get; set; }

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06012AA3 RID: 76451 RVA: 0x004BDEC5 File Offset: 0x004BC0C5
		// (set) Token: 0x06012AA4 RID: 76452 RVA: 0x004BDECD File Offset: 0x004BC0CD
		public string showNpc { get; set; }

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06012AA5 RID: 76453 RVA: 0x004BDED6 File Offset: 0x004BC0D6
		// (set) Token: 0x06012AA6 RID: 76454 RVA: 0x004BDEDE File Offset: 0x004BC0DE
		public int coreReward { get; set; }

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06012AA7 RID: 76455 RVA: 0x004BDEE7 File Offset: 0x004BC0E7
		// (set) Token: 0x06012AA8 RID: 76456 RVA: 0x004BDEEF File Offset: 0x004BC0EF
		public int coreRewardSD { get; set; }

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06012AA9 RID: 76457 RVA: 0x004BDEF8 File Offset: 0x004BC0F8
		// (set) Token: 0x06012AAA RID: 76458 RVA: 0x004BDF00 File Offset: 0x004BC100
		public int id { get; set; }

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06012AAB RID: 76459 RVA: 0x004BDF09 File Offset: 0x004BC109
		// (set) Token: 0x06012AAC RID: 76460 RVA: 0x004BDF11 File Offset: 0x004BC111
		public int showMap { get; set; }

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06012AAD RID: 76461 RVA: 0x004BDF1A File Offset: 0x004BC11A
		// (set) Token: 0x06012AAE RID: 76462 RVA: 0x004BDF22 File Offset: 0x004BC122
		public int stoneReward { get; set; }

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06012AAF RID: 76463 RVA: 0x004BDF2B File Offset: 0x004BC12B
		// (set) Token: 0x06012AB0 RID: 76464 RVA: 0x004BDF33 File Offset: 0x004BC133
		public int stoneRewardSD { get; set; }

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06012AB1 RID: 76465 RVA: 0x004BDF3C File Offset: 0x004BC13C
		// (set) Token: 0x06012AB2 RID: 76466 RVA: 0x004BDF44 File Offset: 0x004BC144
		public int type { get; set; }

		// Token: 0x06012AB3 RID: 76467 RVA: 0x004BDF50 File Offset: 0x004BC150
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coreReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.coreRewardSD = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isHide = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.mainlineType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.outlevel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showDialog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showNpc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stoneReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stoneRewardSD = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
