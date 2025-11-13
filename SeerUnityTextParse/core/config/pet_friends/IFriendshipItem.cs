using System;

namespace core.config.pet_friends
{
	// Token: 0x02001F3E RID: 7998
	public class IFriendshipItem
	{
		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600EFE8 RID: 61416 RVA: 0x003F428E File Offset: 0x003F248E
		// (set) Token: 0x0600EFE9 RID: 61417 RVA: 0x003F4296 File Offset: 0x003F2496
		public int[] EffectArgs { get; set; }

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600EFEA RID: 61418 RVA: 0x003F429F File Offset: 0x003F249F
		// (set) Token: 0x0600EFEB RID: 61419 RVA: 0x003F42A7 File Offset: 0x003F24A7
		public int[] EffectID { get; set; }

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x003F42B0 File Offset: 0x003F24B0
		// (set) Token: 0x0600EFED RID: 61421 RVA: 0x003F42B8 File Offset: 0x003F24B8
		public int FriendID { get; set; }

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x0600EFEE RID: 61422 RVA: 0x003F42C1 File Offset: 0x003F24C1
		// (set) Token: 0x0600EFEF RID: 61423 RVA: 0x003F42C9 File Offset: 0x003F24C9
		public int PetID { get; set; }

		// Token: 0x0600EFF0 RID: 61424 RVA: 0x003F42D4 File Offset: 0x003F24D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.EffectArgs = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.EffectArgs[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.EffectID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.EffectID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.FriendID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
