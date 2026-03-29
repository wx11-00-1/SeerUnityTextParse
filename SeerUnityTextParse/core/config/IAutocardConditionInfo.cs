using System;

namespace core.config
{
	// Token: 0x0200212D RID: 8493
	public class IAutocardConditionInfo : IConfigItem
	{
		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600FC2A RID: 64554 RVA: 0x0047C918 File Offset: 0x0047AB18
		// (set) Token: 0x0600FC2B RID: 64555 RVA: 0x0047C920 File Offset: 0x0047AB20
		public string param { get; set; }

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600FC2C RID: 64556 RVA: 0x0047C929 File Offset: 0x0047AB29
		// (set) Token: 0x0600FC2D RID: 64557 RVA: 0x0047C931 File Offset: 0x0047AB31
		public string paramDes { get; set; }

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x0600FC2E RID: 64558 RVA: 0x0047C93A File Offset: 0x0047AB3A
		// (set) Token: 0x0600FC2F RID: 64559 RVA: 0x0047C942 File Offset: 0x0047AB42
		public int id { get; set; }

		// Token: 0x0600FC30 RID: 64560 RVA: 0x0047C94B File Offset: 0x0047AB4B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paramDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
