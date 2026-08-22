namespace core.config
{
	public class IYear2025QteButtonInfo : IConfigItem
	{
		public int delay { get; set; }

		public int duration { get; set; }

		public int id { get; set; }

		public int keycode { get; set; }

		public int posX { get; set; }

		public int posY { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			delay = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			duration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			keycode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			posX = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			posY = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
