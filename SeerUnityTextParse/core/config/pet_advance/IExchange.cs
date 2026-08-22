namespace core.config.pet_advance
{
	public class IExchange
	{
		public int[] ItemID { get; set; }

		public int[] ProductID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				ItemID = new int[num];
				for (int i = 0; i < num; i++)
				{
					ItemID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				ProductID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					ProductID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
