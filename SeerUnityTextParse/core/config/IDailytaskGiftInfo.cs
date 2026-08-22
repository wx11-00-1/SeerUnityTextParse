namespace core.config
{
	public class IDailytaskGiftInfo : IConfigItem
	{
		public string name { get; set; }

		public string rewardinfo { get; set; }

		public int activity { get; set; }

		public int diamond { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int NewStatLog { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NewStatLog = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			activity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			diamond = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
