using System;

namespace core.config.petbook
{
	// Token: 0x02001F6D RID: 8045
	public class IPlaceItem
	{
		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x0600F16A RID: 61802 RVA: 0x003F60F8 File Offset: 0x003F42F8
		// (set) Token: 0x0600F16B RID: 61803 RVA: 0x003F6100 File Offset: 0x003F4300
		public string Desc { get; set; }

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600F16C RID: 61804 RVA: 0x003F6109 File Offset: 0x003F4309
		// (set) Token: 0x0600F16D RID: 61805 RVA: 0x003F6111 File Offset: 0x003F4311
		public string Go { get; set; }

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600F16E RID: 61806 RVA: 0x003F611A File Offset: 0x003F431A
		// (set) Token: 0x0600F16F RID: 61807 RVA: 0x003F6122 File Offset: 0x003F4322
		public string Redirect { get; set; }

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600F170 RID: 61808 RVA: 0x003F612B File Offset: 0x003F432B
		// (set) Token: 0x0600F171 RID: 61809 RVA: 0x003F6133 File Offset: 0x003F4333
		public int[] Mintmark { get; set; }

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x0600F172 RID: 61810 RVA: 0x003F613C File Offset: 0x003F433C
		// (set) Token: 0x0600F173 RID: 61811 RVA: 0x003F6144 File Offset: 0x003F4344
		public int ID { get; set; }

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x0600F174 RID: 61812 RVA: 0x003F614D File Offset: 0x003F434D
		// (set) Token: 0x0600F175 RID: 61813 RVA: 0x003F6155 File Offset: 0x003F4355
		public int ImageID { get; set; }

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600F176 RID: 61814 RVA: 0x003F615E File Offset: 0x003F435E
		// (set) Token: 0x0600F177 RID: 61815 RVA: 0x003F6166 File Offset: 0x003F4366
		public int Label { get; set; }

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x0600F178 RID: 61816 RVA: 0x003F616F File Offset: 0x003F436F
		// (set) Token: 0x0600F179 RID: 61817 RVA: 0x003F6177 File Offset: 0x003F4377
		public int monID { get; set; }

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x0600F17A RID: 61818 RVA: 0x003F6180 File Offset: 0x003F4380
		// (set) Token: 0x0600F17B RID: 61819 RVA: 0x003F6188 File Offset: 0x003F4388
		public int type { get; set; }

		// Token: 0x0600F17C RID: 61820 RVA: 0x003F6194 File Offset: 0x003F4394
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ImageID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Mintmark = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Mintmark[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Redirect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
