namespace core.config.itemsOptimize
{
	public class itemsOptimizeCatItem23Def : ItemData
	{
		public int catID;

		public int ID;

		public string Name;

		public int Max;

		public int Bean;

		public string ExchangeOutCnt;

		public string ExchangeOutId;

		public int Hide;

		public int icon;

		public int LifeTime;

		public int purpose;

		public int Rarity;

		public int Sort;

		public int wd;

		public int UseMax;

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

		public override string GetExchangeOutId()
		{
			return ExchangeOutId;
		}

		public override string GetExchangeOutCnt()
		{
			return ExchangeOutCnt;
		}

		public override bool IsHide()
		{
			return Hide != 0;
		}

		public override int Geticon()
		{
			return icon;
		}

		public override int GetLifeTime()
		{
			return LifeTime;
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

		public override int Getwd()
		{
			return wd;
		}

		public override int GetUseMax()
		{
			return UseMax;
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
