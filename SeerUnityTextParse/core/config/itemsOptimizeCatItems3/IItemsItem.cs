using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems3
{
	// Token: 0x02001FF1 RID: 8177
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x0600F6BA RID: 63162 RVA: 0x003FC358 File Offset: 0x003FA558
		// (set) Token: 0x0600F6BB RID: 63163 RVA: 0x003FC360 File Offset: 0x003FA560
		public string LimitPetClass { get; set; }

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x0600F6BC RID: 63164 RVA: 0x003FC369 File Offset: 0x003FA569
		// (set) Token: 0x0600F6BD RID: 63165 RVA: 0x003FC371 File Offset: 0x003FA571
		public string Name { get; set; }

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x0600F6BE RID: 63166 RVA: 0x003FC37A File Offset: 0x003FA57A
		// (set) Token: 0x0600F6BF RID: 63167 RVA: 0x003FC382 File Offset: 0x003FA582
		public int Bean { get; set; }

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600F6C0 RID: 63168 RVA: 0x003FC38B File Offset: 0x003FA58B
		// (set) Token: 0x0600F6C1 RID: 63169 RVA: 0x003FC393 File Offset: 0x003FA593
		public int catID { get; set; }

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600F6C2 RID: 63170 RVA: 0x003FC39C File Offset: 0x003FA59C
		// (set) Token: 0x0600F6C3 RID: 63171 RVA: 0x003FC3A4 File Offset: 0x003FA5A4
		public int EvRemove { get; set; }

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600F6C4 RID: 63172 RVA: 0x003FC3AD File Offset: 0x003FA5AD
		// (set) Token: 0x0600F6C5 RID: 63173 RVA: 0x003FC3B5 File Offset: 0x003FA5B5
		public int Hide { get; set; }

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600F6C6 RID: 63174 RVA: 0x003FC3BE File Offset: 0x003FA5BE
		// (set) Token: 0x0600F6C7 RID: 63175 RVA: 0x003FC3C6 File Offset: 0x003FA5C6
		public int ID { get; set; }

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600F6C8 RID: 63176 RVA: 0x003FC3CF File Offset: 0x003FA5CF
		// (set) Token: 0x0600F6C9 RID: 63177 RVA: 0x003FC3D7 File Offset: 0x003FA5D7
		public int IncreMonLvTo { get; set; }

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600F6CA RID: 63178 RVA: 0x003FC3E0 File Offset: 0x003FA5E0
		// (set) Token: 0x0600F6CB RID: 63179 RVA: 0x003FC3E8 File Offset: 0x003FA5E8
		public int ItemType { get; set; }

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600F6CC RID: 63180 RVA: 0x003FC3F1 File Offset: 0x003FA5F1
		// (set) Token: 0x0600F6CD RID: 63181 RVA: 0x003FC3F9 File Offset: 0x003FA5F9
		public int Max { get; set; }

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600F6CE RID: 63182 RVA: 0x003FC402 File Offset: 0x003FA602
		// (set) Token: 0x0600F6CF RID: 63183 RVA: 0x003FC40A File Offset: 0x003FA60A
		public int PP { get; set; }

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600F6D0 RID: 63184 RVA: 0x003FC413 File Offset: 0x003FA613
		// (set) Token: 0x0600F6D1 RID: 63185 RVA: 0x003FC41B File Offset: 0x003FA61B
		public int Price { get; set; }

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x0600F6D2 RID: 63186 RVA: 0x003FC424 File Offset: 0x003FA624
		// (set) Token: 0x0600F6D3 RID: 63187 RVA: 0x003FC42C File Offset: 0x003FA62C
		public int purpose { get; set; }

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x0600F6D4 RID: 63188 RVA: 0x003FC435 File Offset: 0x003FA635
		// (set) Token: 0x0600F6D5 RID: 63189 RVA: 0x003FC43D File Offset: 0x003FA63D
		public int Rarity { get; set; }

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x0600F6D6 RID: 63190 RVA: 0x003FC446 File Offset: 0x003FA646
		// (set) Token: 0x0600F6D7 RID: 63191 RVA: 0x003FC44E File Offset: 0x003FA64E
		public int Sort { get; set; }

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600F6D8 RID: 63192 RVA: 0x003FC457 File Offset: 0x003FA657
		// (set) Token: 0x0600F6D9 RID: 63193 RVA: 0x003FC45F File Offset: 0x003FA65F
		public int UseMax { get; set; }

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600F6DA RID: 63194 RVA: 0x003FC468 File Offset: 0x003FA668
		// (set) Token: 0x0600F6DB RID: 63195 RVA: 0x003FC470 File Offset: 0x003FA670
		public int VipOnly { get; set; }

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600F6DC RID: 63196 RVA: 0x003FC479 File Offset: 0x003FA679
		// (set) Token: 0x0600F6DD RID: 63197 RVA: 0x003FC481 File Offset: 0x003FA681
		public int wd { get; set; }

		// Token: 0x0600F6DE RID: 63198 RVA: 0x003FC48C File Offset: 0x003FA68C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvRemove = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IncreMonLvTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitPetClass = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.PP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F6DF RID: 63199 RVA: 0x003FC591 File Offset: 0x003FA791
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x003FC599 File Offset: 0x003FA799
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x003FC5A1 File Offset: 0x003FA7A1
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x003FC5A9 File Offset: 0x003FA7A9
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x003FC5B1 File Offset: 0x003FA7B1
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x003FC5B9 File Offset: 0x003FA7B9
		public override int GetEvRemove()
		{
			return this.EvRemove;
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x003FC5C1 File Offset: 0x003FA7C1
		public override bool IsHide()
		{
			return this.Hide == 1;
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x003FC5CC File Offset: 0x003FA7CC
		public override int GetIncreMonLvTo()
		{
			return this.IncreMonLvTo;
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x003FC5D4 File Offset: 0x003FA7D4
		public override int GetItemType()
		{
			return this.ItemType;
		}

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x003FC5DC File Offset: 0x003FA7DC
		public override List<int> GetLimitPetClass()
		{
			//if (!this.LimitPetClass.IsValidStr())
			//{
			//	return null;
			//}
			//string limitPetClass = this.LimitPetClass;
			//if (limitPetClass == null)
			//{
			//	return null;
			//}
			//return limitPetClass.Split(' ', StringSplitOptions.None).Select(new Func<string, int>(int.Parse)).ToList<int>();
			return null;
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x003FC617 File Offset: 0x003FA817
		public override int GetPP()
		{
			return this.PP;
		}

		// Token: 0x0600F6EA RID: 63210 RVA: 0x003FC61F File Offset: 0x003FA81F
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x003FC627 File Offset: 0x003FA827
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x003FC62F File Offset: 0x003FA82F
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x003FC637 File Offset: 0x003FA837
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x003FC63F File Offset: 0x003FA83F
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x003FC647 File Offset: 0x003FA847
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x0600F6F0 RID: 63216 RVA: 0x003FC652 File Offset: 0x003FA852
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
