using System;

namespace core.config
{
	// Token: 0x02001D2E RID: 7470
	public class IDeepSeaMapInfo : IConfigItem
	{
		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600DA36 RID: 55862 RVA: 0x003D1748 File Offset: 0x003CF948
		// (set) Token: 0x0600DA37 RID: 55863 RVA: 0x003D1750 File Offset: 0x003CF950
		public string isBlack { get; set; }

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600DA38 RID: 55864 RVA: 0x003D1759 File Offset: 0x003CF959
		// (set) Token: 0x0600DA39 RID: 55865 RVA: 0x003D1761 File Offset: 0x003CF961
		public string room1Connection { get; set; }

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600DA3A RID: 55866 RVA: 0x003D176A File Offset: 0x003CF96A
		// (set) Token: 0x0600DA3B RID: 55867 RVA: 0x003D1772 File Offset: 0x003CF972
		public string room2Connection { get; set; }

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x003D177B File Offset: 0x003CF97B
		// (set) Token: 0x0600DA3D RID: 55869 RVA: 0x003D1783 File Offset: 0x003CF983
		public string room3Connection { get; set; }

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x003D178C File Offset: 0x003CF98C
		// (set) Token: 0x0600DA3F RID: 55871 RVA: 0x003D1794 File Offset: 0x003CF994
		public string room4Connection { get; set; }

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x0600DA40 RID: 55872 RVA: 0x003D179D File Offset: 0x003CF99D
		// (set) Token: 0x0600DA41 RID: 55873 RVA: 0x003D17A5 File Offset: 0x003CF9A5
		public string room5Connection { get; set; }

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x0600DA42 RID: 55874 RVA: 0x003D17AE File Offset: 0x003CF9AE
		// (set) Token: 0x0600DA43 RID: 55875 RVA: 0x003D17B6 File Offset: 0x003CF9B6
		public string room6Connection { get; set; }

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x0600DA44 RID: 55876 RVA: 0x003D17BF File Offset: 0x003CF9BF
		// (set) Token: 0x0600DA45 RID: 55877 RVA: 0x003D17C7 File Offset: 0x003CF9C7
		public string room7Connection { get; set; }

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x0600DA46 RID: 55878 RVA: 0x003D17D0 File Offset: 0x003CF9D0
		// (set) Token: 0x0600DA47 RID: 55879 RVA: 0x003D17D8 File Offset: 0x003CF9D8
		public int id { get; set; }

		// Token: 0x0600DA48 RID: 55880 RVA: 0x003D17E4 File Offset: 0x003CF9E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isBlack = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room1Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room2Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room3Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room4Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room5Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room6Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.room7Connection = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
