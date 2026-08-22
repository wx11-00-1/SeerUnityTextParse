namespace core.config.throw_item
{
	public class IItemItem : IConfigItem
	{
		public int hitEffect { get; set; }

		public int id { get; set; }

		public int playerJudge { get; set; }

		public int track { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			hitEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerJudge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			track = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
