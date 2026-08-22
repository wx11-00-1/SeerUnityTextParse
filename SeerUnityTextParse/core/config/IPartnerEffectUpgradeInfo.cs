namespace core.config
{
	public class IPartnerEffectUpgradeInfo : IConfigItem
	{
		public string descAfter { get; set; }

		public string descBefore { get; set; }

		public string[] skill { get; set; }

		public int id { get; set; }

		public int monID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			descAfter = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			descBefore = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				skill = new string[num];
				for (int i = 0; i < num; i++)
				{
					skill[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
