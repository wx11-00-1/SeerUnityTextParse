using System;

namespace core.config
{
	// Token: 0x02002135 RID: 8501
	public class IAutocardEffectIconDesInfo : IConfigItem
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600FC88 RID: 64648 RVA: 0x0047CFC0 File Offset: 0x0047B1C0
		// (set) Token: 0x0600FC89 RID: 64649 RVA: 0x0047CFC8 File Offset: 0x0047B1C8
		public string des { get; set; }

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600FC8A RID: 64650 RVA: 0x0047CFD1 File Offset: 0x0047B1D1
		// (set) Token: 0x0600FC8B RID: 64651 RVA: 0x0047CFD9 File Offset: 0x0047B1D9
		public string name { get; set; }

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600FC8C RID: 64652 RVA: 0x0047CFE2 File Offset: 0x0047B1E2
		// (set) Token: 0x0600FC8D RID: 64653 RVA: 0x0047CFEA File Offset: 0x0047B1EA
		public string resourceName { get; set; }

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600FC8E RID: 64654 RVA: 0x0047CFF3 File Offset: 0x0047B1F3
		// (set) Token: 0x0600FC8F RID: 64655 RVA: 0x0047CFFB File Offset: 0x0047B1FB
		public int id { get; set; }

		// Token: 0x0600FC90 RID: 64656 RVA: 0x0047D004 File Offset: 0x0047B204
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.resourceName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
