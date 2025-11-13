using System;

namespace core.config
{
	// Token: 0x02001D28 RID: 7464
	public class IDeepSeaCollectBookInfo : IConfigItem
	{
		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x0600DA00 RID: 55808 RVA: 0x003D1334 File Offset: 0x003CF534
		// (set) Token: 0x0600DA01 RID: 55809 RVA: 0x003D133C File Offset: 0x003CF53C
		public string fileContent { get; set; }

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x0600DA02 RID: 55810 RVA: 0x003D1345 File Offset: 0x003CF545
		// (set) Token: 0x0600DA03 RID: 55811 RVA: 0x003D134D File Offset: 0x003CF54D
		public string name { get; set; }

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x0600DA04 RID: 55812 RVA: 0x003D1356 File Offset: 0x003CF556
		// (set) Token: 0x0600DA05 RID: 55813 RVA: 0x003D135E File Offset: 0x003CF55E
		public string picName { get; set; }

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x003D1367 File Offset: 0x003CF567
		// (set) Token: 0x0600DA07 RID: 55815 RVA: 0x003D136F File Offset: 0x003CF56F
		public string unlockValue { get; set; }

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600DA08 RID: 55816 RVA: 0x003D1378 File Offset: 0x003CF578
		// (set) Token: 0x0600DA09 RID: 55817 RVA: 0x003D1380 File Offset: 0x003CF580
		public int id { get; set; }

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x003D1389 File Offset: 0x003CF589
		// (set) Token: 0x0600DA0B RID: 55819 RVA: 0x003D1391 File Offset: 0x003CF591
		public int type { get; set; }

		// Token: 0x0600DA0C RID: 55820 RVA: 0x003D139C File Offset: 0x003CF59C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.fileContent = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.picName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockValue = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
