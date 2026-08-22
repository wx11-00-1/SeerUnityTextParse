namespace core.config
{
	public class ISpiderSolitaireGameInfo : IConfigItem
	{
		public int id { get; set; }

		public int magicDef { get; set; }

		public int physicsDef { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			magicDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			physicsDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
