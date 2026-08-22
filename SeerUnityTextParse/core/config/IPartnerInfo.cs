namespace core.config
{
	public class IPartnerInfo : IConfigItem
	{
		public string partnerName { get; set; }

		public string type { get; set; }

		public int[] partnerMonsterId { get; set; }

		public int bitbuf { get; set; }

		public int choice { get; set; }

		public int cost { get; set; }

		public int id { get; set; }

		public int partnerNumber { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bitbuf = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			choice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				partnerMonsterId = new int[num];
				for (int i = 0; i < num; i++)
				{
					partnerMonsterId[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			partnerName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			partnerNumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
