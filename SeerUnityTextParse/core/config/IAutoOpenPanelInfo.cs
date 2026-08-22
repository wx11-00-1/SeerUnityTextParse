namespace core.config
{
	public class IAutoOpenPanelInfo : IConfigItem
	{
		public string actionName { get; set; }

		public string controller { get; set; }

		public string endTime { get; set; }

		public string param1 { get; set; }

		public string param2 { get; set; }

		public string param3 { get; set; }

		public string startTime { get; set; }

		public int id { get; set; }

		public int moduleId { get; set; }

		public int state { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			actionName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			controller = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moduleId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			state = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
