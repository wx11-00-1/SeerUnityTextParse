using System;

namespace core.config
{
	// Token: 0x02001D0C RID: 7436
	public class IConstFieldsInfo : IConfigItem
	{
		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x003CFF94 File Offset: 0x003CE194
		// (set) Token: 0x0600D8FB RID: 55547 RVA: 0x003CFF9C File Offset: 0x003CE19C
		public string constClassName { get; set; }

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x003CFFA5 File Offset: 0x003CE1A5
		// (set) Token: 0x0600D8FD RID: 55549 RVA: 0x003CFFAD File Offset: 0x003CE1AD
		public string keyField { get; set; }

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x003CFFB6 File Offset: 0x003CE1B6
		// (set) Token: 0x0600D8FF RID: 55551 RVA: 0x003CFFBE File Offset: 0x003CE1BE
		public string tableName { get; set; }

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x003CFFC7 File Offset: 0x003CE1C7
		// (set) Token: 0x0600D901 RID: 55553 RVA: 0x003CFFCF File Offset: 0x003CE1CF
		public string valueField { get; set; }

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x0600D902 RID: 55554 RVA: 0x003CFFD8 File Offset: 0x003CE1D8
		// (set) Token: 0x0600D903 RID: 55555 RVA: 0x003CFFE0 File Offset: 0x003CE1E0
		public int id { get; set; }

		// Token: 0x0600D904 RID: 55556 RVA: 0x003CFFEC File Offset: 0x003CE1EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.constClassName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.keyField = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tableName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.valueField = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
