using System;

namespace core.config
{
	// Token: 0x02001C98 RID: 7320
	public class IAdAstraGalaxyGuoqingInfo : IConfigItem
	{
		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600D3DC RID: 54236 RVA: 0x003C9D94 File Offset: 0x003C7F94
		// (set) Token: 0x0600D3DD RID: 54237 RVA: 0x003C9D9C File Offset: 0x003C7F9C
		public string galaxyName { get; set; }

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600D3DE RID: 54238 RVA: 0x003C9DA5 File Offset: 0x003C7FA5
		// (set) Token: 0x0600D3DF RID: 54239 RVA: 0x003C9DAD File Offset: 0x003C7FAD
		public string galaxyNameEn { get; set; }

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600D3E0 RID: 54240 RVA: 0x003C9DB6 File Offset: 0x003C7FB6
		// (set) Token: 0x0600D3E1 RID: 54241 RVA: 0x003C9DBE File Offset: 0x003C7FBE
		public string starLevel { get; set; }

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600D3E2 RID: 54242 RVA: 0x003C9DC7 File Offset: 0x003C7FC7
		// (set) Token: 0x0600D3E3 RID: 54243 RVA: 0x003C9DCF File Offset: 0x003C7FCF
		public string starName { get; set; }

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600D3E4 RID: 54244 RVA: 0x003C9DD8 File Offset: 0x003C7FD8
		// (set) Token: 0x0600D3E5 RID: 54245 RVA: 0x003C9DE0 File Offset: 0x003C7FE0
		public string unlockStar { get; set; }

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600D3E6 RID: 54246 RVA: 0x003C9DE9 File Offset: 0x003C7FE9
		// (set) Token: 0x0600D3E7 RID: 54247 RVA: 0x003C9DF1 File Offset: 0x003C7FF1
		public int endTime { get; set; }

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x0600D3E8 RID: 54248 RVA: 0x003C9DFA File Offset: 0x003C7FFA
		// (set) Token: 0x0600D3E9 RID: 54249 RVA: 0x003C9E02 File Offset: 0x003C8002
		public int galaxyId { get; set; }

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x0600D3EA RID: 54250 RVA: 0x003C9E0B File Offset: 0x003C800B
		// (set) Token: 0x0600D3EB RID: 54251 RVA: 0x003C9E13 File Offset: 0x003C8013
		public int galaxyType { get; set; }

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x0600D3EC RID: 54252 RVA: 0x003C9E1C File Offset: 0x003C801C
		// (set) Token: 0x0600D3ED RID: 54253 RVA: 0x003C9E24 File Offset: 0x003C8024
		public int id { get; set; }

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600D3EE RID: 54254 RVA: 0x003C9E2D File Offset: 0x003C802D
		// (set) Token: 0x0600D3EF RID: 54255 RVA: 0x003C9E35 File Offset: 0x003C8035
		public int starId { get; set; }

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600D3F0 RID: 54256 RVA: 0x003C9E3E File Offset: 0x003C803E
		// (set) Token: 0x0600D3F1 RID: 54257 RVA: 0x003C9E46 File Offset: 0x003C8046
		public int starProgressAll { get; set; }

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600D3F2 RID: 54258 RVA: 0x003C9E4F File Offset: 0x003C804F
		// (set) Token: 0x0600D3F3 RID: 54259 RVA: 0x003C9E57 File Offset: 0x003C8057
		public int unlockTime { get; set; }

		// Token: 0x0600D3F4 RID: 54260 RVA: 0x003C9E60 File Offset: 0x003C8060
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
