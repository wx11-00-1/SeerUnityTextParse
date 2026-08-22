namespace core.config
{
	public class IActivityDuelInfo : IConfigItem
	{
		public string chart { get; set; }

		public string describe { get; set; }

		public string name { get; set; }

		public string rewardinfo { get; set; }

		public string song { get; set; }

		public string songRes { get; set; }

		public int blood { get; set; }

		public int difficulty { get; set; }

		public int gametime { get; set; }

		public int id { get; set; }

		public int timeend { get; set; }

		public int timestart { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			blood = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			gametime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			song = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			songRes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			timeend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			timestart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
