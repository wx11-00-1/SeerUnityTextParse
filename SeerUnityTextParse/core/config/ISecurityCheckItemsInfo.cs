namespace core.config
{
	public class ISecurityCheckItemsInfo : IConfigItem
	{
		public string itemsname { get; set; }

		public string wrongnum { get; set; }

		public int id { get; set; }

		public int itemtype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemsname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			itemtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wrongnum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
