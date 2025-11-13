using System;

namespace core.config
{
	// Token: 0x02001E0E RID: 7694
	public class ISecurityCheckItemsInfo : IConfigItem
	{
		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x003DCF70 File Offset: 0x003DB170
		// (set) Token: 0x0600E357 RID: 58199 RVA: 0x003DCF78 File Offset: 0x003DB178
		public string itemsname { get; set; }

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600E358 RID: 58200 RVA: 0x003DCF81 File Offset: 0x003DB181
		// (set) Token: 0x0600E359 RID: 58201 RVA: 0x003DCF89 File Offset: 0x003DB189
		public string wrongnum { get; set; }

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x0600E35A RID: 58202 RVA: 0x003DCF92 File Offset: 0x003DB192
		// (set) Token: 0x0600E35B RID: 58203 RVA: 0x003DCF9A File Offset: 0x003DB19A
		public int id { get; set; }

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x003DCFA3 File Offset: 0x003DB1A3
		// (set) Token: 0x0600E35D RID: 58205 RVA: 0x003DCFAB File Offset: 0x003DB1AB
		public int itemtype { get; set; }

		// Token: 0x0600E35E RID: 58206 RVA: 0x003DCFB4 File Offset: 0x003DB1B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemsname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.itemtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wrongnum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
