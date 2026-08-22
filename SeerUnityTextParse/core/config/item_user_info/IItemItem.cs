namespace core.config.item_user_info
{
	public class IItemItem
	{
		public string desc { get; set; }

		public int itemid { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
