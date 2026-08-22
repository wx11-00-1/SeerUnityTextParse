namespace core.config
{
	public class IReturnSigninInfo : IConfigItem
	{
		public int[] changereward { get; set; }

		public int[] judgepet { get; set; }

		public int[] previewreward1 { get; set; }

		public int[] previewreward2 { get; set; }

		public int[] reward { get; set; }

		public int days { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				changereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					changereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			days = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judgepet = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					judgepet[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				previewreward1 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					previewreward1[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				previewreward2 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					previewreward2[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					reward[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
