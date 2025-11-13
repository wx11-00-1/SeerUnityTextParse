using System;

namespace core.config
{
	// Token: 0x02001CAA RID: 7338
	public class IAwakenbossconfigInfo : IConfigItem
	{
		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600D4A8 RID: 54440 RVA: 0x003CACDC File Offset: 0x003C8EDC
		// (set) Token: 0x0600D4A9 RID: 54441 RVA: 0x003CACE4 File Offset: 0x003C8EE4
		public int id { get; set; }

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600D4AA RID: 54442 RVA: 0x003CACED File Offset: 0x003C8EED
		// (set) Token: 0x0600D4AB RID: 54443 RVA: 0x003CACF5 File Offset: 0x003C8EF5
		public int monsterId { get; set; }

		// Token: 0x0600D4AC RID: 54444 RVA: 0x003CACFE File Offset: 0x003C8EFE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
