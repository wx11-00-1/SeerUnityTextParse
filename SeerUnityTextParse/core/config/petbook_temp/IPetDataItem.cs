using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F56 RID: 8022
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x0600F0A4 RID: 61604 RVA: 0x003F50FE File Offset: 0x003F32FE
		// (set) Token: 0x0600F0A5 RID: 61605 RVA: 0x003F5106 File Offset: 0x003F3306
		public int[] TagB { get; set; }

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x0600F0A6 RID: 61606 RVA: 0x003F510F File Offset: 0x003F330F
		// (set) Token: 0x0600F0A7 RID: 61607 RVA: 0x003F5117 File Offset: 0x003F3317
		public int id { get; set; }

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x003F5120 File Offset: 0x003F3320
		// (set) Token: 0x0600F0A9 RID: 61609 RVA: 0x003F5128 File Offset: 0x003F3328
		public int pid { get; set; }

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x0600F0AA RID: 61610 RVA: 0x003F5131 File Offset: 0x003F3331
		// (set) Token: 0x0600F0AB RID: 61611 RVA: 0x003F5139 File Offset: 0x003F3339
		public int TagA { get; set; }

		// Token: 0x0600F0AC RID: 61612 RVA: 0x003F5144 File Offset: 0x003F3344
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.TagA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TagB = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.TagB[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
