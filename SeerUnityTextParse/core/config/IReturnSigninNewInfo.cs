namespace core.config
{
	public class IReturnSigninNewInfo : IConfigItem
	{
		public string intro1 { get; set; }

		public string intro2 { get; set; }

		public string name1 { get; set; }

		public string name2 { get; set; }

		public int[] fiexdreward1 { get; set; }

		public int[] fiexdreward2 { get; set; }

		public int[] judgepet { get; set; }

		public int[] optreward1 { get; set; }

		public int[] optreward2 { get; set; }

		public int days { get; set; }

		public int id { get; set; }

		public int jump1 { get; set; }

		public int jump2 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			days = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fiexdreward1 = new int[num];
				for (int i = 0; i < num; i++)
				{
					fiexdreward1[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fiexdreward2 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					fiexdreward2[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			intro1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			intro2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judgepet = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					judgepet[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			jump1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jump2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				optreward1 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					optreward1[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				optreward2 = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					optreward2[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
