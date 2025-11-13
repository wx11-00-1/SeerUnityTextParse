using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF1 RID: 7921
	public class IDetail
	{
		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600ED1A RID: 60698 RVA: 0x003F0DFE File Offset: 0x003EEFFE
		// (set) Token: 0x0600ED1B RID: 60699 RVA: 0x003F0E06 File Offset: 0x003EF006
		public string desc { get; set; }

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x003F0E0F File Offset: 0x003EF00F
		// (set) Token: 0x0600ED1D RID: 60701 RVA: 0x003F0E17 File Offset: 0x003EF017
		public string reward { get; set; }

		// Token: 0x0600ED1E RID: 60702 RVA: 0x003F0E20 File Offset: 0x003EF020
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
