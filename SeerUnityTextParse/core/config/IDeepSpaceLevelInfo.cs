using System;

namespace core.config
{
	// Token: 0x02001D32 RID: 7474
	public class IDeepSpaceLevelInfo : IConfigItem
	{
		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x0600DA5C RID: 55900 RVA: 0x003D1A3C File Offset: 0x003CFC3C
		// (set) Token: 0x0600DA5D RID: 55901 RVA: 0x003D1A44 File Offset: 0x003CFC44
		public string block { get; set; }

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600DA5E RID: 55902 RVA: 0x003D1A4D File Offset: 0x003CFC4D
		// (set) Token: 0x0600DA5F RID: 55903 RVA: 0x003D1A55 File Offset: 0x003CFC55
		public string tishi { get; set; }

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600DA60 RID: 55904 RVA: 0x003D1A5E File Offset: 0x003CFC5E
		// (set) Token: 0x0600DA61 RID: 55905 RVA: 0x003D1A66 File Offset: 0x003CFC66
		public int id { get; set; }

		// Token: 0x0600DA62 RID: 55906 RVA: 0x003D1A6F File Offset: 0x003CFC6F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.block = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tishi = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
