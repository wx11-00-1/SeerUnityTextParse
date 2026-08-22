using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems2
{
	public class IItemsItem : ItemData
	{
		public string Color { get; set; }

		public string Name { get; set; }

		public int catID { get; set; }

		public int ID { get; set; }

		public int Max { get; set; }

		public int Price { get; set; }

		public int Texture { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Color = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Texture = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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

		public override string GetColor()
		{
			return Color;
		}

		public override int GetPrice()
		{
			return Price;
		}

		public override int GetTexture()
		{
			return Texture;
		}
	}
}
