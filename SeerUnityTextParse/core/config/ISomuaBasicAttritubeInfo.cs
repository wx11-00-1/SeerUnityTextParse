namespace core.config
{
	public class ISomuaBasicAttritubeInfo : IConfigItem
	{
		public int attackRatio { get; set; }

		public int attackValue { get; set; }

		public int criticalChance { get; set; }

		public int criticalDamageRatio { get; set; }

		public int defenseRatio { get; set; }

		public int healthValue { get; set; }

		public int id { get; set; }

		public int knockRatio { get; set; }

		public int speedValue { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attackRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			attackValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			criticalChance = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			criticalDamageRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			defenseRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			healthValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			knockRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			speedValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
