namespace core.config.midleItems
{
	public class midleItemsItemDef
	{
		public int ID;

		public string Name;

		public int Max;

		public int catID;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
