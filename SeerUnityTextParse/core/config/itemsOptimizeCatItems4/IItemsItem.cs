using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems4
{
	public class IItemsItem : ItemData
	{
		public string Name { get; set; }

		public int Bean { get; set; }

		public int catID { get; set; }

		public int Hide { get; set; }

		public int ID { get; set; }

		public int Max { get; set; }

		public int Price { get; set; }

		public int purpose { get; set; }

		public int Rarity { get; set; }

		public int Sort { get; set; }

		public int UseMax { get; set; }

		public int VipOnly { get; set; }

		public int wd { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		public override int GetID()
		{
			return ID;
		}

		public override string GetName()
		{
			return Name;
		}

		public override int GetMax()
		{
			return Max;
		}

		public override int GetCatID()
		{
			return catID;
		}

		public override int GetBean()
		{
			return Bean;
		}

		public override bool IsHide()
		{
			return Hide != 0;
		}

		public override int GetPrice()
		{
			return Price;
		}

		public override int Getpurpose()
		{
			return purpose;
		}

		public override int GetRarity()
		{
			return Rarity;
		}

		public override int GetSort()
		{
			return Sort;
		}

		public override int GetUseMax()
		{
			return UseMax;
		}

		public override bool IsSuper()
		{
			return VipOnly != 0;
		}

		public override int Getwd()
		{
			return wd;
		}
	}
}
