using System;

namespace core.config
{
	// Token: 0x02001E0C RID: 7692
	public class ISecurityCheckDayInfo : IConfigItem
	{
		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x0600E34A RID: 58186 RVA: 0x003DCE80 File Offset: 0x003DB080
		// (set) Token: 0x0600E34B RID: 58187 RVA: 0x003DCE88 File Offset: 0x003DB088
		public string rules { get; set; }

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x0600E34C RID: 58188 RVA: 0x003DCE91 File Offset: 0x003DB091
		// (set) Token: 0x0600E34D RID: 58189 RVA: 0x003DCE99 File Offset: 0x003DB099
		public string words { get; set; }

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x0600E34E RID: 58190 RVA: 0x003DCEA2 File Offset: 0x003DB0A2
		// (set) Token: 0x0600E34F RID: 58191 RVA: 0x003DCEAA File Offset: 0x003DB0AA
		public int id { get; set; }

		// Token: 0x0600E350 RID: 58192 RVA: 0x003DCEB3 File Offset: 0x003DB0B3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rules = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.words = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
