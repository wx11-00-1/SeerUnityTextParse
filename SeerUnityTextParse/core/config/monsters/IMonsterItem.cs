using System;

namespace core.config.monsters
{
	// Token: 0x02001FB4 RID: 8116
	public class IMonsterItem
	{
		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x0600F45E RID: 62558 RVA: 0x003F99F9 File Offset: 0x003F7BF9
		// (set) Token: 0x0600F45F RID: 62559 RVA: 0x003F9A01 File Offset: 0x003F7C01
		public string DefName { get; set; }

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600F460 RID: 62560 RVA: 0x003F9A0A File Offset: 0x003F7C0A
		// (set) Token: 0x0600F461 RID: 62561 RVA: 0x003F9A12 File Offset: 0x003F7C12
		public ILearnableMoves ExtraMoves { get; set; }

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x0600F462 RID: 62562 RVA: 0x003F9A1B File Offset: 0x003F7C1B
		// (set) Token: 0x0600F463 RID: 62563 RVA: 0x003F9A23 File Offset: 0x003F7C23
		public ILearnableMoves LearnableMoves { get; set; }

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x0600F464 RID: 62564 RVA: 0x003F9A2C File Offset: 0x003F7C2C
		// (set) Token: 0x0600F465 RID: 62565 RVA: 0x003F9A34 File Offset: 0x003F7C34
		public IMoveItem Move { get; set; }

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600F466 RID: 62566 RVA: 0x003F9A3D File Offset: 0x003F7C3D
		// (set) Token: 0x0600F467 RID: 62567 RVA: 0x003F9A45 File Offset: 0x003F7C45
		public ILearnableMoves ShowExtraMoves { get; set; }

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600F468 RID: 62568 RVA: 0x003F9A4E File Offset: 0x003F7C4E
		// (set) Token: 0x0600F469 RID: 62569 RVA: 0x003F9A56 File Offset: 0x003F7C56
		public ILearnableMoves SpExtraMoves { get; set; }

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x0600F46A RID: 62570 RVA: 0x003F9A5F File Offset: 0x003F7C5F
		// (set) Token: 0x0600F46B RID: 62571 RVA: 0x003F9A67 File Offset: 0x003F7C67
		public int Atk { get; set; }

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x0600F46C RID: 62572 RVA: 0x003F9A70 File Offset: 0x003F7C70
		// (set) Token: 0x0600F46D RID: 62573 RVA: 0x003F9A78 File Offset: 0x003F7C78
		public int CharacterAttrParam { get; set; }

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600F46E RID: 62574 RVA: 0x003F9A81 File Offset: 0x003F7C81
		// (set) Token: 0x0600F46F RID: 62575 RVA: 0x003F9A89 File Offset: 0x003F7C89
		public int Combo { get; set; }

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600F470 RID: 62576 RVA: 0x003F9A92 File Offset: 0x003F7C92
		// (set) Token: 0x0600F471 RID: 62577 RVA: 0x003F9A9A File Offset: 0x003F7C9A
		public int Def { get; set; }

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600F472 RID: 62578 RVA: 0x003F9AA3 File Offset: 0x003F7CA3
		// (set) Token: 0x0600F473 RID: 62579 RVA: 0x003F9AAB File Offset: 0x003F7CAB
		public int EvolvesTo { get; set; }

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x0600F474 RID: 62580 RVA: 0x003F9AB4 File Offset: 0x003F7CB4
		// (set) Token: 0x0600F475 RID: 62581 RVA: 0x003F9ABC File Offset: 0x003F7CBC
		public int EvolvFlag { get; set; }

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x0600F476 RID: 62582 RVA: 0x003F9AC5 File Offset: 0x003F7CC5
		// (set) Token: 0x0600F477 RID: 62583 RVA: 0x003F9ACD File Offset: 0x003F7CCD
		public int EvolvingLv { get; set; }

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x0600F478 RID: 62584 RVA: 0x003F9AD6 File Offset: 0x003F7CD6
		// (set) Token: 0x0600F479 RID: 62585 RVA: 0x003F9ADE File Offset: 0x003F7CDE
		public int FreeForbidden { get; set; }

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x0600F47A RID: 62586 RVA: 0x003F9AE7 File Offset: 0x003F7CE7
		// (set) Token: 0x0600F47B RID: 62587 RVA: 0x003F9AEF File Offset: 0x003F7CEF
		public int Gender { get; set; }

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x0600F47C RID: 62588 RVA: 0x003F9AF8 File Offset: 0x003F7CF8
		// (set) Token: 0x0600F47D RID: 62589 RVA: 0x003F9B00 File Offset: 0x003F7D00
		public int HP { get; set; }

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x0600F47E RID: 62590 RVA: 0x003F9B09 File Offset: 0x003F7D09
		// (set) Token: 0x0600F47F RID: 62591 RVA: 0x003F9B11 File Offset: 0x003F7D11
		public int ID { get; set; }

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x0600F480 RID: 62592 RVA: 0x003F9B1A File Offset: 0x003F7D1A
		// (set) Token: 0x0600F481 RID: 62593 RVA: 0x003F9B22 File Offset: 0x003F7D22
		public int isFlyPet { get; set; }

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x0600F482 RID: 62594 RVA: 0x003F9B2B File Offset: 0x003F7D2B
		// (set) Token: 0x0600F483 RID: 62595 RVA: 0x003F9B33 File Offset: 0x003F7D33
		public int isRidePet { get; set; }

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600F484 RID: 62596 RVA: 0x003F9B3C File Offset: 0x003F7D3C
		// (set) Token: 0x0600F485 RID: 62597 RVA: 0x003F9B44 File Offset: 0x003F7D44
		public int PetClass { get; set; }

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x0600F486 RID: 62598 RVA: 0x003F9B4D File Offset: 0x003F7D4D
		// (set) Token: 0x0600F487 RID: 62599 RVA: 0x003F9B55 File Offset: 0x003F7D55
		public int RealId { get; set; }

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600F488 RID: 62600 RVA: 0x003F9B5E File Offset: 0x003F7D5E
		// (set) Token: 0x0600F489 RID: 62601 RVA: 0x003F9B66 File Offset: 0x003F7D66
		public int SpAtk { get; set; }

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x0600F48A RID: 62602 RVA: 0x003F9B6F File Offset: 0x003F7D6F
		// (set) Token: 0x0600F48B RID: 62603 RVA: 0x003F9B77 File Offset: 0x003F7D77
		public int Spd { get; set; }

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x0600F48C RID: 62604 RVA: 0x003F9B80 File Offset: 0x003F7D80
		// (set) Token: 0x0600F48D RID: 62605 RVA: 0x003F9B88 File Offset: 0x003F7D88
		public int SpDef { get; set; }

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x0600F48E RID: 62606 RVA: 0x003F9B91 File Offset: 0x003F7D91
		// (set) Token: 0x0600F48F RID: 62607 RVA: 0x003F9B99 File Offset: 0x003F7D99
		public int Support { get; set; }

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x0600F490 RID: 62608 RVA: 0x003F9BA2 File Offset: 0x003F7DA2
		// (set) Token: 0x0600F491 RID: 62609 RVA: 0x003F9BAA File Offset: 0x003F7DAA
		public int Transform { get; set; }

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x0600F492 RID: 62610 RVA: 0x003F9BB3 File Offset: 0x003F7DB3
		// (set) Token: 0x0600F493 RID: 62611 RVA: 0x003F9BBB File Offset: 0x003F7DBB
		public int Type { get; set; }

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x0600F494 RID: 62612 RVA: 0x003F9BC4 File Offset: 0x003F7DC4
		// (set) Token: 0x0600F495 RID: 62613 RVA: 0x003F9BCC File Offset: 0x003F7DCC
		public int Vip { get; set; }

		// Token: 0x0600F496 RID: 62614 RVA: 0x003F9BD8 File Offset: 0x003F7DD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.CharacterAttrParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Combo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.EvolvFlag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvolvesTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvolvingLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ExtraMoves = new ILearnableMoves();
				this.ExtraMoves.Parse(bytes, ref byteIndex);
			}
			this.FreeForbidden = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Gender = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.LearnableMoves = new ILearnableMoves();
				this.LearnableMoves.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Move = new IMoveItem();
				this.Move.Parse(bytes, ref byteIndex);
			}
			this.PetClass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RealId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ShowExtraMoves = new ILearnableMoves();
				this.ShowExtraMoves.Parse(bytes, ref byteIndex);
			}
			this.SpAtk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SpDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.SpExtraMoves = new ILearnableMoves();
				this.SpExtraMoves.Parse(bytes, ref byteIndex);
			}
			this.Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Support = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isFlyPet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isRidePet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
