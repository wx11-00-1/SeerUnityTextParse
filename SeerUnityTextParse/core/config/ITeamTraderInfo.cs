using System;

namespace core.config
{
	// Token: 0x02001E7A RID: 7802
	public class ITeamTraderInfo : IConfigItem
	{
		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x0600E828 RID: 59432 RVA: 0x003E2F64 File Offset: 0x003E1164
		// (set) Token: 0x0600E829 RID: 59433 RVA: 0x003E2F6C File Offset: 0x003E116C
		public string item_id { get; set; }

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x0600E82A RID: 59434 RVA: 0x003E2F75 File Offset: 0x003E1175
		// (set) Token: 0x0600E82B RID: 59435 RVA: 0x003E2F7D File Offset: 0x003E117D
		public string item_name { get; set; }

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x0600E82C RID: 59436 RVA: 0x003E2F86 File Offset: 0x003E1186
		// (set) Token: 0x0600E82D RID: 59437 RVA: 0x003E2F8E File Offset: 0x003E118E
		public string limit_type { get; set; }

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600E82E RID: 59438 RVA: 0x003E2F97 File Offset: 0x003E1197
		// (set) Token: 0x0600E82F RID: 59439 RVA: 0x003E2F9F File Offset: 0x003E119F
		public string visible { get; set; }

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600E830 RID: 59440 RVA: 0x003E2FA8 File Offset: 0x003E11A8
		// (set) Token: 0x0600E831 RID: 59441 RVA: 0x003E2FB0 File Offset: 0x003E11B0
		public int id { get; set; }

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600E832 RID: 59442 RVA: 0x003E2FB9 File Offset: 0x003E11B9
		// (set) Token: 0x0600E833 RID: 59443 RVA: 0x003E2FC1 File Offset: 0x003E11C1
		public int limit_num { get; set; }

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600E834 RID: 59444 RVA: 0x003E2FCA File Offset: 0x003E11CA
		// (set) Token: 0x0600E835 RID: 59445 RVA: 0x003E2FD2 File Offset: 0x003E11D2
		public int output { get; set; }

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x0600E836 RID: 59446 RVA: 0x003E2FDB File Offset: 0x003E11DB
		// (set) Token: 0x0600E837 RID: 59447 RVA: 0x003E2FE3 File Offset: 0x003E11E3
		public int price { get; set; }

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x0600E838 RID: 59448 RVA: 0x003E2FEC File Offset: 0x003E11EC
		// (set) Token: 0x0600E839 RID: 59449 RVA: 0x003E2FF4 File Offset: 0x003E11F4
		public int sorting { get; set; }

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x0600E83A RID: 59450 RVA: 0x003E2FFD File Offset: 0x003E11FD
		// (set) Token: 0x0600E83B RID: 59451 RVA: 0x003E3005 File Offset: 0x003E1205
		public int UserInfoId { get; set; }

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600E83C RID: 59452 RVA: 0x003E300E File Offset: 0x003E120E
		// (set) Token: 0x0600E83D RID: 59453 RVA: 0x003E3016 File Offset: 0x003E1216
		public int UserInfoPos { get; set; }

		// Token: 0x0600E83E RID: 59454 RVA: 0x003E3020 File Offset: 0x003E1220
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfoPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item_id = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.item_name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.limit_num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit_type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.visible = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
