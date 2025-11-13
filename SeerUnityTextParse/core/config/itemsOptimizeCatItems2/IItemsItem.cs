using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems2
{
	// Token: 0x02002001 RID: 8193
	public class IItemsItem : ItemData
	{
		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600F7C6 RID: 63430 RVA: 0x003FD338 File Offset: 0x003FB538
		// (set) Token: 0x0600F7C7 RID: 63431 RVA: 0x003FD340 File Offset: 0x003FB540
		public string Color { get; set; }

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x0600F7C8 RID: 63432 RVA: 0x003FD349 File Offset: 0x003FB549
		// (set) Token: 0x0600F7C9 RID: 63433 RVA: 0x003FD351 File Offset: 0x003FB551
		public string Name { get; set; }

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x0600F7CA RID: 63434 RVA: 0x003FD35A File Offset: 0x003FB55A
		// (set) Token: 0x0600F7CB RID: 63435 RVA: 0x003FD362 File Offset: 0x003FB562
		public int catID { get; set; }

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x0600F7CC RID: 63436 RVA: 0x003FD36B File Offset: 0x003FB56B
		// (set) Token: 0x0600F7CD RID: 63437 RVA: 0x003FD373 File Offset: 0x003FB573
		public int ID { get; set; }

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600F7CE RID: 63438 RVA: 0x003FD37C File Offset: 0x003FB57C
		// (set) Token: 0x0600F7CF RID: 63439 RVA: 0x003FD384 File Offset: 0x003FB584
		public int Max { get; set; }

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600F7D0 RID: 63440 RVA: 0x003FD38D File Offset: 0x003FB58D
		// (set) Token: 0x0600F7D1 RID: 63441 RVA: 0x003FD395 File Offset: 0x003FB595
		public int Price { get; set; }

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600F7D2 RID: 63442 RVA: 0x003FD39E File Offset: 0x003FB59E
		// (set) Token: 0x0600F7D3 RID: 63443 RVA: 0x003FD3A6 File Offset: 0x003FB5A6
		public int Texture { get; set; }

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x003FD3B0 File Offset: 0x003FB5B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Color = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Texture = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x003FD426 File Offset: 0x003FB626
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x003FD42E File Offset: 0x003FB62E
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x003FD436 File Offset: 0x003FB636
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x003FD43E File Offset: 0x003FB63E
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x003FD446 File Offset: 0x003FB646
		public override string GetColor()
		{
			return this.Color;
		}

		// Token: 0x0600F7DA RID: 63450 RVA: 0x003FD44E File Offset: 0x003FB64E
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x003FD456 File Offset: 0x003FB656
		public override int GetTexture()
		{
			return this.Texture;
		}
	}
}
