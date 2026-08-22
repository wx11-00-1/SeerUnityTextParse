namespace core.config.pet_advance
{
	public class IRace
	{
		public int[] NewRace { get; set; }

		public int[] OldRace { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				NewRace = new int[num];
				for (int i = 0; i < num; i++)
				{
					NewRace[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				OldRace = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					OldRace[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
