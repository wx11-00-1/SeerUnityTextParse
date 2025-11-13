using System;

namespace core.config
{
	// Token: 0x02001D90 RID: 7568
	public class IMallrefreshInfo : IConfigItem
	{
		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600DE0A RID: 56842 RVA: 0x003D63BC File Offset: 0x003D45BC
		// (set) Token: 0x0600DE0B RID: 56843 RVA: 0x003D63C4 File Offset: 0x003D45C4
		public int[] price { get; set; }

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600DE0C RID: 56844 RVA: 0x003D63CD File Offset: 0x003D45CD
		// (set) Token: 0x0600DE0D RID: 56845 RVA: 0x003D63D5 File Offset: 0x003D45D5
		public int[] rewardinfo { get; set; }

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600DE0E RID: 56846 RVA: 0x003D63DE File Offset: 0x003D45DE
		// (set) Token: 0x0600DE0F RID: 56847 RVA: 0x003D63E6 File Offset: 0x003D45E6
		public int id { get; set; }

		// Token: 0x0600DE10 RID: 56848 RVA: 0x003D63F0 File Offset: 0x003D45F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.price = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.price[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
