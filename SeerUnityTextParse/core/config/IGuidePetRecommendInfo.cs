namespace core.config
{
	public class IGuidePetRecommendInfo : IConfigItem
	{
		public string[] fifthProgress { get; set; }

		public string gainday { get; set; }

		public string[] judge5thmoveByvalue { get; set; }

		public string[] judgeNewseByvalue { get; set; }

		public string judgeOnekeyget { get; set; }

		public string[] judgePetByvalue { get; set; }

		public string[] petProgress { get; set; }

		public string[] seProgress { get; set; }

		public int[] strategy { get; set; }

		public int id { get; set; }

		public int petID { get; set; }

		public int recommend { get; set; }

		public int stage { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fifthProgress = new string[num];
				for (int i = 0; i < num; i++)
				{
					fifthProgress[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			gainday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judge5thmoveByvalue = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					judge5thmoveByvalue[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judgeNewseByvalue = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					judgeNewseByvalue[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			judgeOnekeyget = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judgePetByvalue = new string[num4];
				for (int l = 0; l < num4; l++)
				{
					judgePetByvalue[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				petProgress = new string[num5];
				for (int m = 0; m < num5; m++)
				{
					petProgress[m] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				seProgress = new string[num6];
				for (int n = 0; n < num6; n++)
				{
					seProgress[n] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num7 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				strategy = new int[num7];
				for (int num8 = 0; num8 < num7; num8++)
				{
					strategy[num8] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
