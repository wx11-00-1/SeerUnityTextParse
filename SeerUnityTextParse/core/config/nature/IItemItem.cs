using System;

namespace core.config.nature
{
	// Token: 0x02001F9B RID: 8091
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600F326 RID: 62246 RVA: 0x003F81D7 File Offset: 0x003F63D7
		// (set) Token: 0x0600F327 RID: 62247 RVA: 0x003F81DF File Offset: 0x003F63DF
		public string des { get; set; }

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600F328 RID: 62248 RVA: 0x003F81E8 File Offset: 0x003F63E8
		// (set) Token: 0x0600F329 RID: 62249 RVA: 0x003F81F0 File Offset: 0x003F63F0
		public string des2 { get; set; }

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600F32A RID: 62250 RVA: 0x003F81F9 File Offset: 0x003F63F9
		// (set) Token: 0x0600F32B RID: 62251 RVA: 0x003F8201 File Offset: 0x003F6401
		public string name { get; set; }

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600F32C RID: 62252 RVA: 0x003F820A File Offset: 0x003F640A
		// (set) Token: 0x0600F32D RID: 62253 RVA: 0x003F8212 File Offset: 0x003F6412
		public int id { get; set; }

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600F32E RID: 62254 RVA: 0x003F821B File Offset: 0x003F641B
		// (set) Token: 0x0600F32F RID: 62255 RVA: 0x003F8223 File Offset: 0x003F6423
		public float m_attack { get; set; }

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x0600F330 RID: 62256 RVA: 0x003F822C File Offset: 0x003F642C
		// (set) Token: 0x0600F331 RID: 62257 RVA: 0x003F8234 File Offset: 0x003F6434
		public float m_defence { get; set; }

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x0600F332 RID: 62258 RVA: 0x003F823D File Offset: 0x003F643D
		// (set) Token: 0x0600F333 RID: 62259 RVA: 0x003F8245 File Offset: 0x003F6445
		public float m_SA { get; set; }

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x0600F334 RID: 62260 RVA: 0x003F824E File Offset: 0x003F644E
		// (set) Token: 0x0600F335 RID: 62261 RVA: 0x003F8256 File Offset: 0x003F6456
		public float m_SD { get; set; }

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x0600F336 RID: 62262 RVA: 0x003F825F File Offset: 0x003F645F
		// (set) Token: 0x0600F337 RID: 62263 RVA: 0x003F8267 File Offset: 0x003F6467
		public float m_speed { get; set; }

		// Token: 0x0600F338 RID: 62264 RVA: 0x003F8270 File Offset: 0x003F6470
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.des2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.m_SA = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.m_SD = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.m_attack = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.m_defence = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.m_speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
