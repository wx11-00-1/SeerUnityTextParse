namespace core.config
{
	public class ICrystalLegendMonsterInfo : IConfigItem
	{
		public string name { get; set; }

		public int artID { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			artID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
