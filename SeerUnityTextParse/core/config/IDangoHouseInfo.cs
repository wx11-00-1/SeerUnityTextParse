namespace core.config
{
	public class IDangoHouseInfo : IConfigItem
	{
		public string name { get; set; }

		public int id { get; set; }

		public int limitCost { get; set; }

		public int roomID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitCost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			roomID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
