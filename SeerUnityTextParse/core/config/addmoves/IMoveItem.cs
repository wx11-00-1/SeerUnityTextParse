namespace core.config.addmoves
{
	public class IMoveItem
	{
		public string[] anm { get; set; }

		public string[] reportname { get; set; }

		public string[] reportskill { get; set; }

		public string[] reporttxt { get; set; }

		public int[] skin { get; set; }

		public int cover { get; set; }

		public int damage { get; set; }

		public int ID { get; set; }

		public int monster { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				anm = new string[num];
				for (int i = 0; i < num; i++)
				{
					anm[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			cover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			damage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reportname = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					reportname[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reportskill = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					reportskill[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reporttxt = new string[num4];
				for (int l = 0; l < num4; l++)
				{
					reporttxt[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				skin = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					skin[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
