namespace core.config
{
	public class INewSetGameInfo : IConfigItem
	{
		public string conditionDesc { get; set; }

		public string petName { get; set; }

		public int axis { get; set; }

		public int effectType { get; set; }

		public int extraParam { get; set; }

		public int id { get; set; }

		public int levelid { get; set; }

		public int petid { get; set; }

		public int petType { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			axis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			conditionDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			effectType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			extraParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			levelid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
