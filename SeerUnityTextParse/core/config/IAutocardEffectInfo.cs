using System;

namespace core.config
{
	// Token: 0x02002133 RID: 8499
	public class IAutocardEffectInfo : IConfigItem
	{
		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600FC7C RID: 64636 RVA: 0x0047CED0 File Offset: 0x0047B0D0
		// (set) Token: 0x0600FC7D RID: 64637 RVA: 0x0047CED8 File Offset: 0x0047B0D8
		public string param { get; set; }

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600FC7E RID: 64638 RVA: 0x0047CEE1 File Offset: 0x0047B0E1
		// (set) Token: 0x0600FC7F RID: 64639 RVA: 0x0047CEE9 File Offset: 0x0047B0E9
		public string paramDes { get; set; }

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x0600FC80 RID: 64640 RVA: 0x0047CEF2 File Offset: 0x0047B0F2
		// (set) Token: 0x0600FC81 RID: 64641 RVA: 0x0047CEFA File Offset: 0x0047B0FA
		public int id { get; set; }

		// Token: 0x0600FC82 RID: 64642 RVA: 0x0047CF03 File Offset: 0x0047B103
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paramDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
