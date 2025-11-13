using System;

namespace core.config
{
	// Token: 0x02001D4A RID: 7498
	public class IFestivalVersionConfigInfo : IConfigItem
	{
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600DB56 RID: 56150 RVA: 0x003D2C3C File Offset: 0x003D0E3C
		// (set) Token: 0x0600DB57 RID: 56151 RVA: 0x003D2C44 File Offset: 0x003D0E44
		public string endTime { get; set; }

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600DB58 RID: 56152 RVA: 0x003D2C4D File Offset: 0x003D0E4D
		// (set) Token: 0x0600DB59 RID: 56153 RVA: 0x003D2C55 File Offset: 0x003D0E55
		public string startTime { get; set; }

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x0600DB5A RID: 56154 RVA: 0x003D2C5E File Offset: 0x003D0E5E
		// (set) Token: 0x0600DB5B RID: 56155 RVA: 0x003D2C66 File Offset: 0x003D0E66
		public string suffix { get; set; }

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x0600DB5C RID: 56156 RVA: 0x003D2C6F File Offset: 0x003D0E6F
		// (set) Token: 0x0600DB5D RID: 56157 RVA: 0x003D2C77 File Offset: 0x003D0E77
		public string tables { get; set; }

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600DB5E RID: 56158 RVA: 0x003D2C80 File Offset: 0x003D0E80
		// (set) Token: 0x0600DB5F RID: 56159 RVA: 0x003D2C88 File Offset: 0x003D0E88
		public int id { get; set; }

		// Token: 0x0600DB60 RID: 56160 RVA: 0x003D2C94 File Offset: 0x003D0E94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.suffix = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tables = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
