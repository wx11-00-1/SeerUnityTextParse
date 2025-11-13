using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F55 RID: 8021
	public class IMonsterItem
	{
		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x0600F098 RID: 61592 RVA: 0x003F5036 File Offset: 0x003F3236
		// (set) Token: 0x0600F099 RID: 61593 RVA: 0x003F503E File Offset: 0x003F323E
		public string DefName { get; set; }

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x0600F09A RID: 61594 RVA: 0x003F5047 File Offset: 0x003F3247
		// (set) Token: 0x0600F09B RID: 61595 RVA: 0x003F504F File Offset: 0x003F324F
		public string Features { get; set; }

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x0600F09C RID: 61596 RVA: 0x003F5058 File Offset: 0x003F3258
		// (set) Token: 0x0600F09D RID: 61597 RVA: 0x003F5060 File Offset: 0x003F3260
		public string Target { get; set; }

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x0600F09E RID: 61598 RVA: 0x003F5069 File Offset: 0x003F3269
		// (set) Token: 0x0600F09F RID: 61599 RVA: 0x003F5071 File Offset: 0x003F3271
		public string Tyjumptargetpe { get; set; }

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x0600F0A0 RID: 61600 RVA: 0x003F507A File Offset: 0x003F327A
		// (set) Token: 0x0600F0A1 RID: 61601 RVA: 0x003F5082 File Offset: 0x003F3282
		public int ID { get; set; }

		// Token: 0x0600F0A2 RID: 61602 RVA: 0x003F508C File Offset: 0x003F328C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tyjumptargetpe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
