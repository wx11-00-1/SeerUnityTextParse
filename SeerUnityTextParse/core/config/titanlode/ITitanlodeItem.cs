namespace core.config.titanlode
{
	public class ITitanlodeItem
	{
		public int[] cltboss { get; set; }

		public int[] passarg { get; set; }

		public int mode { get; set; }

		public int step { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				cltboss = new int[num];
				for (int i = 0; i < num; i++)
				{
					cltboss[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			mode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				passarg = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					passarg[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
