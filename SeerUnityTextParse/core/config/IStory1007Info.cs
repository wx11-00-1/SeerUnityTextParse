using System;

namespace core.config
{
	// Token: 0x02001E54 RID: 7764
	public class IStory1007Info : IConfigItem
	{
		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600E676 RID: 58998 RVA: 0x003E0EB4 File Offset: 0x003DF0B4
		// (set) Token: 0x0600E677 RID: 58999 RVA: 0x003E0EBC File Offset: 0x003DF0BC
		public string param1 { get; set; }

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x0600E678 RID: 59000 RVA: 0x003E0EC5 File Offset: 0x003DF0C5
		// (set) Token: 0x0600E679 RID: 59001 RVA: 0x003E0ECD File Offset: 0x003DF0CD
		public string param2 { get; set; }

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600E67A RID: 59002 RVA: 0x003E0ED6 File Offset: 0x003DF0D6
		// (set) Token: 0x0600E67B RID: 59003 RVA: 0x003E0EDE File Offset: 0x003DF0DE
		public string param3 { get; set; }

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600E67C RID: 59004 RVA: 0x003E0EE7 File Offset: 0x003DF0E7
		// (set) Token: 0x0600E67D RID: 59005 RVA: 0x003E0EEF File Offset: 0x003DF0EF
		public string param4 { get; set; }

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600E67E RID: 59006 RVA: 0x003E0EF8 File Offset: 0x003DF0F8
		// (set) Token: 0x0600E67F RID: 59007 RVA: 0x003E0F00 File Offset: 0x003DF100
		public string param5 { get; set; }

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600E680 RID: 59008 RVA: 0x003E0F09 File Offset: 0x003DF109
		// (set) Token: 0x0600E681 RID: 59009 RVA: 0x003E0F11 File Offset: 0x003DF111
		public float control { get; set; }

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x0600E682 RID: 59010 RVA: 0x003E0F1A File Offset: 0x003DF11A
		// (set) Token: 0x0600E683 RID: 59011 RVA: 0x003E0F22 File Offset: 0x003DF122
		public int id { get; set; }

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x003E0F2B File Offset: 0x003DF12B
		// (set) Token: 0x0600E685 RID: 59013 RVA: 0x003E0F33 File Offset: 0x003DF133
		public int logic { get; set; }

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x0600E686 RID: 59014 RVA: 0x003E0F3C File Offset: 0x003DF13C
		// (set) Token: 0x0600E687 RID: 59015 RVA: 0x003E0F44 File Offset: 0x003DF144
		public int next { get; set; }

		// Token: 0x0600E688 RID: 59016 RVA: 0x003E0F50 File Offset: 0x003DF150
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
