using System;

namespace core.config
{
	// Token: 0x02001E4C RID: 7756
	public class IStory1003Info : IConfigItem
	{
		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600E616 RID: 58902 RVA: 0x003E07A4 File Offset: 0x003DE9A4
		// (set) Token: 0x0600E617 RID: 58903 RVA: 0x003E07AC File Offset: 0x003DE9AC
		public string param1 { get; set; }

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600E618 RID: 58904 RVA: 0x003E07B5 File Offset: 0x003DE9B5
		// (set) Token: 0x0600E619 RID: 58905 RVA: 0x003E07BD File Offset: 0x003DE9BD
		public string param2 { get; set; }

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600E61A RID: 58906 RVA: 0x003E07C6 File Offset: 0x003DE9C6
		// (set) Token: 0x0600E61B RID: 58907 RVA: 0x003E07CE File Offset: 0x003DE9CE
		public string param3 { get; set; }

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600E61C RID: 58908 RVA: 0x003E07D7 File Offset: 0x003DE9D7
		// (set) Token: 0x0600E61D RID: 58909 RVA: 0x003E07DF File Offset: 0x003DE9DF
		public string param4 { get; set; }

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600E61E RID: 58910 RVA: 0x003E07E8 File Offset: 0x003DE9E8
		// (set) Token: 0x0600E61F RID: 58911 RVA: 0x003E07F0 File Offset: 0x003DE9F0
		public string param5 { get; set; }

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x0600E620 RID: 58912 RVA: 0x003E07F9 File Offset: 0x003DE9F9
		// (set) Token: 0x0600E621 RID: 58913 RVA: 0x003E0801 File Offset: 0x003DEA01
		public float control { get; set; }

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600E622 RID: 58914 RVA: 0x003E080A File Offset: 0x003DEA0A
		// (set) Token: 0x0600E623 RID: 58915 RVA: 0x003E0812 File Offset: 0x003DEA12
		public int id { get; set; }

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x0600E624 RID: 58916 RVA: 0x003E081B File Offset: 0x003DEA1B
		// (set) Token: 0x0600E625 RID: 58917 RVA: 0x003E0823 File Offset: 0x003DEA23
		public int logic { get; set; }

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600E626 RID: 58918 RVA: 0x003E082C File Offset: 0x003DEA2C
		// (set) Token: 0x0600E627 RID: 58919 RVA: 0x003E0834 File Offset: 0x003DEA34
		public int next { get; set; }

		// Token: 0x0600E628 RID: 58920 RVA: 0x003E0840 File Offset: 0x003DEA40
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
