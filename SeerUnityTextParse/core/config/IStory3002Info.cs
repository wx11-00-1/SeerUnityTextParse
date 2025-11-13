using System;

namespace core.config
{
	// Token: 0x02001E70 RID: 7792
	public class IStory3002Info : IConfigItem
	{
		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x0600E7C6 RID: 59334 RVA: 0x003E276C File Offset: 0x003E096C
		// (set) Token: 0x0600E7C7 RID: 59335 RVA: 0x003E2774 File Offset: 0x003E0974
		public string param1 { get; set; }

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x0600E7C8 RID: 59336 RVA: 0x003E277D File Offset: 0x003E097D
		// (set) Token: 0x0600E7C9 RID: 59337 RVA: 0x003E2785 File Offset: 0x003E0985
		public string param2 { get; set; }

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600E7CA RID: 59338 RVA: 0x003E278E File Offset: 0x003E098E
		// (set) Token: 0x0600E7CB RID: 59339 RVA: 0x003E2796 File Offset: 0x003E0996
		public string param3 { get; set; }

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600E7CC RID: 59340 RVA: 0x003E279F File Offset: 0x003E099F
		// (set) Token: 0x0600E7CD RID: 59341 RVA: 0x003E27A7 File Offset: 0x003E09A7
		public string param4 { get; set; }

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600E7CE RID: 59342 RVA: 0x003E27B0 File Offset: 0x003E09B0
		// (set) Token: 0x0600E7CF RID: 59343 RVA: 0x003E27B8 File Offset: 0x003E09B8
		public string param5 { get; set; }

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600E7D0 RID: 59344 RVA: 0x003E27C1 File Offset: 0x003E09C1
		// (set) Token: 0x0600E7D1 RID: 59345 RVA: 0x003E27C9 File Offset: 0x003E09C9
		public float control { get; set; }

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600E7D2 RID: 59346 RVA: 0x003E27D2 File Offset: 0x003E09D2
		// (set) Token: 0x0600E7D3 RID: 59347 RVA: 0x003E27DA File Offset: 0x003E09DA
		public int id { get; set; }

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x0600E7D4 RID: 59348 RVA: 0x003E27E3 File Offset: 0x003E09E3
		// (set) Token: 0x0600E7D5 RID: 59349 RVA: 0x003E27EB File Offset: 0x003E09EB
		public int logic { get; set; }

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600E7D6 RID: 59350 RVA: 0x003E27F4 File Offset: 0x003E09F4
		// (set) Token: 0x0600E7D7 RID: 59351 RVA: 0x003E27FC File Offset: 0x003E09FC
		public int next { get; set; }

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x003E2808 File Offset: 0x003E0A08
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
