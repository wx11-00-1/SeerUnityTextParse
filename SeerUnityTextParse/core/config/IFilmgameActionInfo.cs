using System;

namespace core.config
{
	// Token: 0x020028BF RID: 10431
	public class IFilmgameActionInfo : IConfigItem
	{
		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06014E42 RID: 85570 RVA: 0x005B61F4 File Offset: 0x005B43F4
		// (set) Token: 0x06014E43 RID: 85571 RVA: 0x005B61FC File Offset: 0x005B43FC
		public string trueword { get; set; }

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06014E44 RID: 85572 RVA: 0x005B6205 File Offset: 0x005B4405
		// (set) Token: 0x06014E45 RID: 85573 RVA: 0x005B620D File Offset: 0x005B440D
		public int id { get; set; }

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06014E46 RID: 85574 RVA: 0x005B6216 File Offset: 0x005B4416
		// (set) Token: 0x06014E47 RID: 85575 RVA: 0x005B621E File Offset: 0x005B441E
		public int lens { get; set; }

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06014E48 RID: 85576 RVA: 0x005B6227 File Offset: 0x005B4427
		// (set) Token: 0x06014E49 RID: 85577 RVA: 0x005B622F File Offset: 0x005B442F
		public int order { get; set; }

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06014E4A RID: 85578 RVA: 0x005B6238 File Offset: 0x005B4438
		// (set) Token: 0x06014E4B RID: 85579 RVA: 0x005B6240 File Offset: 0x005B4440
		public int says { get; set; }

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06014E4C RID: 85580 RVA: 0x005B6249 File Offset: 0x005B4449
		// (set) Token: 0x06014E4D RID: 85581 RVA: 0x005B6251 File Offset: 0x005B4451
		public int storyid { get; set; }

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06014E4E RID: 85582 RVA: 0x005B625A File Offset: 0x005B445A
		// (set) Token: 0x06014E4F RID: 85583 RVA: 0x005B6262 File Offset: 0x005B4462
		public int textid { get; set; }

		// Token: 0x06014E50 RID: 85584 RVA: 0x005B626C File Offset: 0x005B446C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lens = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.says = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.textid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.trueword = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
