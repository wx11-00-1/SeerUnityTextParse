using System;

namespace core.config
{
	// Token: 0x02001E3E RID: 7742
	public class IStartrekbuffinfoInfo : IConfigItem
	{
		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x003DFAE4 File Offset: 0x003DDCE4
		// (set) Token: 0x0600E575 RID: 58741 RVA: 0x003DFAEC File Offset: 0x003DDCEC
		public string BuffDesc { get; set; }

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x003DFAF5 File Offset: 0x003DDCF5
		// (set) Token: 0x0600E577 RID: 58743 RVA: 0x003DFAFD File Offset: 0x003DDCFD
		public string BuffName { get; set; }

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x0600E578 RID: 58744 RVA: 0x003DFB06 File Offset: 0x003DDD06
		// (set) Token: 0x0600E579 RID: 58745 RVA: 0x003DFB0E File Offset: 0x003DDD0E
		public int[] BasicValue { get; set; }

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600E57A RID: 58746 RVA: 0x003DFB17 File Offset: 0x003DDD17
		// (set) Token: 0x0600E57B RID: 58747 RVA: 0x003DFB1F File Offset: 0x003DDD1F
		public int BuffId { get; set; }

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x0600E57C RID: 58748 RVA: 0x003DFB28 File Offset: 0x003DDD28
		// (set) Token: 0x0600E57D RID: 58749 RVA: 0x003DFB30 File Offset: 0x003DDD30
		public int BuffPondID { get; set; }

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x0600E57E RID: 58750 RVA: 0x003DFB39 File Offset: 0x003DDD39
		// (set) Token: 0x0600E57F RID: 58751 RVA: 0x003DFB41 File Offset: 0x003DDD41
		public int id { get; set; }

		// Token: 0x0600E580 RID: 58752 RVA: 0x003DFB4C File Offset: 0x003DDD4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.BasicValue = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.BasicValue[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.BuffDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BuffId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.BuffName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BuffPondID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
