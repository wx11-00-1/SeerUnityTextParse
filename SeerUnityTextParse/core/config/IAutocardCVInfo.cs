namespace core.config
{
	public class IAutocardCVInfo : IConfigItem
	{
		public string actName { get; set; }

		public string name { get; set; }

		public string sceneApply { get; set; }

		public int id { get; set; }

		public int probability { get; set; }

		public int useID { get; set; }

		public int useType { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			actName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			probability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sceneApply = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			useID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			useType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
