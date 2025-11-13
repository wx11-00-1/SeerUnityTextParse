using System;

namespace core.config
{
	// Token: 0x02001C9A RID: 7322
	public class IAdAstraGalaxyTempInfo : IConfigItem
	{
		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600D3FA RID: 54266 RVA: 0x003C9FB0 File Offset: 0x003C81B0
		// (set) Token: 0x0600D3FB RID: 54267 RVA: 0x003C9FB8 File Offset: 0x003C81B8
		public string galaxyName { get; set; }

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600D3FC RID: 54268 RVA: 0x003C9FC1 File Offset: 0x003C81C1
		// (set) Token: 0x0600D3FD RID: 54269 RVA: 0x003C9FC9 File Offset: 0x003C81C9
		public string galaxyNameEn { get; set; }

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600D3FE RID: 54270 RVA: 0x003C9FD2 File Offset: 0x003C81D2
		// (set) Token: 0x0600D3FF RID: 54271 RVA: 0x003C9FDA File Offset: 0x003C81DA
		public string starLevel { get; set; }

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600D400 RID: 54272 RVA: 0x003C9FE3 File Offset: 0x003C81E3
		// (set) Token: 0x0600D401 RID: 54273 RVA: 0x003C9FEB File Offset: 0x003C81EB
		public string starName { get; set; }

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600D402 RID: 54274 RVA: 0x003C9FF4 File Offset: 0x003C81F4
		// (set) Token: 0x0600D403 RID: 54275 RVA: 0x003C9FFC File Offset: 0x003C81FC
		public string unlockStar { get; set; }

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600D404 RID: 54276 RVA: 0x003CA005 File Offset: 0x003C8205
		// (set) Token: 0x0600D405 RID: 54277 RVA: 0x003CA00D File Offset: 0x003C820D
		public int endTime { get; set; }

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600D406 RID: 54278 RVA: 0x003CA016 File Offset: 0x003C8216
		// (set) Token: 0x0600D407 RID: 54279 RVA: 0x003CA01E File Offset: 0x003C821E
		public int galaxyId { get; set; }

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600D408 RID: 54280 RVA: 0x003CA027 File Offset: 0x003C8227
		// (set) Token: 0x0600D409 RID: 54281 RVA: 0x003CA02F File Offset: 0x003C822F
		public int galaxyType { get; set; }

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600D40A RID: 54282 RVA: 0x003CA038 File Offset: 0x003C8238
		// (set) Token: 0x0600D40B RID: 54283 RVA: 0x003CA040 File Offset: 0x003C8240
		public int id { get; set; }

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600D40C RID: 54284 RVA: 0x003CA049 File Offset: 0x003C8249
		// (set) Token: 0x0600D40D RID: 54285 RVA: 0x003CA051 File Offset: 0x003C8251
		public int starId { get; set; }

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600D40E RID: 54286 RVA: 0x003CA05A File Offset: 0x003C825A
		// (set) Token: 0x0600D40F RID: 54287 RVA: 0x003CA062 File Offset: 0x003C8262
		public int starProgressAll { get; set; }

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600D410 RID: 54288 RVA: 0x003CA06B File Offset: 0x003C826B
		// (set) Token: 0x0600D411 RID: 54289 RVA: 0x003CA073 File Offset: 0x003C8273
		public int unlockTime { get; set; }

		// Token: 0x0600D412 RID: 54290 RVA: 0x003CA07C File Offset: 0x003C827C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.galaxyId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.galaxyName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.galaxyNameEn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.galaxyType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starLevel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.starName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.starProgressAll = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockStar = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlockTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
