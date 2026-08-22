namespace core.config.equip
{
	public class IRankItem
	{
		public string Desc { get; set; }

		public int Lv { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
