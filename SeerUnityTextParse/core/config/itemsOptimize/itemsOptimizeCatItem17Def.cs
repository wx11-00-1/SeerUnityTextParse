namespace core.config.itemsOptimize
{
	public class itemsOptimizeCatItem17Def : ItemData
	{
		public int catID;

		public int ID;

		public string Name;

		public int Max;

		public int Bean;

		public string ExchangeOutCnt;

		public string ExchangeOutId;

		public int ExchangeId;

		public int ExchangeType;

		public int Hide;

		public int hideNum;

		public int ItemType;

		public int LifeTime;

		public int Price;

		public int purpose;

		public int TargetId;

		public int Rarity;

		public int Sort;

		public int wd;

		public string UseEnd;

		public int SkinId;

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

		public override int GetExchangeId()
		{
			return ExchangeId;
		}

		public override int GetExchangeType()
		{
			return ExchangeType;
		}

		public override bool IsHide()
		{
			return Hide != 0;
		}

		public override int GethideNum()
		{
			return hideNum;
		}

		public override int GetItemType()
		{
			return ItemType;
		}

		public override int GetLifeTime()
		{
			return LifeTime;
		}

		public override int GetPrice()
		{
			return Price;
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

		public override string GetUseEnd()
		{
			return UseEnd;
		}

		public override int GetSkinId()
		{
			return SkinId;
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
			ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
