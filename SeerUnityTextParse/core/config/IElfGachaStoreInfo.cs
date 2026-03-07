using System;

namespace core.config
{
	// Token: 0x02001FBB RID: 8123
	public class IElfGachaStoreInfo : IConfigItem
	{
		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x0600F332 RID: 62258 RVA: 0x00436454 File Offset: 0x00434654
		// (set) Token: 0x0600F333 RID: 62259 RVA: 0x0043645C File Offset: 0x0043465C
		public string endtime { get; set; }

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x0600F334 RID: 62260 RVA: 0x00436465 File Offset: 0x00434665
		// (set) Token: 0x0600F335 RID: 62261 RVA: 0x0043646D File Offset: 0x0043466D
		public string reward { get; set; }

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600F336 RID: 62262 RVA: 0x00436476 File Offset: 0x00434676
		// (set) Token: 0x0600F337 RID: 62263 RVA: 0x0043647E File Offset: 0x0043467E
		public string starttime { get; set; }

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600F338 RID: 62264 RVA: 0x00436487 File Offset: 0x00434687
		// (set) Token: 0x0600F339 RID: 62265 RVA: 0x0043648F File Offset: 0x0043468F
		public int consumeid { get; set; }

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600F33A RID: 62266 RVA: 0x00436498 File Offset: 0x00434698
		// (set) Token: 0x0600F33B RID: 62267 RVA: 0x004364A0 File Offset: 0x004346A0
		public int consumnum { get; set; }

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x0600F33C RID: 62268 RVA: 0x004364A9 File Offset: 0x004346A9
		// (set) Token: 0x0600F33D RID: 62269 RVA: 0x004364B1 File Offset: 0x004346B1
		public int id { get; set; }

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600F33E RID: 62270 RVA: 0x004364BA File Offset: 0x004346BA
		// (set) Token: 0x0600F33F RID: 62271 RVA: 0x004364C2 File Offset: 0x004346C2
		public int NewMsglogId { get; set; }

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600F340 RID: 62272 RVA: 0x004364CB File Offset: 0x004346CB
		// (set) Token: 0x0600F341 RID: 62273 RVA: 0x004364D3 File Offset: 0x004346D3
		public int poolid { get; set; }

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600F342 RID: 62274 RVA: 0x004364DC File Offset: 0x004346DC
		// (set) Token: 0x0600F343 RID: 62275 RVA: 0x004364E4 File Offset: 0x004346E4
		public int storeid { get; set; }

		// Token: 0x0600F344 RID: 62276 RVA: 0x004364F0 File Offset: 0x004346F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.consumeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.consumnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.storeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
