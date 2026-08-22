namespace core.config
{
	public class IArmorHeroNWMonsterInfo : IConfigItem
	{
		public string act { get; set; }

		public int gameid { get; set; }

		public int hp { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			act = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			gameid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
