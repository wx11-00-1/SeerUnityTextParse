using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F61 RID: 8033
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x0600F100 RID: 61696 RVA: 0x003F587E File Offset: 0x003F3A7E
		// (set) Token: 0x0600F101 RID: 61697 RVA: 0x003F5886 File Offset: 0x003F3A86
		public int[] TagB { get; set; }

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x0600F102 RID: 61698 RVA: 0x003F588F File Offset: 0x003F3A8F
		// (set) Token: 0x0600F103 RID: 61699 RVA: 0x003F5897 File Offset: 0x003F3A97
		public int id { get; set; }

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x0600F104 RID: 61700 RVA: 0x003F58A0 File Offset: 0x003F3AA0
		// (set) Token: 0x0600F105 RID: 61701 RVA: 0x003F58A8 File Offset: 0x003F3AA8
		public int pid { get; set; }

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x0600F106 RID: 61702 RVA: 0x003F58B1 File Offset: 0x003F3AB1
		// (set) Token: 0x0600F107 RID: 61703 RVA: 0x003F58B9 File Offset: 0x003F3AB9
		public int TagA { get; set; }

		// Token: 0x0600F108 RID: 61704 RVA: 0x003F58C4 File Offset: 0x003F3AC4
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
