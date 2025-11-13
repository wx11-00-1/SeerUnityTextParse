using System;

namespace core.config
{
	// Token: 0x02001DC2 RID: 7618
	public class IPetSkinRewardInfo : IConfigItem
	{
		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x003D8FA8 File Offset: 0x003D71A8
		// (set) Token: 0x0600E031 RID: 57393 RVA: 0x003D8FB0 File Offset: 0x003D71B0
		public string reward { get; set; }

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x0600E032 RID: 57394 RVA: 0x003D8FB9 File Offset: 0x003D71B9
		// (set) Token: 0x0600E033 RID: 57395 RVA: 0x003D8FC1 File Offset: 0x003D71C1
		public int id { get; set; }

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600E034 RID: 57396 RVA: 0x003D8FCA File Offset: 0x003D71CA
		// (set) Token: 0x0600E035 RID: 57397 RVA: 0x003D8FD2 File Offset: 0x003D71D2
		public int param { get; set; }

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600E036 RID: 57398 RVA: 0x003D8FDB File Offset: 0x003D71DB
		// (set) Token: 0x0600E037 RID: 57399 RVA: 0x003D8FE3 File Offset: 0x003D71E3
		public int redbadge { get; set; }

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600E038 RID: 57400 RVA: 0x003D8FEC File Offset: 0x003D71EC
		// (set) Token: 0x0600E039 RID: 57401 RVA: 0x003D8FF4 File Offset: 0x003D71F4
		public int skintype { get; set; }

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x003D8FFD File Offset: 0x003D71FD
		// (set) Token: 0x0600E03B RID: 57403 RVA: 0x003D9005 File Offset: 0x003D7205
		public int stainfo { get; set; }

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600E03C RID: 57404 RVA: 0x003D900E File Offset: 0x003D720E
		// (set) Token: 0x0600E03D RID: 57405 RVA: 0x003D9016 File Offset: 0x003D7216
		public int subtype { get; set; }

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600E03E RID: 57406 RVA: 0x003D901F File Offset: 0x003D721F
		// (set) Token: 0x0600E03F RID: 57407 RVA: 0x003D9027 File Offset: 0x003D7227
		public int userbit { get; set; }

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600E040 RID: 57408 RVA: 0x003D9030 File Offset: 0x003D7230
		// (set) Token: 0x0600E041 RID: 57409 RVA: 0x003D9038 File Offset: 0x003D7238
		public int userinfo { get; set; }

		// Token: 0x0600E042 RID: 57410 RVA: 0x003D9044 File Offset: 0x003D7244
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skintype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stainfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userbit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
