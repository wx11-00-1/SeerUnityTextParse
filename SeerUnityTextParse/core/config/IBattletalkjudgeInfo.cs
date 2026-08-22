namespace core.config
{
	public class IBattletalkjudgeInfo : IConfigItem
	{
		public int battleid { get; set; }

		public int id { get; set; }

		public int judge { get; set; }

		public float param1 { get; set; }

		public int param2 { get; set; }

		public int rank { get; set; }

		public int repeat { get; set; }

		public int talkid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battleid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			judge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param1 = ByteUtil.ReadFloat(bytes, ref byteIndex);
			param2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			repeat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			talkid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
