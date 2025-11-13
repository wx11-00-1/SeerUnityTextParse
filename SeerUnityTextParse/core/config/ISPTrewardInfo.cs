using System;

namespace core.config
{
	// Token: 0x02001E30 RID: 7728
	public class ISPTrewardInfo : IConfigItem
	{
		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x003DEEA8 File Offset: 0x003DD0A8
		// (set) Token: 0x0600E4E3 RID: 58595 RVA: 0x003DEEB0 File Offset: 0x003DD0B0
		public int[] rewardcnt { get; set; }

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x003DEEB9 File Offset: 0x003DD0B9
		// (set) Token: 0x0600E4E5 RID: 58597 RVA: 0x003DEEC1 File Offset: 0x003DD0C1
		public int[] rewardid { get; set; }

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x003DEECA File Offset: 0x003DD0CA
		// (set) Token: 0x0600E4E7 RID: 58599 RVA: 0x003DEED2 File Offset: 0x003DD0D2
		public int id { get; set; }

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x003DEEDC File Offset: 0x003DD0DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardcnt = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardcnt[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
