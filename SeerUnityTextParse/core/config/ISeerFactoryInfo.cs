using System;

namespace core.config
{
	// Token: 0x02001E12 RID: 7698
	public class ISeerFactoryInfo : IConfigItem
	{
		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600E376 RID: 58230 RVA: 0x003DD1DC File Offset: 0x003DB3DC
		// (set) Token: 0x0600E377 RID: 58231 RVA: 0x003DD1E4 File Offset: 0x003DB3E4
		public int[] suitPartID { get; set; }

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x0600E378 RID: 58232 RVA: 0x003DD1ED File Offset: 0x003DB3ED
		// (set) Token: 0x0600E379 RID: 58233 RVA: 0x003DD1F5 File Offset: 0x003DB3F5
		public int id { get; set; }

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x0600E37A RID: 58234 RVA: 0x003DD1FE File Offset: 0x003DB3FE
		// (set) Token: 0x0600E37B RID: 58235 RVA: 0x003DD206 File Offset: 0x003DB406
		public int suitID { get; set; }

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x0600E37C RID: 58236 RVA: 0x003DD20F File Offset: 0x003DB40F
		// (set) Token: 0x0600E37D RID: 58237 RVA: 0x003DD217 File Offset: 0x003DB417
		public int suitPrice { get; set; }

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600E37E RID: 58238 RVA: 0x003DD220 File Offset: 0x003DB420
		// (set) Token: 0x0600E37F RID: 58239 RVA: 0x003DD228 File Offset: 0x003DB428
		public int vipOnly { get; set; }

		// Token: 0x0600E380 RID: 58240 RVA: 0x003DD234 File Offset: 0x003DB434
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.suitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.suitPartID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.suitPartID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.suitPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
