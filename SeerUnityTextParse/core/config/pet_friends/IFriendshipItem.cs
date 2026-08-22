namespace core.config.pet_friends
{
	public class IFriendshipItem
	{
		public int[] EffectArgs { get; set; }

		public int[] EffectID { get; set; }

		public int FriendID { get; set; }

		public int PetID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				EffectArgs = new int[num];
				for (int i = 0; i < num; i++)
				{
					EffectArgs[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				EffectID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					EffectID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			FriendID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
