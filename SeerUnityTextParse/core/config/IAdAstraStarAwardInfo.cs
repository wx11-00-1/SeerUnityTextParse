using System;

namespace core.config
{
	// Token: 0x02001C9E RID: 7326
	public class IAdAstraStarAwardInfo : IConfigItem
	{
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x003CA354 File Offset: 0x003C8554
		// (set) Token: 0x0600D42D RID: 54317 RVA: 0x003CA35C File Offset: 0x003C855C
		public string progressAward { get; set; }

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600D42E RID: 54318 RVA: 0x003CA365 File Offset: 0x003C8565
		// (set) Token: 0x0600D42F RID: 54319 RVA: 0x003CA36D File Offset: 0x003C856D
		public int id { get; set; }

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600D430 RID: 54320 RVA: 0x003CA376 File Offset: 0x003C8576
		// (set) Token: 0x0600D431 RID: 54321 RVA: 0x003CA37E File Offset: 0x003C857E
		public int progress { get; set; }

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600D432 RID: 54322 RVA: 0x003CA387 File Offset: 0x003C8587
		// (set) Token: 0x0600D433 RID: 54323 RVA: 0x003CA38F File Offset: 0x003C858F
		public int star { get; set; }

		// Token: 0x0600D434 RID: 54324 RVA: 0x003CA398 File Offset: 0x003C8598
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.progress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.progressAward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
