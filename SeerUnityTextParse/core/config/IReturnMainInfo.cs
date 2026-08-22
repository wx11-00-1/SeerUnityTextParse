namespace core.config
{
	public class IReturnMainInfo : IConfigItem
	{
		public int[] onespet { get; set; }

		public int[] onesreward { get; set; }

		public int[] previewitem { get; set; }

		public int[] previewpet { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				onespet = new int[num];
				for (int i = 0; i < num; i++)
				{
					onespet[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				onesreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					onesreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				previewitem = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					previewitem[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				previewpet = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					previewpet[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
