using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F88 RID: 8072
	public class IReward
	{
		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x0600F23E RID: 62014 RVA: 0x003F7105 File Offset: 0x003F5305
		// (set) Token: 0x0600F23F RID: 62015 RVA: 0x003F710D File Offset: 0x003F530D
		public int GainValue { get; set; }

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x0600F240 RID: 62016 RVA: 0x003F7116 File Offset: 0x003F5316
		// (set) Token: 0x0600F241 RID: 62017 RVA: 0x003F711E File Offset: 0x003F531E
		public int ItemID { get; set; }

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x0600F242 RID: 62018 RVA: 0x003F7127 File Offset: 0x003F5327
		// (set) Token: 0x0600F243 RID: 62019 RVA: 0x003F712F File Offset: 0x003F532F
		public int MintMarkID { get; set; }

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x0600F244 RID: 62020 RVA: 0x003F7138 File Offset: 0x003F5338
		// (set) Token: 0x0600F245 RID: 62021 RVA: 0x003F7140 File Offset: 0x003F5340
		public int MonsterID { get; set; }

		// Token: 0x0600F246 RID: 62022 RVA: 0x003F7149 File Offset: 0x003F5349
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.GainValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MintMarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
