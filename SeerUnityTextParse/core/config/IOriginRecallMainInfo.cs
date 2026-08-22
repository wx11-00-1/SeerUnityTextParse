namespace core.config
{
	public class IOriginRecallMainInfo : IConfigItem
	{
		public string contactid { get; set; }

		public string jump { get; set; }

		public string name { get; set; }

		public string petinfo { get; set; }

		public string reward { get; set; }

		public string showdescribe { get; set; }

		public string showtime { get; set; }

		public int beginning { get; set; }

		public int id { get; set; }

		public int jumptalkgroupId1 { get; set; }

		public int jumptalkgroupId2 { get; set; }

		public int level { get; set; }

		public int showtype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			beginning = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			contactid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			jumptalkgroupId1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumptalkgroupId2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
