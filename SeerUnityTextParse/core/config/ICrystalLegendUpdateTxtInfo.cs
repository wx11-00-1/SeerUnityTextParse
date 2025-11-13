using System;

namespace core.config
{
	// Token: 0x02001D20 RID: 7456
	public class ICrystalLegendUpdateTxtInfo : IConfigItem
	{
		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x003D0DB8 File Offset: 0x003CEFB8
		// (set) Token: 0x0600D9B7 RID: 55735 RVA: 0x003D0DC0 File Offset: 0x003CEFC0
		public string mainTitle { get; set; }

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x003D0DC9 File Offset: 0x003CEFC9
		// (set) Token: 0x0600D9B9 RID: 55737 RVA: 0x003D0DD1 File Offset: 0x003CEFD1
		public string subTxt { get; set; }

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x003D0DDA File Offset: 0x003CEFDA
		// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x003D0DE2 File Offset: 0x003CEFE2
		public int id { get; set; }

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x003D0DEB File Offset: 0x003CEFEB
		// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x003D0DF3 File Offset: 0x003CEFF3
		public int updateID { get; set; }

		// Token: 0x0600D9BE RID: 55742 RVA: 0x003D0DFC File Offset: 0x003CEFFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mainTitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.updateID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
