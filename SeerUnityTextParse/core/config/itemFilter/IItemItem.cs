namespace core.config.itemFilter
{
	public class IItemItem
	{
		public string Name { get; set; }

		public float Bonus { get; set; }

		public int bShowPetBag { get; set; }

		public int HP { get; set; }

		public int ID { get; set; }

		public int IsMidle { get; set; }

		public int ItemType { get; set; }

		public int Max { get; set; }

		public int PP { get; set; }

		public int Price { get; set; }

		public int RemoveMonStat { get; set; }

		public int sort { get; set; }

		public int Sort { get; set; }

		public int Tradability { get; set; }

		public int VipOnly { get; set; }

		public int VipTradability { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Bonus = ByteUtil.ReadFloat(bytes, ref byteIndex);
			HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsMidle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			PP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RemoveMonStat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Tradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipTradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bShowPetBag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
