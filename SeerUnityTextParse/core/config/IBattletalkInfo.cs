using System;

namespace core.config
{
	// Token: 0x02001CC4 RID: 7364
	public class IBattletalkInfo : IConfigItem
	{
		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x003CC044 File Offset: 0x003CA244
		// (set) Token: 0x0600D5B5 RID: 54709 RVA: 0x003CC04C File Offset: 0x003CA24C
		public string character { get; set; }

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600D5B6 RID: 54710 RVA: 0x003CC055 File Offset: 0x003CA255
		// (set) Token: 0x0600D5B7 RID: 54711 RVA: 0x003CC05D File Offset: 0x003CA25D
		public string head { get; set; }

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x0600D5B8 RID: 54712 RVA: 0x003CC066 File Offset: 0x003CA266
		// (set) Token: 0x0600D5B9 RID: 54713 RVA: 0x003CC06E File Offset: 0x003CA26E
		public string name { get; set; }

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x003CC077 File Offset: 0x003CA277
		// (set) Token: 0x0600D5BB RID: 54715 RVA: 0x003CC07F File Offset: 0x003CA27F
		public string text { get; set; }

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x003CC088 File Offset: 0x003CA288
		// (set) Token: 0x0600D5BD RID: 54717 RVA: 0x003CC090 File Offset: 0x003CA290
		public int id { get; set; }

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x003CC099 File Offset: 0x003CA299
		// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x003CC0A1 File Offset: 0x003CA2A1
		public int place { get; set; }

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x003CC0AA File Offset: 0x003CA2AA
		// (set) Token: 0x0600D5C1 RID: 54721 RVA: 0x003CC0B2 File Offset: 0x003CA2B2
		public int talkid { get; set; }

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x003CC0BC File Offset: 0x003CA2BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.character = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.place = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.talkid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
