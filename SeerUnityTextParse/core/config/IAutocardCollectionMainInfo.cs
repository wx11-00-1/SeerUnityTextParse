namespace core.config
{
	public class IAutocardCollectionMainInfo : IConfigItem
	{
		public string animation { get; set; }

		public int id { get; set; }

		public int itemid { get; set; }

		public int rank { get; set; }

		public int sesisson { get; set; }

		public int tips { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			animation = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sesisson = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
