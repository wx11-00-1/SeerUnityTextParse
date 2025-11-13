using System;

namespace core.config
{
	// Token: 0x02001D40 RID: 7488
	public class IEventScheduleInfo : IConfigItem
	{
		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x003D2360 File Offset: 0x003D0560
		// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x003D2368 File Offset: 0x003D0568
		public int eventTime { get; set; }

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x003D2371 File Offset: 0x003D0571
		// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x003D2379 File Offset: 0x003D0579
		public int eventVenue { get; set; }

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x003D2382 File Offset: 0x003D0582
		// (set) Token: 0x0600DAD9 RID: 56025 RVA: 0x003D238A File Offset: 0x003D058A
		public int id { get; set; }

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600DADA RID: 56026 RVA: 0x003D2393 File Offset: 0x003D0593
		// (set) Token: 0x0600DADB RID: 56027 RVA: 0x003D239B File Offset: 0x003D059B
		public int oddsLeft { get; set; }

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600DADC RID: 56028 RVA: 0x003D23A4 File Offset: 0x003D05A4
		// (set) Token: 0x0600DADD RID: 56029 RVA: 0x003D23AC File Offset: 0x003D05AC
		public int oddsRight { get; set; }

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600DADE RID: 56030 RVA: 0x003D23B5 File Offset: 0x003D05B5
		// (set) Token: 0x0600DADF RID: 56031 RVA: 0x003D23BD File Offset: 0x003D05BD
		public int playerLeft { get; set; }

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600DAE0 RID: 56032 RVA: 0x003D23C6 File Offset: 0x003D05C6
		// (set) Token: 0x0600DAE1 RID: 56033 RVA: 0x003D23CE File Offset: 0x003D05CE
		public int playerRight { get; set; }

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x003D23D7 File Offset: 0x003D05D7
		// (set) Token: 0x0600DAE3 RID: 56035 RVA: 0x003D23DF File Offset: 0x003D05DF
		public int userinfo1 { get; set; }

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x003D23E8 File Offset: 0x003D05E8
		// (set) Token: 0x0600DAE5 RID: 56037 RVA: 0x003D23F0 File Offset: 0x003D05F0
		public int userinfo2 { get; set; }

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x003D23FC File Offset: 0x003D05FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.eventTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.eventVenue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.oddsLeft = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.oddsRight = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerLeft = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerRight = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
