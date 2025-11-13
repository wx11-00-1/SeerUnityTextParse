using System;

namespace core.config
{
	// Token: 0x02001D22 RID: 7458
	public class IDailytaskInfo : IConfigItem
	{
		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x003D0ED0 File Offset: 0x003CF0D0
		// (set) Token: 0x0600D9C5 RID: 55749 RVA: 0x003D0ED8 File Offset: 0x003CF0D8
		public string describe { get; set; }

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x003D0EE1 File Offset: 0x003CF0E1
		// (set) Token: 0x0600D9C7 RID: 55751 RVA: 0x003D0EE9 File Offset: 0x003CF0E9
		public string rewardinfo { get; set; }

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x003D0EF2 File Offset: 0x003CF0F2
		// (set) Token: 0x0600D9C9 RID: 55753 RVA: 0x003D0EFA File Offset: 0x003CF0FA
		public string title { get; set; }

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x003D0F03 File Offset: 0x003CF103
		// (set) Token: 0x0600D9CB RID: 55755 RVA: 0x003D0F0B File Offset: 0x003CF10B
		public string value { get; set; }

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600D9CC RID: 55756 RVA: 0x003D0F14 File Offset: 0x003CF114
		// (set) Token: 0x0600D9CD RID: 55757 RVA: 0x003D0F1C File Offset: 0x003CF11C
		public int id { get; set; }

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600D9CE RID: 55758 RVA: 0x003D0F25 File Offset: 0x003CF125
		// (set) Token: 0x0600D9CF RID: 55759 RVA: 0x003D0F2D File Offset: 0x003CF12D
		public int target { get; set; }

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600D9D0 RID: 55760 RVA: 0x003D0F36 File Offset: 0x003CF136
		// (set) Token: 0x0600D9D1 RID: 55761 RVA: 0x003D0F3E File Offset: 0x003CF13E
		public int time { get; set; }

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x003D0F48 File Offset: 0x003CF148
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
