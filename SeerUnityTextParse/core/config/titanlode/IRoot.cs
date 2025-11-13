using System;

namespace core.config.titanlode
{
	// Token: 0x02001F0B RID: 7947
	public class IRoot
	{
		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x003F1CD6 File Offset: 0x003EFED6
		// (set) Token: 0x0600EDEF RID: 60911 RVA: 0x003F1CDE File Offset: 0x003EFEDE
		public IMapItem[] map { get; set; }

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x0600EDF0 RID: 60912 RVA: 0x003F1CE7 File Offset: 0x003EFEE7
		// (set) Token: 0x0600EDF1 RID: 60913 RVA: 0x003F1CEF File Offset: 0x003EFEEF
		public IRewards rewards { get; set; }

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x003F1CF8 File Offset: 0x003EFEF8
		// (set) Token: 0x0600EDF3 RID: 60915 RVA: 0x003F1D00 File Offset: 0x003EFF00
		public ITitanlodeItem[] titanlode { get; set; }

		// Token: 0x0600EDF4 RID: 60916 RVA: 0x003F1D0C File Offset: 0x003EFF0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.map = new IMapItem[num];
				for (int i = 0; i < num; i++)
				{
					this.map[i] = new IMapItem();
					this.map[i].Parse(bytes, ref byteIndex);
				}
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.rewards = new IRewards();
				this.rewards.Parse(bytes, ref byteIndex);
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.titanlode = new ITitanlodeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.titanlode[j] = new ITitanlodeItem();
					this.titanlode[j].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F07A RID: 61562
		private bool b;
	}
}
