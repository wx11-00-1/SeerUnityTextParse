using System;

namespace core.config
{
	// Token: 0x02001E66 RID: 7782
	public class IStory2004Info : IConfigItem
	{
		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600E74E RID: 59214 RVA: 0x003E1E98 File Offset: 0x003E0098
		// (set) Token: 0x0600E74F RID: 59215 RVA: 0x003E1EA0 File Offset: 0x003E00A0
		public string param1 { get; set; }

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x0600E750 RID: 59216 RVA: 0x003E1EA9 File Offset: 0x003E00A9
		// (set) Token: 0x0600E751 RID: 59217 RVA: 0x003E1EB1 File Offset: 0x003E00B1
		public string param2 { get; set; }

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x0600E752 RID: 59218 RVA: 0x003E1EBA File Offset: 0x003E00BA
		// (set) Token: 0x0600E753 RID: 59219 RVA: 0x003E1EC2 File Offset: 0x003E00C2
		public string param3 { get; set; }

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600E754 RID: 59220 RVA: 0x003E1ECB File Offset: 0x003E00CB
		// (set) Token: 0x0600E755 RID: 59221 RVA: 0x003E1ED3 File Offset: 0x003E00D3
		public string param4 { get; set; }

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600E756 RID: 59222 RVA: 0x003E1EDC File Offset: 0x003E00DC
		// (set) Token: 0x0600E757 RID: 59223 RVA: 0x003E1EE4 File Offset: 0x003E00E4
		public string param5 { get; set; }

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600E758 RID: 59224 RVA: 0x003E1EED File Offset: 0x003E00ED
		// (set) Token: 0x0600E759 RID: 59225 RVA: 0x003E1EF5 File Offset: 0x003E00F5
		public float control { get; set; }

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600E75A RID: 59226 RVA: 0x003E1EFE File Offset: 0x003E00FE
		// (set) Token: 0x0600E75B RID: 59227 RVA: 0x003E1F06 File Offset: 0x003E0106
		public int id { get; set; }

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600E75C RID: 59228 RVA: 0x003E1F0F File Offset: 0x003E010F
		// (set) Token: 0x0600E75D RID: 59229 RVA: 0x003E1F17 File Offset: 0x003E0117
		public int logic { get; set; }

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x0600E75E RID: 59230 RVA: 0x003E1F20 File Offset: 0x003E0120
		// (set) Token: 0x0600E75F RID: 59231 RVA: 0x003E1F28 File Offset: 0x003E0128
		public int next { get; set; }

		// Token: 0x0600E760 RID: 59232 RVA: 0x003E1F34 File Offset: 0x003E0134
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
