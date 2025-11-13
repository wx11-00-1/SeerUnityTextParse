using System;

namespace core.config.email
{
	// Token: 0x02002047 RID: 8263
	public class IElementItem : IConfigItem
	{
		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600FC57 RID: 64599 RVA: 0x00401CC0 File Offset: 0x003FFEC0
		// (set) Token: 0x0600FC58 RID: 64600 RVA: 0x00401CC8 File Offset: 0x003FFEC8
		public string _text { get; set; }

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600FC59 RID: 64601 RVA: 0x00401CD1 File Offset: 0x003FFED1
		// (set) Token: 0x0600FC5A RID: 64602 RVA: 0x00401CD9 File Offset: 0x003FFED9
		public string type { get; set; }

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600FC5B RID: 64603 RVA: 0x00401CE2 File Offset: 0x003FFEE2
		// (set) Token: 0x0600FC5C RID: 64604 RVA: 0x00401CEA File Offset: 0x003FFEEA
		public int id { get; set; }

		// Token: 0x0600FC5D RID: 64605 RVA: 0x00401CF3 File Offset: 0x003FFEF3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this._text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
