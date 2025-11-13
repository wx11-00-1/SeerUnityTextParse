using System;

namespace core.config
{
	// Token: 0x02001E82 RID: 7810
	public class ITreasureChestGiftInfo : IConfigItem
	{
		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x003E3650 File Offset: 0x003E1850
		// (set) Token: 0x0600E881 RID: 59521 RVA: 0x003E3658 File Offset: 0x003E1858
		public int[] rewardinfo { get; set; }

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x0600E882 RID: 59522 RVA: 0x003E3661 File Offset: 0x003E1861
		// (set) Token: 0x0600E883 RID: 59523 RVA: 0x003E3669 File Offset: 0x003E1869
		public int count { get; set; }

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600E884 RID: 59524 RVA: 0x003E3672 File Offset: 0x003E1872
		// (set) Token: 0x0600E885 RID: 59525 RVA: 0x003E367A File Offset: 0x003E187A
		public int id { get; set; }

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x0600E886 RID: 59526 RVA: 0x003E3683 File Offset: 0x003E1883
		// (set) Token: 0x0600E887 RID: 59527 RVA: 0x003E368B File Offset: 0x003E188B
		public int type { get; set; }

		// Token: 0x0600E888 RID: 59528 RVA: 0x003E3694 File Offset: 0x003E1894
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
