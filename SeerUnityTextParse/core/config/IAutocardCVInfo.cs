using System;

namespace core.config
{
	// Token: 0x02002131 RID: 8497
	public class IAutocardCVInfo : IConfigItem
	{
		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600FC68 RID: 64616 RVA: 0x0047CD58 File Offset: 0x0047AF58
		// (set) Token: 0x0600FC69 RID: 64617 RVA: 0x0047CD60 File Offset: 0x0047AF60
		public string actName { get; set; }

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600FC6A RID: 64618 RVA: 0x0047CD69 File Offset: 0x0047AF69
		// (set) Token: 0x0600FC6B RID: 64619 RVA: 0x0047CD71 File Offset: 0x0047AF71
		public string name { get; set; }

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600FC6C RID: 64620 RVA: 0x0047CD7A File Offset: 0x0047AF7A
		// (set) Token: 0x0600FC6D RID: 64621 RVA: 0x0047CD82 File Offset: 0x0047AF82
		public string sceneApply { get; set; }

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600FC6E RID: 64622 RVA: 0x0047CD8B File Offset: 0x0047AF8B
		// (set) Token: 0x0600FC6F RID: 64623 RVA: 0x0047CD93 File Offset: 0x0047AF93
		public int id { get; set; }

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600FC70 RID: 64624 RVA: 0x0047CD9C File Offset: 0x0047AF9C
		// (set) Token: 0x0600FC71 RID: 64625 RVA: 0x0047CDA4 File Offset: 0x0047AFA4
		public int probability { get; set; }

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x0600FC72 RID: 64626 RVA: 0x0047CDAD File Offset: 0x0047AFAD
		// (set) Token: 0x0600FC73 RID: 64627 RVA: 0x0047CDB5 File Offset: 0x0047AFB5
		public int useID { get; set; }

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x0600FC74 RID: 64628 RVA: 0x0047CDBE File Offset: 0x0047AFBE
		// (set) Token: 0x0600FC75 RID: 64629 RVA: 0x0047CDC6 File Offset: 0x0047AFC6
		public int useType { get; set; }

		// Token: 0x0600FC76 RID: 64630 RVA: 0x0047CDD0 File Offset: 0x0047AFD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.actName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.probability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sceneApply = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.useID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.useType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
