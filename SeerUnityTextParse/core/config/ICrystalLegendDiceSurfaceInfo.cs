using System;

namespace core.config
{
	// Token: 0x02001D10 RID: 7440
	public class ICrystalLegendDiceSurfaceInfo : IConfigItem
	{
		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x003D0308 File Offset: 0x003CE508
		// (set) Token: 0x0600D929 RID: 55593 RVA: 0x003D0310 File Offset: 0x003CE510
		public string des { get; set; }

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600D92A RID: 55594 RVA: 0x003D0319 File Offset: 0x003CE519
		// (set) Token: 0x0600D92B RID: 55595 RVA: 0x003D0321 File Offset: 0x003CE521
		public string name { get; set; }

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600D92C RID: 55596 RVA: 0x003D032A File Offset: 0x003CE52A
		// (set) Token: 0x0600D92D RID: 55597 RVA: 0x003D0332 File Offset: 0x003CE532
		public int iconID { get; set; }

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x0600D92E RID: 55598 RVA: 0x003D033B File Offset: 0x003CE53B
		// (set) Token: 0x0600D92F RID: 55599 RVA: 0x003D0343 File Offset: 0x003CE543
		public int id { get; set; }

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600D930 RID: 55600 RVA: 0x003D034C File Offset: 0x003CE54C
		// (set) Token: 0x0600D931 RID: 55601 RVA: 0x003D0354 File Offset: 0x003CE554
		public int paramType { get; set; }

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x0600D932 RID: 55602 RVA: 0x003D035D File Offset: 0x003CE55D
		// (set) Token: 0x0600D933 RID: 55603 RVA: 0x003D0365 File Offset: 0x003CE565
		public int relateStateID { get; set; }

		// Token: 0x0600D934 RID: 55604 RVA: 0x003D0370 File Offset: 0x003CE570
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paramType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.relateStateID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
