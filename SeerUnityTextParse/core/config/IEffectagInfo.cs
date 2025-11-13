using System;

namespace core.config
{
	// Token: 0x02001D3C RID: 7484
	public class IEffectagInfo : IConfigItem
	{
		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600DAC0 RID: 56000 RVA: 0x003D21D0 File Offset: 0x003D03D0
		// (set) Token: 0x0600DAC1 RID: 56001 RVA: 0x003D21D8 File Offset: 0x003D03D8
		public string tag { get; set; }

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600DAC2 RID: 56002 RVA: 0x003D21E1 File Offset: 0x003D03E1
		// (set) Token: 0x0600DAC3 RID: 56003 RVA: 0x003D21E9 File Offset: 0x003D03E9
		public int id { get; set; }

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x003D21F2 File Offset: 0x003D03F2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
