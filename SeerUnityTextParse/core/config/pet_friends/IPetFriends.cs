namespace core.config.pet_friends
{
	public class IPetFriends
	{
		public IFriendshipItem[] Friendship { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Friendship = new IFriendshipItem[num];
				for (int i = 0; i < num; i++)
				{
					Friendship[i] = new IFriendshipItem();
					Friendship[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
