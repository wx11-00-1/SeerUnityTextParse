using System;

namespace core.config.Fragment
{
	// Token: 0x02002033 RID: 8243
	public class IFragmentItem
	{
		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600FBAD RID: 64429 RVA: 0x00401090 File Offset: 0x003FF290
		// (set) Token: 0x0600FBAE RID: 64430 RVA: 0x00401098 File Offset: 0x003FF298
		public int effectId { get; set; }

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600FBAF RID: 64431 RVA: 0x004010A1 File Offset: 0x003FF2A1
		// (set) Token: 0x0600FBB0 RID: 64432 RVA: 0x004010A9 File Offset: 0x003FF2A9
		public int ID { get; set; }

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600FBB1 RID: 64433 RVA: 0x004010B2 File Offset: 0x003FF2B2
		// (set) Token: 0x0600FBB2 RID: 64434 RVA: 0x004010BA File Offset: 0x003FF2BA
		public int MonsterID { get; set; }

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600FBB3 RID: 64435 RVA: 0x004010C3 File Offset: 0x003FF2C3
		// (set) Token: 0x0600FBB4 RID: 64436 RVA: 0x004010CB File Offset: 0x003FF2CB
		public int MoveID { get; set; }

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600FBB5 RID: 64437 RVA: 0x004010D4 File Offset: 0x003FF2D4
		// (set) Token: 0x0600FBB6 RID: 64438 RVA: 0x004010DC File Offset: 0x003FF2DC
		public int MovesConsume { get; set; }

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600FBB7 RID: 64439 RVA: 0x004010E5 File Offset: 0x003FF2E5
		// (set) Token: 0x0600FBB8 RID: 64440 RVA: 0x004010ED File Offset: 0x003FF2ED
		public int NeedmonID { get; set; }

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600FBB9 RID: 64441 RVA: 0x004010F6 File Offset: 0x003FF2F6
		// (set) Token: 0x0600FBBA RID: 64442 RVA: 0x004010FE File Offset: 0x003FF2FE
		public int NewseConsume { get; set; }

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600FBBB RID: 64443 RVA: 0x00401107 File Offset: 0x003FF307
		// (set) Token: 0x0600FBBC RID: 64444 RVA: 0x0040110F File Offset: 0x003FF30F
		public int NewSeIdx { get; set; }

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600FBBD RID: 64445 RVA: 0x00401118 File Offset: 0x003FF318
		// (set) Token: 0x0600FBBE RID: 64446 RVA: 0x00401120 File Offset: 0x003FF320
		public int PetConsume { get; set; }

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600FBBF RID: 64447 RVA: 0x00401129 File Offset: 0x003FF329
		// (set) Token: 0x0600FBC0 RID: 64448 RVA: 0x00401131 File Offset: 0x003FF331
		public int PetLimit { get; set; }

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600FBC1 RID: 64449 RVA: 0x0040113A File Offset: 0x003FF33A
		// (set) Token: 0x0600FBC2 RID: 64450 RVA: 0x00401142 File Offset: 0x003FF342
		public int Rarity { get; set; }

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600FBC3 RID: 64451 RVA: 0x0040114B File Offset: 0x003FF34B
		// (set) Token: 0x0600FBC4 RID: 64452 RVA: 0x00401153 File Offset: 0x003FF353
		public int show { get; set; }

		// Token: 0x0600FBC5 RID: 64453 RVA: 0x0040115C File Offset: 0x003FF35C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MoveID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MovesConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NeedmonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSeIdx = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewseConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effectId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
