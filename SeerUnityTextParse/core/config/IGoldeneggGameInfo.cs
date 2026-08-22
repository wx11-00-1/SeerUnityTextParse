namespace core.config
{
	public class IGoldeneggGameInfo : IConfigItem
	{
		public int id { get; set; }

		public int monsterhp { get; set; }

		public int position { get; set; }

		public int round { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			position = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			round = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
