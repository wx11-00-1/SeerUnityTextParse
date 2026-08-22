namespace core.config
{
	public class INpcInfo : IConfigItem
	{
		public string emoji { get; set; }

		public string initialposition { get; set; }

		public string name { get; set; }

		public string portrait { get; set; }

		public int CharacterID { get; set; }

		public int id { get; set; }

		public float scale { get; set; }

		public int silhouette { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			CharacterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			emoji = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			portrait = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			scale = ByteUtil.ReadFloat(bytes, ref byteIndex);
			silhouette = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
