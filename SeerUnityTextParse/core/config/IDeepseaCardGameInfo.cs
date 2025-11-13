using System;

namespace core.config
{
	// Token: 0x02001D26 RID: 7462
	public class IDeepseaCardGameInfo : IConfigItem
	{
		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600D9EE RID: 55790 RVA: 0x003D11E0 File Offset: 0x003CF3E0
		// (set) Token: 0x0600D9EF RID: 55791 RVA: 0x003D11E8 File Offset: 0x003CF3E8
		public string levelname { get; set; }

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600D9F0 RID: 55792 RVA: 0x003D11F1 File Offset: 0x003CF3F1
		// (set) Token: 0x0600D9F1 RID: 55793 RVA: 0x003D11F9 File Offset: 0x003CF3F9
		public string reward { get; set; }

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x003D1202 File Offset: 0x003CF402
		// (set) Token: 0x0600D9F3 RID: 55795 RVA: 0x003D120A File Offset: 0x003CF40A
		public int bosshp { get; set; }

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x003D1213 File Offset: 0x003CF413
		// (set) Token: 0x0600D9F5 RID: 55797 RVA: 0x003D121B File Offset: 0x003CF41B
		public int id { get; set; }

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x003D1224 File Offset: 0x003CF424
		// (set) Token: 0x0600D9F7 RID: 55799 RVA: 0x003D122C File Offset: 0x003CF42C
		public int opentime { get; set; }

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600D9F8 RID: 55800 RVA: 0x003D1235 File Offset: 0x003CF435
		// (set) Token: 0x0600D9F9 RID: 55801 RVA: 0x003D123D File Offset: 0x003CF43D
		public int playerhp { get; set; }

		// Token: 0x0600D9FA RID: 55802 RVA: 0x003D1248 File Offset: 0x003CF448
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bosshp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.levelname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
