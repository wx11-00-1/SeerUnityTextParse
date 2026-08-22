namespace core.config
{
	public class IZumaGmeInfo : IConfigItem
	{
		public string color { get; set; }

		public string skill { get; set; }

		public string speed { get; set; }

		public int after { get; set; }

		public int first { get; set; }

		public int id { get; set; }

		public int map { get; set; }

		public int railtype { get; set; }

		public int stageid { get; set; }

		public int time { get; set; }

		public int type { get; set; }

		public int weight1 { get; set; }

		public int weight2 { get; set; }

		public int weight3 { get; set; }

		public int weight4 { get; set; }

		public int weight5 { get; set; }

		public int weight6 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			after = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			color = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			first = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			map = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			railtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skill = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			speed = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
