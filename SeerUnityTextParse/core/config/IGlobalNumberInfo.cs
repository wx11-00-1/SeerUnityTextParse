using System;

namespace core.config
{
	// Token: 0x02001D5C RID: 7516
	public class IGlobalNumberInfo : IConfigItem
	{
		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x0600DC1A RID: 56346 RVA: 0x003D3DBC File Offset: 0x003D1FBC
		// (set) Token: 0x0600DC1B RID: 56347 RVA: 0x003D3DC4 File Offset: 0x003D1FC4
		public string name { get; set; }

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x0600DC1C RID: 56348 RVA: 0x003D3DCD File Offset: 0x003D1FCD
		// (set) Token: 0x0600DC1D RID: 56349 RVA: 0x003D3DD5 File Offset: 0x003D1FD5
		public int content { get; set; }

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x0600DC1E RID: 56350 RVA: 0x003D3DDE File Offset: 0x003D1FDE
		// (set) Token: 0x0600DC1F RID: 56351 RVA: 0x003D3DE6 File Offset: 0x003D1FE6
		public int id { get; set; }

		// Token: 0x0600DC20 RID: 56352 RVA: 0x003D3DEF File Offset: 0x003D1FEF
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.content = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
