using System;

namespace core.config.shop_config
{
	// Token: 0x02001F27 RID: 7975
	public class IMenuItem : IConfigItem
	{
		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x0600EF30 RID: 61232 RVA: 0x003F34A4 File Offset: 0x003F16A4
		// (set) Token: 0x0600EF31 RID: 61233 RVA: 0x003F34AC File Offset: 0x003F16AC
		public string ad { get; set; }

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x0600EF32 RID: 61234 RVA: 0x003F34B5 File Offset: 0x003F16B5
		// (set) Token: 0x0600EF33 RID: 61235 RVA: 0x003F34BD File Offset: 0x003F16BD
		public string cls { get; set; }

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x0600EF34 RID: 61236 RVA: 0x003F34C6 File Offset: 0x003F16C6
		// (set) Token: 0x0600EF35 RID: 61237 RVA: 0x003F34CE File Offset: 0x003F16CE
		public string countID { get; set; }

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x003F34D7 File Offset: 0x003F16D7
		// (set) Token: 0x0600EF37 RID: 61239 RVA: 0x003F34DF File Offset: 0x003F16DF
		public IItemItem[] item { get; set; }

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x0600EF38 RID: 61240 RVA: 0x003F34E8 File Offset: 0x003F16E8
		// (set) Token: 0x0600EF39 RID: 61241 RVA: 0x003F34F0 File Offset: 0x003F16F0
		public IMenuItem[] menu { get; set; }

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x0600EF3A RID: 61242 RVA: 0x003F34F9 File Offset: 0x003F16F9
		// (set) Token: 0x0600EF3B RID: 61243 RVA: 0x003F3501 File Offset: 0x003F1701
		public string name { get; set; }

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x003F350A File Offset: 0x003F170A
		// (set) Token: 0x0600EF3D RID: 61245 RVA: 0x003F3512 File Offset: 0x003F1712
		public string viewClass { get; set; }

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x0600EF3E RID: 61246 RVA: 0x003F351B File Offset: 0x003F171B
		// (set) Token: 0x0600EF3F RID: 61247 RVA: 0x003F3523 File Offset: 0x003F1723
		public int id { get; set; }

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600EF40 RID: 61248 RVA: 0x003F352C File Offset: 0x003F172C
		// (set) Token: 0x0600EF41 RID: 61249 RVA: 0x003F3534 File Offset: 0x003F1734
		public int pageSize { get; set; }

		// Token: 0x0600EF42 RID: 61250 RVA: 0x003F3540 File Offset: 0x003F1740
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ad = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.cls = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.countID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.menu = new IMenuItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.menu[j] = new IMenuItem();
					this.menu[j].Parse(bytes, ref byteIndex);
				}
			}
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pageSize = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.viewClass = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
