namespace core.config
{
	public class IBagTowerStageInfo : IConfigItem
	{
		public string name { get; set; }

		public int bg { get; set; }

		public int id { get; set; }

		public int initialcoin { get; set; }

		public int lockequip { get; set; }

		public int stagetype { get; set; }

		public int time { get; set; }

		public int unlock { get; set; }

		public int wavenum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialcoin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lockequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wavenum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
