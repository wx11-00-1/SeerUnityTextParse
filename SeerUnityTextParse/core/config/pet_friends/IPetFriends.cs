using System;

namespace core.config.pet_friends
{
	// Token: 0x02001F3F RID: 7999
	public class IPetFriends
	{
		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x0600EFF2 RID: 61426 RVA: 0x003F4373 File Offset: 0x003F2573
		// (set) Token: 0x0600EFF3 RID: 61427 RVA: 0x003F437B File Offset: 0x003F257B
		public IFriendshipItem[] Friendship { get; set; }

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x003F4384 File Offset: 0x003F2584
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Friendship = new IFriendshipItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Friendship[i] = new IFriendshipItem();
					this.Friendship[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
