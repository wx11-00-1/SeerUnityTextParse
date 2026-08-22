namespace core.config
{
	public class IChessGameMonsterInfo : IConfigItem
	{
		public string acknum { get; set; }

		public string acktime { get; set; }

		public string bpoint { get; set; }

		public string buff { get; set; }

		public string def { get; set; }

		public string hp { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public string skill { get; set; }

		public int ackrange { get; set; }

		public int id { get; set; }

		public int move { get; set; }

		public int previewarea { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			acknum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ackrange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			acktime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bpoint = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			def = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			move = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			previewarea = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skill = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
