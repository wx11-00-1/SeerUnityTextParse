using System;

namespace core.config
{
	// Token: 0x02001E1E RID: 7710
	public class IShopRecommendInfo : IConfigItem
	{
		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x0600E420 RID: 58400 RVA: 0x003DDFE0 File Offset: 0x003DC1E0
		// (set) Token: 0x0600E421 RID: 58401 RVA: 0x003DDFE8 File Offset: 0x003DC1E8
		public string atlas { get; set; }

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x0600E422 RID: 58402 RVA: 0x003DDFF1 File Offset: 0x003DC1F1
		// (set) Token: 0x0600E423 RID: 58403 RVA: 0x003DDFF9 File Offset: 0x003DC1F9
		public string jump { get; set; }

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x0600E424 RID: 58404 RVA: 0x003DE002 File Offset: 0x003DC202
		// (set) Token: 0x0600E425 RID: 58405 RVA: 0x003DE00A File Offset: 0x003DC20A
		public string name { get; set; }

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x003DE013 File Offset: 0x003DC213
		// (set) Token: 0x0600E427 RID: 58407 RVA: 0x003DE01B File Offset: 0x003DC21B
		public string poster { get; set; }

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x0600E428 RID: 58408 RVA: 0x003DE024 File Offset: 0x003DC224
		// (set) Token: 0x0600E429 RID: 58409 RVA: 0x003DE02C File Offset: 0x003DC22C
		public int id { get; set; }

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600E42A RID: 58410 RVA: 0x003DE035 File Offset: 0x003DC235
		// (set) Token: 0x0600E42B RID: 58411 RVA: 0x003DE03D File Offset: 0x003DC23D
		public int show { get; set; }

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600E42C RID: 58412 RVA: 0x003DE046 File Offset: 0x003DC246
		// (set) Token: 0x0600E42D RID: 58413 RVA: 0x003DE04E File Offset: 0x003DC24E
		public int sort { get; set; }

		// Token: 0x0600E42E RID: 58414 RVA: 0x003DE058 File Offset: 0x003DC258
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atlas = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.poster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
