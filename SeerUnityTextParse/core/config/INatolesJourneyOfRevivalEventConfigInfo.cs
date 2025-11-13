using System;

namespace core.config
{
	// Token: 0x02001D9E RID: 7582
	public class INatolesJourneyOfRevivalEventConfigInfo : IConfigItem
	{
		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x003D6F3C File Offset: 0x003D513C
		// (set) Token: 0x0600DE8B RID: 56971 RVA: 0x003D6F44 File Offset: 0x003D5144
		public string des { get; set; }

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x003D6F4D File Offset: 0x003D514D
		// (set) Token: 0x0600DE8D RID: 56973 RVA: 0x003D6F55 File Offset: 0x003D5155
		public string firstShow { get; set; }

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x003D6F5E File Offset: 0x003D515E
		// (set) Token: 0x0600DE8F RID: 56975 RVA: 0x003D6F66 File Offset: 0x003D5166
		public string name { get; set; }

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x003D6F6F File Offset: 0x003D516F
		// (set) Token: 0x0600DE91 RID: 56977 RVA: 0x003D6F77 File Offset: 0x003D5177
		public string secondShow { get; set; }

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x0600DE92 RID: 56978 RVA: 0x003D6F80 File Offset: 0x003D5180
		// (set) Token: 0x0600DE93 RID: 56979 RVA: 0x003D6F88 File Offset: 0x003D5188
		public int id { get; set; }

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x0600DE94 RID: 56980 RVA: 0x003D6F91 File Offset: 0x003D5191
		// (set) Token: 0x0600DE95 RID: 56981 RVA: 0x003D6F99 File Offset: 0x003D5199
		public int type { get; set; }

		// Token: 0x0600DE96 RID: 56982 RVA: 0x003D6FA4 File Offset: 0x003D51A4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.firstShow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.secondShow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
