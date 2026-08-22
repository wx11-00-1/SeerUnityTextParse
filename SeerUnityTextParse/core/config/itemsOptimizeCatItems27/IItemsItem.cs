using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems27
{
	public class IItemsItem : ItemData
	{
		public string Name { get; set; }

		public int Bean { get; set; }

		public int catID { get; set; }

		public int Hide { get; set; }

		public int ID { get; set; }

		public int IsMidle { get; set; }

		public int Max { get; set; }

		public int purpose { get; set; }

		public int Sort { get; set; }

		public int Tradability { get; set; }

		public int VipTradability { get; set; }

		public int wd { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsMidle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Tradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipTradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
			return Hide == 1;
		}

		public override int Getpurpose()
		{
			return purpose;
		}

		public override int GetSort()
		{
			return Sort;
		}

		public override int Getwd()
		{
			return wd;
		}

		public override int GetIsMidle()
		{
			return IsMidle;
		}

		public override int GetTradability()
		{
			return Tradability;
		}

		public override int GetVipTradability()
		{
			return VipTradability;
		}
	}
}
