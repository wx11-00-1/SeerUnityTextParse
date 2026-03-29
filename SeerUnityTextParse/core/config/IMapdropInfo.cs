using System;

namespace core.config
{
	// Token: 0x020022AD RID: 8877
	public class IMapdropInfo : IConfigItem
	{
		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06010CE4 RID: 68836 RVA: 0x004909C0 File Offset: 0x0048EBC0
		// (set) Token: 0x06010CE5 RID: 68837 RVA: 0x004909C8 File Offset: 0x0048EBC8
		public string activitydrop { get; set; }

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06010CE6 RID: 68838 RVA: 0x004909D1 File Offset: 0x0048EBD1
		// (set) Token: 0x06010CE7 RID: 68839 RVA: 0x004909D9 File Offset: 0x0048EBD9
		public string activitylimit { get; set; }

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06010CE8 RID: 68840 RVA: 0x004909E2 File Offset: 0x0048EBE2
		// (set) Token: 0x06010CE9 RID: 68841 RVA: 0x004909EA File Offset: 0x0048EBEA
		public string drop { get; set; }

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06010CEA RID: 68842 RVA: 0x004909F3 File Offset: 0x0048EBF3
		// (set) Token: 0x06010CEB RID: 68843 RVA: 0x004909FB File Offset: 0x0048EBFB
		public string limit { get; set; }

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06010CEC RID: 68844 RVA: 0x00490A04 File Offset: 0x0048EC04
		// (set) Token: 0x06010CED RID: 68845 RVA: 0x00490A0C File Offset: 0x0048EC0C
		public int activityid { get; set; }

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06010CEE RID: 68846 RVA: 0x00490A15 File Offset: 0x0048EC15
		// (set) Token: 0x06010CEF RID: 68847 RVA: 0x00490A1D File Offset: 0x0048EC1D
		public int id { get; set; }

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06010CF0 RID: 68848 RVA: 0x00490A26 File Offset: 0x0048EC26
		// (set) Token: 0x06010CF1 RID: 68849 RVA: 0x00490A2E File Offset: 0x0048EC2E
		public int mapid { get; set; }

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06010CF2 RID: 68850 RVA: 0x00490A37 File Offset: 0x0048EC37
		// (set) Token: 0x06010CF3 RID: 68851 RVA: 0x00490A3F File Offset: 0x0048EC3F
		public int monster { get; set; }

		// Token: 0x06010CF4 RID: 68852 RVA: 0x00490A48 File Offset: 0x0048EC48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activitydrop = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.activityid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.activitylimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.drop = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.mapid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
