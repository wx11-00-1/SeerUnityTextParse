using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F85 RID: 8069
	public class IDesignItem
	{
		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x0600F210 RID: 61968 RVA: 0x003F6D47 File Offset: 0x003F4F47
		// (set) Token: 0x0600F211 RID: 61969 RVA: 0x003F6D4F File Offset: 0x003F4F4F
		public IAchievement Achievement { get; set; }

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x0600F212 RID: 61970 RVA: 0x003F6D58 File Offset: 0x003F4F58
		// (set) Token: 0x0600F213 RID: 61971 RVA: 0x003F6D60 File Offset: 0x003F4F60
		public IConfigure Configure { get; set; }

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x0600F214 RID: 61972 RVA: 0x003F6D69 File Offset: 0x003F4F69
		// (set) Token: 0x0600F215 RID: 61973 RVA: 0x003F6D71 File Offset: 0x003F4F71
		public IEasyBattle EasyBattle { get; set; }

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x0600F216 RID: 61974 RVA: 0x003F6D7A File Offset: 0x003F4F7A
		// (set) Token: 0x0600F217 RID: 61975 RVA: 0x003F6D82 File Offset: 0x003F4F82
		public INormalBattle HardBattle { get; set; }

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x0600F218 RID: 61976 RVA: 0x003F6D8B File Offset: 0x003F4F8B
		// (set) Token: 0x0600F219 RID: 61977 RVA: 0x003F6D93 File Offset: 0x003F4F93
		public INormalBattle NormalBattle { get; set; }

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x0600F21A RID: 61978 RVA: 0x003F6D9C File Offset: 0x003F4F9C
		// (set) Token: 0x0600F21B RID: 61979 RVA: 0x003F6DA4 File Offset: 0x003F4FA4
		public IReward Reward { get; set; }

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600F21C RID: 61980 RVA: 0x003F6DAD File Offset: 0x003F4FAD
		// (set) Token: 0x0600F21D RID: 61981 RVA: 0x003F6DB5 File Offset: 0x003F4FB5
		public IRules Rules { get; set; }

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600F21E RID: 61982 RVA: 0x003F6DBE File Offset: 0x003F4FBE
		// (set) Token: 0x0600F21F RID: 61983 RVA: 0x003F6DC6 File Offset: 0x003F4FC6
		public ISweep Sweep { get; set; }

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x0600F220 RID: 61984 RVA: 0x003F6DCF File Offset: 0x003F4FCF
		// (set) Token: 0x0600F221 RID: 61985 RVA: 0x003F6DD7 File Offset: 0x003F4FD7
		public int ID { get; set; }

		// Token: 0x0600F222 RID: 61986 RVA: 0x003F6DE0 File Offset: 0x003F4FE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Achievement = new IAchievement();
				this.Achievement.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Configure = new IConfigure();
				this.Configure.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.EasyBattle = new IEasyBattle();
				this.EasyBattle.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.HardBattle = new INormalBattle();
				this.HardBattle.Parse(bytes, ref byteIndex);
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.NormalBattle = new INormalBattle();
				this.NormalBattle.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Reward = new IReward();
				this.Reward.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Rules = new IRules();
				this.Rules.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Sweep = new ISweep();
				this.Sweep.Parse(bytes, ref byteIndex);
			}
		}
	}
}
