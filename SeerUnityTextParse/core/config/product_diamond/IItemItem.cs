using System;

namespace core.config.product_diamond
{
	// Token: 0x02001F36 RID: 7990
	public class IItemItem
	{
		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x0600EFA8 RID: 61352 RVA: 0x003F3D98 File Offset: 0x003F1F98
		// (set) Token: 0x0600EFA9 RID: 61353 RVA: 0x003F3DA0 File Offset: 0x003F1FA0
		public string icon { get; set; }

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x0600EFAA RID: 61354 RVA: 0x003F3DA9 File Offset: 0x003F1FA9
		// (set) Token: 0x0600EFAB RID: 61355 RVA: 0x003F3DB1 File Offset: 0x003F1FB1
		public string name { get; set; }

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x0600EFAC RID: 61356 RVA: 0x003F3DBA File Offset: 0x003F1FBA
		// (set) Token: 0x0600EFAD RID: 61357 RVA: 0x003F3DC2 File Offset: 0x003F1FC2
		public int[] itemID { get; set; }

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x0600EFAE RID: 61358 RVA: 0x003F3DCB File Offset: 0x003F1FCB
		// (set) Token: 0x0600EFAF RID: 61359 RVA: 0x003F3DD3 File Offset: 0x003F1FD3
		public int price { get; set; }

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x0600EFB0 RID: 61360 RVA: 0x003F3DDC File Offset: 0x003F1FDC
		// (set) Token: 0x0600EFB1 RID: 61361 RVA: 0x003F3DE4 File Offset: 0x003F1FE4
		public int productID { get; set; }

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x0600EFB2 RID: 61362 RVA: 0x003F3DED File Offset: 0x003F1FED
		// (set) Token: 0x0600EFB3 RID: 61363 RVA: 0x003F3DF5 File Offset: 0x003F1FF5
		public float vip { get; set; }

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x003F3E00 File Offset: 0x003F2000
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.itemID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.itemID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vip = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
