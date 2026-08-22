namespace core.config
{
	public class ICrystalLegendMonsterActionInfo : IConfigItem
	{
		public int grow { get; set; }

		public int id { get; set; }

		public int multiAttack { get; set; }

		public int power { get; set; }

		public int shield { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			grow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			multiAttack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shield = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
