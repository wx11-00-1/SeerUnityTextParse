using System;

namespace core.config
{
	// Token: 0x02001C9C RID: 7324
	public class IAdAstraLevelInfo : IConfigItem
	{
		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x0600D418 RID: 54296 RVA: 0x003CA1CC File Offset: 0x003C83CC
		// (set) Token: 0x0600D419 RID: 54297 RVA: 0x003CA1D4 File Offset: 0x003C83D4
		public string banPet { get; set; }

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600D41A RID: 54298 RVA: 0x003CA1DD File Offset: 0x003C83DD
		// (set) Token: 0x0600D41B RID: 54299 RVA: 0x003CA1E5 File Offset: 0x003C83E5
		public string bossID { get; set; }

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600D41C RID: 54300 RVA: 0x003CA1EE File Offset: 0x003C83EE
		// (set) Token: 0x0600D41D RID: 54301 RVA: 0x003CA1F6 File Offset: 0x003C83F6
		public string condition { get; set; }

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600D41E RID: 54302 RVA: 0x003CA1FF File Offset: 0x003C83FF
		// (set) Token: 0x0600D41F RID: 54303 RVA: 0x003CA207 File Offset: 0x003C8407
		public string firstAward { get; set; }

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600D420 RID: 54304 RVA: 0x003CA210 File Offset: 0x003C8410
		// (set) Token: 0x0600D421 RID: 54305 RVA: 0x003CA218 File Offset: 0x003C8418
		public string levelName { get; set; }

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600D422 RID: 54306 RVA: 0x003CA221 File Offset: 0x003C8421
		// (set) Token: 0x0600D423 RID: 54307 RVA: 0x003CA229 File Offset: 0x003C8429
		public int id { get; set; }

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600D424 RID: 54308 RVA: 0x003CA232 File Offset: 0x003C8432
		// (set) Token: 0x0600D425 RID: 54309 RVA: 0x003CA23A File Offset: 0x003C843A
		public int type { get; set; }

		// Token: 0x0600D426 RID: 54310 RVA: 0x003CA244 File Offset: 0x003C8444
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.banPet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bossID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.condition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.firstAward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.levelName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
