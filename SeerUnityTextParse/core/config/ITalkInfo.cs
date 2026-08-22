namespace core.config
{
	public class ITalkInfo : IConfigItem
	{
		public string[] answer { get; set; }

		public string[] deal { get; set; }

		public string msg { get; set; }

		public int dir { get; set; }

		public int groupId { get; set; }

		public int id { get; set; }

		public int npcId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				answer = new string[num];
				for (int i = 0; i < num; i++)
				{
					answer[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				deal = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					deal[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npcId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
