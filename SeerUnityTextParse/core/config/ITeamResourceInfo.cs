using System;

namespace core.config
{
	// Token: 0x02001E76 RID: 7798
	public class ITeamResourceInfo : IConfigItem
	{
		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x0600E800 RID: 59392 RVA: 0x003E2C00 File Offset: 0x003E0E00
		// (set) Token: 0x0600E801 RID: 59393 RVA: 0x003E2C08 File Offset: 0x003E0E08
		public int ExchangeLimit { get; set; }

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x0600E802 RID: 59394 RVA: 0x003E2C11 File Offset: 0x003E0E11
		// (set) Token: 0x0600E803 RID: 59395 RVA: 0x003E2C19 File Offset: 0x003E0E19
		public int id { get; set; }

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x0600E804 RID: 59396 RVA: 0x003E2C22 File Offset: 0x003E0E22
		// (set) Token: 0x0600E805 RID: 59397 RVA: 0x003E2C2A File Offset: 0x003E0E2A
		public int ObtainItemNeedContribute { get; set; }

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x0600E806 RID: 59398 RVA: 0x003E2C33 File Offset: 0x003E0E33
		// (set) Token: 0x0600E807 RID: 59399 RVA: 0x003E2C3B File Offset: 0x003E0E3B
		public int ObtainItemNeedExp { get; set; }

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x0600E808 RID: 59400 RVA: 0x003E2C44 File Offset: 0x003E0E44
		// (set) Token: 0x0600E809 RID: 59401 RVA: 0x003E2C4C File Offset: 0x003E0E4C
		public int RewardID { get; set; }

		// Token: 0x0600E80A RID: 59402 RVA: 0x003E2C58 File Offset: 0x003E0E58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExchangeLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ObtainItemNeedContribute = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ObtainItemNeedExp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
