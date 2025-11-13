using System;

namespace core.config
{
	// Token: 0x02001D2C RID: 7468
	public class IDeepSeaDropInfo : IConfigItem
	{
		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x003D1630 File Offset: 0x003CF830
		// (set) Token: 0x0600DA29 RID: 55849 RVA: 0x003D1638 File Offset: 0x003CF838
		public string iconName { get; set; }

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x0600DA2A RID: 55850 RVA: 0x003D1641 File Offset: 0x003CF841
		// (set) Token: 0x0600DA2B RID: 55851 RVA: 0x003D1649 File Offset: 0x003CF849
		public string name { get; set; }

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600DA2C RID: 55852 RVA: 0x003D1652 File Offset: 0x003CF852
		// (set) Token: 0x0600DA2D RID: 55853 RVA: 0x003D165A File Offset: 0x003CF85A
		public int id { get; set; }

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x0600DA2E RID: 55854 RVA: 0x003D1663 File Offset: 0x003CF863
		// (set) Token: 0x0600DA2F RID: 55855 RVA: 0x003D166B File Offset: 0x003CF86B
		public int value { get; set; }

		// Token: 0x0600DA30 RID: 55856 RVA: 0x003D1674 File Offset: 0x003CF874
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.iconName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
