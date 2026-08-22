namespace core.config
{
	public class IBagTowerPlaerExpInfo : IConfigItem
	{
		public int exp { get; set; }

		public int id { get; set; }

		public int lv { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
