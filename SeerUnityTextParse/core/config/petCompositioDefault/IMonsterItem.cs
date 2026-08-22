namespace core.config.petCompositioDefault
{
	public class IMonsterItem
	{
		public string Name { get; set; }

		public int ExtraMove { get; set; }

		public int ID { get; set; }

		public int Lv { get; set; }

		public int NewSeID { get; set; }

		public int Resist { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExtraMove = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Resist = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
