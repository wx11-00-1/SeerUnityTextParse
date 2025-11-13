using System;

namespace core.config
{
	// Token: 0x02001E6A RID: 7786
	public class IStory2006Info : IConfigItem
	{
		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600E77E RID: 59262 RVA: 0x003E2220 File Offset: 0x003E0420
		// (set) Token: 0x0600E77F RID: 59263 RVA: 0x003E2228 File Offset: 0x003E0428
		public string param1 { get; set; }

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600E780 RID: 59264 RVA: 0x003E2231 File Offset: 0x003E0431
		// (set) Token: 0x0600E781 RID: 59265 RVA: 0x003E2239 File Offset: 0x003E0439
		public string param2 { get; set; }

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x0600E782 RID: 59266 RVA: 0x003E2242 File Offset: 0x003E0442
		// (set) Token: 0x0600E783 RID: 59267 RVA: 0x003E224A File Offset: 0x003E044A
		public string param3 { get; set; }

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x0600E784 RID: 59268 RVA: 0x003E2253 File Offset: 0x003E0453
		// (set) Token: 0x0600E785 RID: 59269 RVA: 0x003E225B File Offset: 0x003E045B
		public string param4 { get; set; }

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x003E2264 File Offset: 0x003E0464
		// (set) Token: 0x0600E787 RID: 59271 RVA: 0x003E226C File Offset: 0x003E046C
		public string param5 { get; set; }

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x0600E788 RID: 59272 RVA: 0x003E2275 File Offset: 0x003E0475
		// (set) Token: 0x0600E789 RID: 59273 RVA: 0x003E227D File Offset: 0x003E047D
		public float control { get; set; }

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x0600E78A RID: 59274 RVA: 0x003E2286 File Offset: 0x003E0486
		// (set) Token: 0x0600E78B RID: 59275 RVA: 0x003E228E File Offset: 0x003E048E
		public int id { get; set; }

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600E78C RID: 59276 RVA: 0x003E2297 File Offset: 0x003E0497
		// (set) Token: 0x0600E78D RID: 59277 RVA: 0x003E229F File Offset: 0x003E049F
		public int logic { get; set; }

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600E78E RID: 59278 RVA: 0x003E22A8 File Offset: 0x003E04A8
		// (set) Token: 0x0600E78F RID: 59279 RVA: 0x003E22B0 File Offset: 0x003E04B0
		public int next { get; set; }

		// Token: 0x0600E790 RID: 59280 RVA: 0x003E22BC File Offset: 0x003E04BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
