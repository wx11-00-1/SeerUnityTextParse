using System;

namespace core.config
{
	// Token: 0x02001E98 RID: 7832
	public class IYearPetTrain2025Info : IConfigItem
	{
		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x0600E946 RID: 59718 RVA: 0x003E46C0 File Offset: 0x003E28C0
		// (set) Token: 0x0600E947 RID: 59719 RVA: 0x003E46C8 File Offset: 0x003E28C8
		public string battlecond { get; set; }

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x0600E948 RID: 59720 RVA: 0x003E46D1 File Offset: 0x003E28D1
		// (set) Token: 0x0600E949 RID: 59721 RVA: 0x003E46D9 File Offset: 0x003E28D9
		public string bossid { get; set; }

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x0600E94A RID: 59722 RVA: 0x003E46E2 File Offset: 0x003E28E2
		// (set) Token: 0x0600E94B RID: 59723 RVA: 0x003E46EA File Offset: 0x003E28EA
		public string prizedes { get; set; }

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x0600E94C RID: 59724 RVA: 0x003E46F3 File Offset: 0x003E28F3
		// (set) Token: 0x0600E94D RID: 59725 RVA: 0x003E46FB File Offset: 0x003E28FB
		public string prizedetail { get; set; }

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x0600E94E RID: 59726 RVA: 0x003E4704 File Offset: 0x003E2904
		// (set) Token: 0x0600E94F RID: 59727 RVA: 0x003E470C File Offset: 0x003E290C
		public int id { get; set; }

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x0600E950 RID: 59728 RVA: 0x003E4715 File Offset: 0x003E2915
		// (set) Token: 0x0600E951 RID: 59729 RVA: 0x003E471D File Offset: 0x003E291D
		public int storyid { get; set; }

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600E952 RID: 59730 RVA: 0x003E4726 File Offset: 0x003E2926
		// (set) Token: 0x0600E953 RID: 59731 RVA: 0x003E472E File Offset: 0x003E292E
		public int time { get; set; }

		// Token: 0x0600E954 RID: 59732 RVA: 0x003E4738 File Offset: 0x003E2938
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battlecond = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.prizedes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.prizedetail = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
