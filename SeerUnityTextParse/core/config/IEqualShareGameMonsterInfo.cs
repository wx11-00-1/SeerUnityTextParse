namespace core.config
{
	public class IEqualShareGameMonsterInfo : IConfigItem
	{
		public int attack { get; set; }

		public int exp { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int recover { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			recover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
