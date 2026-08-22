namespace core.config
{
	public class IPrivateSignInfo : IConfigItem
	{
		public string intro { get; set; }

		public string name { get; set; }

		public int[] reward { get; set; }

		public int[] rewardPet { get; set; }

		public int day { get; set; }

		public int id { get; set; }

		public int petId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			day = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardPet = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardPet[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
