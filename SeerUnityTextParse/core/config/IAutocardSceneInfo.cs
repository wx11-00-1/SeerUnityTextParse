using System;

namespace core.config
{
	// Token: 0x0200244F RID: 9295
	public class IAutocardSceneInfo : IConfigItem
	{
		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x0601199E RID: 72094 RVA: 0x00502208 File Offset: 0x00500408
		// (set) Token: 0x0601199F RID: 72095 RVA: 0x00502210 File Offset: 0x00500410
		public string bookresouce { get; set; }

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060119A0 RID: 72096 RVA: 0x00502219 File Offset: 0x00500419
		// (set) Token: 0x060119A1 RID: 72097 RVA: 0x00502221 File Offset: 0x00500421
		public string name { get; set; }

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060119A2 RID: 72098 RVA: 0x0050222A File Offset: 0x0050042A
		// (set) Token: 0x060119A3 RID: 72099 RVA: 0x00502232 File Offset: 0x00500432
		public string resource { get; set; }

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060119A4 RID: 72100 RVA: 0x0050223B File Offset: 0x0050043B
		// (set) Token: 0x060119A5 RID: 72101 RVA: 0x00502243 File Offset: 0x00500443
		public string tag { get; set; }

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x060119A6 RID: 72102 RVA: 0x0050224C File Offset: 0x0050044C
		// (set) Token: 0x060119A7 RID: 72103 RVA: 0x00502254 File Offset: 0x00500454
		public int id { get; set; }

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x060119A8 RID: 72104 RVA: 0x0050225D File Offset: 0x0050045D
		// (set) Token: 0x060119A9 RID: 72105 RVA: 0x00502265 File Offset: 0x00500465
		public int rarity { get; set; }

		// Token: 0x060119AA RID: 72106 RVA: 0x00502270 File Offset: 0x00500470
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bookresouce = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.resource = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
