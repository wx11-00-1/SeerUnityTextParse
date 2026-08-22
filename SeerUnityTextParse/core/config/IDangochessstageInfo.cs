namespace core.config
{
	public class IDangochessstageInfo : IConfigItem
	{
		public int chapterid { get; set; }

		public int hangid { get; set; }

		public int id { get; set; }

		public int lieid1 { get; set; }

		public int lieid2 { get; set; }

		public int lieid3 { get; set; }

		public int lieid4 { get; set; }

		public int lieid5 { get; set; }

		public int lieid6 { get; set; }

		public int lieid7 { get; set; }

		public int lieid8 { get; set; }

		public int lieid9 { get; set; }

		public int stageid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hangid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid7 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid8 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lieid9 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
