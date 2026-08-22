namespace core.config
{
	public class IEventScheduleInfo : IConfigItem
	{
		public int eventTime { get; set; }

		public int eventVenue { get; set; }

		public int id { get; set; }

		public int oddsLeft { get; set; }

		public int oddsRight { get; set; }

		public int playerLeft { get; set; }

		public int playerRight { get; set; }

		public int userinfo1 { get; set; }

		public int userinfo2 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			eventTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			eventVenue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			oddsLeft = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			oddsRight = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerLeft = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerRight = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
