namespace core.config.itemsOptimize
{
	public class itemsOptimizeCatItem4Def : ItemData
	{
		public int catID;

		public int ID;

		public string Name;

		public int Max;

		public int Bean;

		public int Hide;

		public int Price;

		public int purpose;

		public int Rarity;

		public int Sort;

		public int UseMax;

		public int VipOnly;

		public int wd;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
