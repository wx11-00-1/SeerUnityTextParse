using System;

namespace core.config
{
	// Token: 0x02001E18 RID: 7704
	public class IShopCultivateInfo : IConfigItem
	{
		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x003DD7C0 File Offset: 0x003DB9C0
		// (set) Token: 0x0600E3BD RID: 58301 RVA: 0x003DD7C8 File Offset: 0x003DB9C8
		public string name { get; set; }

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x003DD7D1 File Offset: 0x003DB9D1
		// (set) Token: 0x0600E3BF RID: 58303 RVA: 0x003DD7D9 File Offset: 0x003DB9D9
		public int[] price { get; set; }

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x003DD7E2 File Offset: 0x003DB9E2
		// (set) Token: 0x0600E3C1 RID: 58305 RVA: 0x003DD7EA File Offset: 0x003DB9EA
		public int[] reward { get; set; }

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x003DD7F3 File Offset: 0x003DB9F3
		// (set) Token: 0x0600E3C3 RID: 58307 RVA: 0x003DD7FB File Offset: 0x003DB9FB
		public int id { get; set; }

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x003DD804 File Offset: 0x003DBA04
		// (set) Token: 0x0600E3C5 RID: 58309 RVA: 0x003DD80C File Offset: 0x003DBA0C
		public int miditem { get; set; }

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x003DD815 File Offset: 0x003DBA15
		// (set) Token: 0x0600E3C7 RID: 58311 RVA: 0x003DD81D File Offset: 0x003DBA1D
		public int number { get; set; }

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x003DD826 File Offset: 0x003DBA26
		// (set) Token: 0x0600E3C9 RID: 58313 RVA: 0x003DD82E File Offset: 0x003DBA2E
		public int prop { get; set; }

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x003DD837 File Offset: 0x003DBA37
		// (set) Token: 0x0600E3CB RID: 58315 RVA: 0x003DD83F File Offset: 0x003DBA3F
		public int quota { get; set; }

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x003DD848 File Offset: 0x003DBA48
		// (set) Token: 0x0600E3CD RID: 58317 RVA: 0x003DD850 File Offset: 0x003DBA50
		public int show { get; set; }

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x003DD859 File Offset: 0x003DBA59
		// (set) Token: 0x0600E3CF RID: 58319 RVA: 0x003DD861 File Offset: 0x003DBA61
		public int sort { get; set; }

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x003DD86A File Offset: 0x003DBA6A
		// (set) Token: 0x0600E3D1 RID: 58321 RVA: 0x003DD872 File Offset: 0x003DBA72
		public int type { get; set; }

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x003DD87C File Offset: 0x003DBA7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.miditem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.price = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.price[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.prop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.reward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
