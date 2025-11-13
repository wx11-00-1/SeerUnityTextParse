using System;
using System.Collections.Generic;
using common;
using core.config.pet_friends;


namespace core.config
{
	// Token: 0x02001EB6 RID: 7862
	public class PetFriendsXMLInfo : ConfigManagerSingleton<PetFriendsXMLInfo>
	{
		// Token: 0x0600EB07 RID: 60167 RVA: 0x003EBBBA File Offset: 0x003E9DBA
		

		// Token: 0x0600EB08 RID: 60168 RVA: 0x003EBBCC File Offset: 0x003E9DCC
		

		// Token: 0x0600EB09 RID: 60169 RVA: 0x003EBBDC File Offset: 0x003E9DDC
		

		// Token: 0x0600EB0A RID: 60170 RVA: 0x003EBC20 File Offset: 0x003E9E20
		public List<int> getAffectedEffects(int petID, int friendPet)
		{
			List<int> list = new List<int>();
			IFriendshipItem friendshipItem;
			if (this.s_DataMap.TryGetValue(petID + 100000 * friendPet, out friendshipItem))
			{
				int[] effectArgs = friendshipItem.EffectArgs;
				int[] effectID = friendshipItem.EffectID;
				for (int i = 0; i < effectID.Length; i++)
				{
					int num = effectID[i];
					if (num == 2)
					{
						int item = effectArgs[i * 2 + 1];
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
					else if (num == 3)
					{
						int item = effectArgs[i * 2];
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x003EBCB4 File Offset: 0x003E9EB4
		public List<int> getAffectedSkills(int petID, int friendPet)
		{
			List<int> list = new List<int>();
			IFriendshipItem friendshipItem;
			if (this.s_DataMap.TryGetValue(petID + 100000 * friendPet, out friendshipItem))
			{
				int[] effectArgs = friendshipItem.EffectArgs;
				int[] effectID = friendshipItem.EffectID;
				for (int i = 0; i < effectID.Length; i++)
				{
					if (effectID[i] == 1)
					{
						int item;
						if (effectArgs.Length / 2 > 0)
						{
							item = effectArgs[i * 2 + 1];
						}
						else
						{
							item = effectArgs[i * 2];
						}
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x003EBD35 File Offset: 0x003E9F35
		public bool isFriendPet(int petID, int friendPet)
		{
			return this.s_DataMap.ContainsKey(petID + 100000 * friendPet);
		}

		// Token: 0x0400EEC7 RID: 61127
		private Dictionary<int, IFriendshipItem> s_DataMap;

		// Token: 0x0400EEC8 RID: 61128
		private byte[] s_ConfigBytes;
	}
}
