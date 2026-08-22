namespace core.config.skin_shop
{
	public class ISkinItem
	{
		public int dayLeft;

		public int popType;

		public bool hasBuy;

		public string Name { get; set; }

		public int[] Show { get; set; }

		public int Batch { get; set; }

		public int CardPrice { get; set; }

		public int DiamondPrice { get; set; }

		public int ID { get; set; }

		public int MonID { get; set; }

		public int OriginalPrice { get; set; }

		public int ProductId { get; set; }

		public int Rec { get; set; }

		public int SkinID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			CardPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			DiamondPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			OriginalPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ProductId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Show = new int[num];
				for (int i = 0; i < num; i++)
				{
					Show[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
