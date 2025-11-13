using System;

namespace core.config
{
	// Token: 0x02001DC4 RID: 7620
	public class IPopupInfo : IConfigItem
	{
		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x003D9150 File Offset: 0x003D7350
		// (set) Token: 0x0600E049 RID: 57417 RVA: 0x003D9158 File Offset: 0x003D7358
		public string @goto { get; set; }

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x0600E04A RID: 57418 RVA: 0x003D9161 File Offset: 0x003D7361
		// (set) Token: 0x0600E04B RID: 57419 RVA: 0x003D9169 File Offset: 0x003D7369
		public string showEnd { get; set; }

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x0600E04C RID: 57420 RVA: 0x003D9172 File Offset: 0x003D7372
		// (set) Token: 0x0600E04D RID: 57421 RVA: 0x003D917A File Offset: 0x003D737A
		public string showStart { get; set; }

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600E04E RID: 57422 RVA: 0x003D9183 File Offset: 0x003D7383
		// (set) Token: 0x0600E04F RID: 57423 RVA: 0x003D918B File Offset: 0x003D738B
		public int daily { get; set; }

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x0600E050 RID: 57424 RVA: 0x003D9194 File Offset: 0x003D7394
		// (set) Token: 0x0600E051 RID: 57425 RVA: 0x003D919C File Offset: 0x003D739C
		public int id { get; set; }

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600E052 RID: 57426 RVA: 0x003D91A5 File Offset: 0x003D73A5
		// (set) Token: 0x0600E053 RID: 57427 RVA: 0x003D91AD File Offset: 0x003D73AD
		public int num { get; set; }

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x0600E054 RID: 57428 RVA: 0x003D91B6 File Offset: 0x003D73B6
		// (set) Token: 0x0600E055 RID: 57429 RVA: 0x003D91BE File Offset: 0x003D73BE
		public int pic { get; set; }

		// Token: 0x0600E056 RID: 57430 RVA: 0x003D91C8 File Offset: 0x003D73C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.daily = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.@goto = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showStart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
