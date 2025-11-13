using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems18
{
	// Token: 0x02002005 RID: 8197
	public class IItemsItem : ItemData
	{
		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600F7F3 RID: 63475 RVA: 0x003FD60C File Offset: 0x003FB80C
		// (set) Token: 0x0600F7F4 RID: 63476 RVA: 0x003FD614 File Offset: 0x003FB814
		public string Name { get; set; }

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600F7F5 RID: 63477 RVA: 0x003FD61D File Offset: 0x003FB81D
		// (set) Token: 0x0600F7F6 RID: 63478 RVA: 0x003FD625 File Offset: 0x003FB825
		public int Bean { get; set; }

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600F7F7 RID: 63479 RVA: 0x003FD62E File Offset: 0x003FB82E
		// (set) Token: 0x0600F7F8 RID: 63480 RVA: 0x003FD636 File Offset: 0x003FB836
		public int catID { get; set; }

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600F7F9 RID: 63481 RVA: 0x003FD63F File Offset: 0x003FB83F
		// (set) Token: 0x0600F7FA RID: 63482 RVA: 0x003FD647 File Offset: 0x003FB847
		public int Hide { get; set; }

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600F7FB RID: 63483 RVA: 0x003FD650 File Offset: 0x003FB850
		// (set) Token: 0x0600F7FC RID: 63484 RVA: 0x003FD658 File Offset: 0x003FB858
		public int ID { get; set; }

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600F7FD RID: 63485 RVA: 0x003FD661 File Offset: 0x003FB861
		// (set) Token: 0x0600F7FE RID: 63486 RVA: 0x003FD669 File Offset: 0x003FB869
		public int Max { get; set; }

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600F7FF RID: 63487 RVA: 0x003FD672 File Offset: 0x003FB872
		// (set) Token: 0x0600F800 RID: 63488 RVA: 0x003FD67A File Offset: 0x003FB87A
		public int purpose { get; set; }

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600F801 RID: 63489 RVA: 0x003FD683 File Offset: 0x003FB883
		// (set) Token: 0x0600F802 RID: 63490 RVA: 0x003FD68B File Offset: 0x003FB88B
		public int Rarity { get; set; }

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600F803 RID: 63491 RVA: 0x003FD694 File Offset: 0x003FB894
		// (set) Token: 0x0600F804 RID: 63492 RVA: 0x003FD69C File Offset: 0x003FB89C
		public int Sort { get; set; }

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600F805 RID: 63493 RVA: 0x003FD6A5 File Offset: 0x003FB8A5
		// (set) Token: 0x0600F806 RID: 63494 RVA: 0x003FD6AD File Offset: 0x003FB8AD
		public int wd { get; set; }

		// Token: 0x0600F807 RID: 63495 RVA: 0x003FD6B8 File Offset: 0x003FB8B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F808 RID: 63496 RVA: 0x003FD74E File Offset: 0x003FB94E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x003FD756 File Offset: 0x003FB956
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F80A RID: 63498 RVA: 0x003FD75E File Offset: 0x003FB95E
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F80B RID: 63499 RVA: 0x003FD766 File Offset: 0x003FB966
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F80C RID: 63500 RVA: 0x003FD76E File Offset: 0x003FB96E
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F80D RID: 63501 RVA: 0x003FD776 File Offset: 0x003FB976
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x003FD781 File Offset: 0x003FB981
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F80F RID: 63503 RVA: 0x003FD789 File Offset: 0x003FB989
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F810 RID: 63504 RVA: 0x003FD791 File Offset: 0x003FB991
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x003FD799 File Offset: 0x003FB999
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
