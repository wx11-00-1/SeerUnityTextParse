namespace core.config
{
	public class ISnackgameInfo : IConfigItem
	{
		public string foodNum { get; set; }

		public string maptype { get; set; }

		public string name { get; set; }

		public string npctype { get; set; }

		public string rewardinfo { get; set; }

		public int endtime { get; set; }

		public int id { get; set; }

		public int starttime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			foodNum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maptype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npctype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
