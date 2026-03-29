using System;

namespace core.config
{
	// Token: 0x02002219 RID: 8729
	public class IDiamonBoxInfo : IConfigItem
	{
		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x060106A6 RID: 67238 RVA: 0x00488F48 File Offset: 0x00487148
		// (set) Token: 0x060106A7 RID: 67239 RVA: 0x00488F50 File Offset: 0x00487150
		public string rewardcnt { get; set; }

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x060106A8 RID: 67240 RVA: 0x00488F59 File Offset: 0x00487159
		// (set) Token: 0x060106A9 RID: 67241 RVA: 0x00488F61 File Offset: 0x00487161
		public string rewardid { get; set; }

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x060106AA RID: 67242 RVA: 0x00488F6A File Offset: 0x0048716A
		// (set) Token: 0x060106AB RID: 67243 RVA: 0x00488F72 File Offset: 0x00487172
		public string rewardpr { get; set; }

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060106AC RID: 67244 RVA: 0x00488F7B File Offset: 0x0048717B
		// (set) Token: 0x060106AD RID: 67245 RVA: 0x00488F83 File Offset: 0x00487183
		public string rewardtype { get; set; }

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060106AE RID: 67246 RVA: 0x00488F8C File Offset: 0x0048718C
		// (set) Token: 0x060106AF RID: 67247 RVA: 0x00488F94 File Offset: 0x00487194
		public int activitynum { get; set; }

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060106B0 RID: 67248 RVA: 0x00488F9D File Offset: 0x0048719D
		// (set) Token: 0x060106B1 RID: 67249 RVA: 0x00488FA5 File Offset: 0x004871A5
		public int exchangecut { get; set; }

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060106B2 RID: 67250 RVA: 0x00488FAE File Offset: 0x004871AE
		// (set) Token: 0x060106B3 RID: 67251 RVA: 0x00488FB6 File Offset: 0x004871B6
		public int id { get; set; }

		// Token: 0x060106B4 RID: 67252 RVA: 0x00488FC0 File Offset: 0x004871C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activitynum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangecut = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardpr = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
