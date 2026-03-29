using System;

namespace core.config
{
	// Token: 0x02002129 RID: 8489
	public class IAutoCardBuffWikiInfo : IConfigItem
	{
		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600FC14 RID: 64532 RVA: 0x0047C760 File Offset: 0x0047A960
		// (set) Token: 0x0600FC15 RID: 64533 RVA: 0x0047C768 File Offset: 0x0047A968
		public string picture { get; set; }

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600FC16 RID: 64534 RVA: 0x0047C771 File Offset: 0x0047A971
		// (set) Token: 0x0600FC17 RID: 64535 RVA: 0x0047C779 File Offset: 0x0047A979
		public int id { get; set; }

		// Token: 0x0600FC18 RID: 64536 RVA: 0x0047C782 File Offset: 0x0047A982
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.picture = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
