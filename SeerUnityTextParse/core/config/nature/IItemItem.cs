namespace core.config.nature
{
	public class IItemItem : IConfigItem
	{
		public string des { get; set; }

		public string des2 { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public float m_attack { get; set; }

		public float m_defence { get; set; }

		public float m_SA { get; set; }

		public float m_SD { get; set; }

		public float m_speed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			des2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			m_SA = ByteUtil.ReadFloat(bytes, ref byteIndex);
			m_SD = ByteUtil.ReadFloat(bytes, ref byteIndex);
			m_attack = ByteUtil.ReadFloat(bytes, ref byteIndex);
			m_defence = ByteUtil.ReadFloat(bytes, ref byteIndex);
			m_speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
