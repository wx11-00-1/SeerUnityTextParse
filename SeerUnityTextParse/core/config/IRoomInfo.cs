namespace core.config
{
	public class IRoomInfo : IConfigItem
	{
		public string name { get; set; }

		public int[] floorPutDefaultPos { get; set; }

		public int[] playerPos { get; set; }

		public int[] wallPutDefaultPos { get; set; }

		public int id { get; set; }

		public int vipOnly { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				floorPutDefaultPos = new int[num];
				for (int i = 0; i < num; i++)
				{
					floorPutDefaultPos[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				playerPos = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					playerPos[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				wallPutDefaultPos = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					wallPutDefaultPos[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
