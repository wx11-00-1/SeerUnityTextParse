using System;

namespace core.config
{
	// Token: 0x020028C7 RID: 10439
	public class IFilmgameLvInfo : IConfigItem
	{
		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06014E7E RID: 85630 RVA: 0x005B6680 File Offset: 0x005B4880
		// (set) Token: 0x06014E7F RID: 85631 RVA: 0x005B6688 File Offset: 0x005B4888
		public string name { get; set; }

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06014E80 RID: 85632 RVA: 0x005B6691 File Offset: 0x005B4891
		// (set) Token: 0x06014E81 RID: 85633 RVA: 0x005B6699 File Offset: 0x005B4899
		public int exp { get; set; }

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06014E82 RID: 85634 RVA: 0x005B66A2 File Offset: 0x005B48A2
		// (set) Token: 0x06014E83 RID: 85635 RVA: 0x005B66AA File Offset: 0x005B48AA
		public int id { get; set; }

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06014E84 RID: 85636 RVA: 0x005B66B3 File Offset: 0x005B48B3
		// (set) Token: 0x06014E85 RID: 85637 RVA: 0x005B66BB File Offset: 0x005B48BB
		public int lockstory { get; set; }

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06014E86 RID: 85638 RVA: 0x005B66C4 File Offset: 0x005B48C4
		// (set) Token: 0x06014E87 RID: 85639 RVA: 0x005B66CC File Offset: 0x005B48CC
		public int lv { get; set; }

		// Token: 0x06014E88 RID: 85640 RVA: 0x005B66D8 File Offset: 0x005B48D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lockstory = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
