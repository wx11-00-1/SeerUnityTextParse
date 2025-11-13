using System;

namespace core.config.error_code_analysis
{
	// Token: 0x0200203D RID: 8253
	public class IErrorpostItem : IConfigItem
	{
		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600FC0D RID: 64525 RVA: 0x00401780 File Offset: 0x003FF980
		// (set) Token: 0x0600FC0E RID: 64526 RVA: 0x00401788 File Offset: 0x003FF988
		public int @event { get; set; }

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600FC0F RID: 64527 RVA: 0x00401791 File Offset: 0x003FF991
		// (set) Token: 0x0600FC10 RID: 64528 RVA: 0x00401799 File Offset: 0x003FF999
		public int id { get; set; }

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600FC11 RID: 64529 RVA: 0x004017A2 File Offset: 0x003FF9A2
		// (set) Token: 0x0600FC12 RID: 64530 RVA: 0x004017AA File Offset: 0x003FF9AA
		public string tx { get; set; }

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600FC13 RID: 64531 RVA: 0x004017B3 File Offset: 0x003FF9B3
		// (set) Token: 0x0600FC14 RID: 64532 RVA: 0x004017BB File Offset: 0x003FF9BB
		public int txType { get; set; }

		// Token: 0x0600FC15 RID: 64533 RVA: 0x004017C4 File Offset: 0x003FF9C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@event = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tx = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.txType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
