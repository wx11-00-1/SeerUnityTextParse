using System;

namespace core.config.figure_reward
{
	// Token: 0x0200203A RID: 8250
	public class IRewardItem
	{
		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600FBED RID: 64493 RVA: 0x0040143A File Offset: 0x003FF63A
		// (set) Token: 0x0600FBEE RID: 64494 RVA: 0x00401442 File Offset: 0x003FF642
		public IAch ach { get; set; }

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600FBEF RID: 64495 RVA: 0x0040144B File Offset: 0x003FF64B
		// (set) Token: 0x0600FBF0 RID: 64496 RVA: 0x00401453 File Offset: 0x003FF653
		public IMonsterItem Head { get; set; }

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600FBF1 RID: 64497 RVA: 0x0040145C File Offset: 0x003FF65C
		// (set) Token: 0x0600FBF2 RID: 64498 RVA: 0x00401464 File Offset: 0x003FF664
		public IMonsterItem HeadFrame { get; set; }

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600FBF3 RID: 64499 RVA: 0x0040146D File Offset: 0x003FF66D
		// (set) Token: 0x0600FBF4 RID: 64500 RVA: 0x00401475 File Offset: 0x003FF675
		public IItemItem[] Item { get; set; }

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600FBF5 RID: 64501 RVA: 0x0040147E File Offset: 0x003FF67E
		// (set) Token: 0x0600FBF6 RID: 64502 RVA: 0x00401486 File Offset: 0x003FF686
		public IItemItem[] Mintmark { get; set; }

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600FBF7 RID: 64503 RVA: 0x0040148F File Offset: 0x003FF68F
		// (set) Token: 0x0600FBF8 RID: 64504 RVA: 0x00401497 File Offset: 0x003FF697
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600FBF9 RID: 64505 RVA: 0x004014A0 File Offset: 0x003FF6A0
		// (set) Token: 0x0600FBFA RID: 64506 RVA: 0x004014A8 File Offset: 0x003FF6A8
		public IMonsterItem Skin { get; set; }

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600FBFB RID: 64507 RVA: 0x004014B1 File Offset: 0x003FF6B1
		// (set) Token: 0x0600FBFC RID: 64508 RVA: 0x004014B9 File Offset: 0x003FF6B9
		public int ID { get; set; }

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600FBFD RID: 64509 RVA: 0x004014C2 File Offset: 0x003FF6C2
		// (set) Token: 0x0600FBFE RID: 64510 RVA: 0x004014CA File Offset: 0x003FF6CA
		public int Type { get; set; }

		// Token: 0x0600FBFF RID: 64511 RVA: 0x004014D4 File Offset: 0x003FF6D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Head = new IMonsterItem();
				this.Head.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.HeadFrame = new IMonsterItem();
				this.HeadFrame.Parse(bytes, ref byteIndex);
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Mintmark = new IItemItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.Mintmark[j] = new IItemItem();
					this.Mintmark[j].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Monster = new IMonsterItem[num3];
				for (int k = 0; k < num3; k++)
				{
					this.Monster[k] = new IMonsterItem();
					this.Monster[k].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Skin = new IMonsterItem();
				this.Skin.Parse(bytes, ref byteIndex);
			}
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ach = new IAch();
				this.ach.Parse(bytes, ref byteIndex);
			}
		}
	}
}
