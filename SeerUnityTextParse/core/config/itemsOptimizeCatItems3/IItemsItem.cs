using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems3
{
	public class IItemsItem : ItemData
	{
		public string LimitPetClass { get; set; }

		public string Name { get; set; }

		public int Bean { get; set; }

		public int catID { get; set; }

		public int EvRemove { get; set; }

		public int Hide { get; set; }

		public int ID { get; set; }

		public int IncreMonLvTo { get; set; }

		public int ItemType { get; set; }

		public int Max { get; set; }

		public int PP { get; set; }

		public int Price { get; set; }

		public int purpose { get; set; }

		public int Rarity { get; set; }

		public int Sort { get; set; }

		public int UseMax { get; set; }

		public int VipOnly { get; set; }

		public int wd { get; set; }

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

		public override int GetID()
		{
			return this.ID;
		}

		public override string GetName()
		{
			return this.Name;
		}

		public override int GetMax()
		{
			return this.Max;
		}

		public override int GetCatID()
		{
			return this.catID;
		}

		public override int GetBean()
		{
			return this.Bean;
		}

		public override int GetEvRemove()
		{
			return this.EvRemove;
		}

		public override bool IsHide()
		{
			return this.Hide == 1;
		}

		public override int GetIncreMonLvTo()
		{
			return this.IncreMonLvTo;
		}

		public override int GetItemType()
		{
			return this.ItemType;
		}

		public override List<int> GetLimitPetClass()
		{
			return null;
		}

		public override int GetPP()
		{
			return this.PP;
		}

		public override int GetPrice()
		{
			return this.Price;
		}

		public override int Getpurpose()
		{
			return this.purpose;
		}

		public override int GetRarity()
		{
			return this.Rarity;
		}

		public override int GetSort()
		{
			return this.Sort;
		}

		public override int GetUseMax()
		{
			return this.UseMax;
		}

		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		public override int Getwd()
		{
			return this.wd;
		}
	}
}
