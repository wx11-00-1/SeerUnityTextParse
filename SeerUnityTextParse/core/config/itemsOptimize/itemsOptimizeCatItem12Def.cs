namespace core.config.itemsOptimize
{
	public class itemsOptimizeCatItem12Def : ItemData
	{
		public int catID;

		public int ID;

		public string Name;

		public int Max;

		public int Bean;

		public int ExchangeId;

		public int Hide;

		public int purpose;

		public int TargetId;

		public int Rarity;

		public int Sort;

		public int wd;

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
			return 0;
		}

		public override int GetExchangeId()
		{
			return ExchangeId;
		}

		public override bool IsHide()
		{
			return Hide != 0;
		}

		public override int Getpurpose()
		{
			return purpose;
		}

		public override int GetTargetId()
		{
			return TargetId;
		}

		public override int GetRarity()
		{
			return Rarity;
		}

		public override int GetSort()
		{
			return Sort;
		}

		public override int Getwd()
		{
			return wd;
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
