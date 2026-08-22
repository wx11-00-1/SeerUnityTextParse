namespace core.config
{
	public class IStorymodelInfo : IConfigItem
	{
		public string CharacterID { get; set; }

		public string emoji { get; set; }

		public string emojixy { get; set; }

		public string head { get; set; }

		public string initialposition { get; set; }

		public string name { get; set; }

		public string portrait { get; set; }

		public int id { get; set; }

		public float scale { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			CharacterID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			emoji = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			emojixy = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			portrait = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			scale = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
