namespace core.config
{
	public class IDungeonEnterInfo : IConfigItem
	{
		public string name { get; set; }

		public string openParam { get; set; }

		public string res { get; set; }

		public string timeLimit { get; set; }

		public int[] reward { get; set; }

		public int[] times { get; set; }

		public int id { get; set; }

		public int isOpen { get; set; }

		public int isShow { get; set; }

		public int moduleID { get; set; }

		public int order { get; set; }

		public int redbadge { get; set; }

		public int showType { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isOpen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moduleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			openParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			res = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			showType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			timeLimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				times = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					times[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
