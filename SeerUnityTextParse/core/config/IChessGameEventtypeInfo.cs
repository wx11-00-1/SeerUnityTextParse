namespace core.config
{
	public class IChessGameEventtypeInfo : IConfigItem
	{
		public string eventicon { get; set; }

		public string eventname { get; set; }

		public string eventposition { get; set; }

		public int eventtype { get; set; }

		public int id { get; set; }

		public int towerid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			eventicon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			towerid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
