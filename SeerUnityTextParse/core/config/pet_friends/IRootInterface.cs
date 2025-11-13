using System;

namespace core.config.pet_friends
{
	// Token: 0x02001F40 RID: 8000
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x0600EFF6 RID: 61430 RVA: 0x003F43DE File Offset: 0x003F25DE
		public override string fileName
		{
			get
			{
				return "pet_friends";
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x0600EFF7 RID: 61431 RVA: 0x003F43E5 File Offset: 0x003F25E5
		// (set) Token: 0x0600EFF8 RID: 61432 RVA: 0x003F43ED File Offset: 0x003F25ED
		public IPetFriends PetFriends { get; set; }

		// Token: 0x0600EFF9 RID: 61433 RVA: 0x003F43F6 File Offset: 0x003F25F6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PetFriends = new IPetFriends();
				this.PetFriends.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EFFA RID: 61434 RVA: 0x003F441C File Offset: 0x003F261C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
