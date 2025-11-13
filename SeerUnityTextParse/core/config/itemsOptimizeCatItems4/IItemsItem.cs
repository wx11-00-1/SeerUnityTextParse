using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems4
{
	// Token: 0x02001FEF RID: 8175
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600F68B RID: 63115 RVA: 0x003FC0B8 File Offset: 0x003FA2B8
		// (set) Token: 0x0600F68C RID: 63116 RVA: 0x003FC0C0 File Offset: 0x003FA2C0
		public string Name { get; set; }

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600F68D RID: 63117 RVA: 0x003FC0C9 File Offset: 0x003FA2C9
		// (set) Token: 0x0600F68E RID: 63118 RVA: 0x003FC0D1 File Offset: 0x003FA2D1
		public int Bean { get; set; }

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600F68F RID: 63119 RVA: 0x003FC0DA File Offset: 0x003FA2DA
		// (set) Token: 0x0600F690 RID: 63120 RVA: 0x003FC0E2 File Offset: 0x003FA2E2
		public int catID { get; set; }

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0600F691 RID: 63121 RVA: 0x003FC0EB File Offset: 0x003FA2EB
		// (set) Token: 0x0600F692 RID: 63122 RVA: 0x003FC0F3 File Offset: 0x003FA2F3
		public int Hide { get; set; }

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0600F693 RID: 63123 RVA: 0x003FC0FC File Offset: 0x003FA2FC
		// (set) Token: 0x0600F694 RID: 63124 RVA: 0x003FC104 File Offset: 0x003FA304
		public int ID { get; set; }

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x0600F695 RID: 63125 RVA: 0x003FC10D File Offset: 0x003FA30D
		// (set) Token: 0x0600F696 RID: 63126 RVA: 0x003FC115 File Offset: 0x003FA315
		public int Max { get; set; }

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x0600F697 RID: 63127 RVA: 0x003FC11E File Offset: 0x003FA31E
		// (set) Token: 0x0600F698 RID: 63128 RVA: 0x003FC126 File Offset: 0x003FA326
		public int Price { get; set; }

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x0600F699 RID: 63129 RVA: 0x003FC12F File Offset: 0x003FA32F
		// (set) Token: 0x0600F69A RID: 63130 RVA: 0x003FC137 File Offset: 0x003FA337
		public int purpose { get; set; }

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600F69B RID: 63131 RVA: 0x003FC140 File Offset: 0x003FA340
		// (set) Token: 0x0600F69C RID: 63132 RVA: 0x003FC148 File Offset: 0x003FA348
		public int Rarity { get; set; }

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600F69D RID: 63133 RVA: 0x003FC151 File Offset: 0x003FA351
		// (set) Token: 0x0600F69E RID: 63134 RVA: 0x003FC159 File Offset: 0x003FA359
		public int Sort { get; set; }

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600F69F RID: 63135 RVA: 0x003FC162 File Offset: 0x003FA362
		// (set) Token: 0x0600F6A0 RID: 63136 RVA: 0x003FC16A File Offset: 0x003FA36A
		public int UseMax { get; set; }

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x0600F6A1 RID: 63137 RVA: 0x003FC173 File Offset: 0x003FA373
		// (set) Token: 0x0600F6A2 RID: 63138 RVA: 0x003FC17B File Offset: 0x003FA37B
		public int VipOnly { get; set; }

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600F6A3 RID: 63139 RVA: 0x003FC184 File Offset: 0x003FA384
		// (set) Token: 0x0600F6A4 RID: 63140 RVA: 0x003FC18C File Offset: 0x003FA38C
		public int wd { get; set; }

		// Token: 0x0600F6A5 RID: 63141 RVA: 0x003FC198 File Offset: 0x003FA398
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F6A6 RID: 63142 RVA: 0x003FC255 File Offset: 0x003FA455
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x003FC25D File Offset: 0x003FA45D
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x003FC265 File Offset: 0x003FA465
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F6A9 RID: 63145 RVA: 0x003FC26D File Offset: 0x003FA46D
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F6AA RID: 63146 RVA: 0x003FC275 File Offset: 0x003FA475
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x003FC27D File Offset: 0x003FA47D
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F6AC RID: 63148 RVA: 0x003FC288 File Offset: 0x003FA488
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x003FC290 File Offset: 0x003FA490
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F6AE RID: 63150 RVA: 0x003FC298 File Offset: 0x003FA498
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F6AF RID: 63151 RVA: 0x003FC2A0 File Offset: 0x003FA4A0
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x003FC2A8 File Offset: 0x003FA4A8
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x003FC2B0 File Offset: 0x003FA4B0
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x003FC2BB File Offset: 0x003FA4BB
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
