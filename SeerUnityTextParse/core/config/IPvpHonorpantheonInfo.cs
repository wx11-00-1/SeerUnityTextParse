using System;

namespace core.config
{
	// Token: 0x02001DE0 RID: 7648
	public class IPvpHonorpantheonInfo : IConfigItem
	{
		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600E168 RID: 57704 RVA: 0x003DA804 File Offset: 0x003D8A04
		// (set) Token: 0x0600E169 RID: 57705 RVA: 0x003DA80C File Offset: 0x003D8A0C
		public string img { get; set; }

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600E16A RID: 57706 RVA: 0x003DA815 File Offset: 0x003D8A15
		// (set) Token: 0x0600E16B RID: 57707 RVA: 0x003DA81D File Offset: 0x003D8A1D
		public string name { get; set; }

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600E16C RID: 57708 RVA: 0x003DA826 File Offset: 0x003D8A26
		// (set) Token: 0x0600E16D RID: 57709 RVA: 0x003DA82E File Offset: 0x003D8A2E
		public int id { get; set; }

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x0600E16E RID: 57710 RVA: 0x003DA837 File Offset: 0x003D8A37
		// (set) Token: 0x0600E16F RID: 57711 RVA: 0x003DA83F File Offset: 0x003D8A3F
		public int suit { get; set; }

		// Token: 0x0600E170 RID: 57712 RVA: 0x003DA848 File Offset: 0x003D8A48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.img = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
