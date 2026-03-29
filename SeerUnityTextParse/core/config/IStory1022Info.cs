using System;

namespace core.config
{
	// Token: 0x020023BD RID: 9149
	public class IStory1022Info : IConfigItem
	{
		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0601190A RID: 71946 RVA: 0x0049FAA4 File Offset: 0x0049DCA4
		// (set) Token: 0x0601190B RID: 71947 RVA: 0x0049FAAC File Offset: 0x0049DCAC
		public string param1 { get; set; }

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0601190C RID: 71948 RVA: 0x0049FAB5 File Offset: 0x0049DCB5
		// (set) Token: 0x0601190D RID: 71949 RVA: 0x0049FABD File Offset: 0x0049DCBD
		public string param2 { get; set; }

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0601190E RID: 71950 RVA: 0x0049FAC6 File Offset: 0x0049DCC6
		// (set) Token: 0x0601190F RID: 71951 RVA: 0x0049FACE File Offset: 0x0049DCCE
		public string param3 { get; set; }

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06011910 RID: 71952 RVA: 0x0049FAD7 File Offset: 0x0049DCD7
		// (set) Token: 0x06011911 RID: 71953 RVA: 0x0049FADF File Offset: 0x0049DCDF
		public string param4 { get; set; }

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06011912 RID: 71954 RVA: 0x0049FAE8 File Offset: 0x0049DCE8
		// (set) Token: 0x06011913 RID: 71955 RVA: 0x0049FAF0 File Offset: 0x0049DCF0
		public string param5 { get; set; }

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06011914 RID: 71956 RVA: 0x0049FAF9 File Offset: 0x0049DCF9
		// (set) Token: 0x06011915 RID: 71957 RVA: 0x0049FB01 File Offset: 0x0049DD01
		public float control { get; set; }

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06011916 RID: 71958 RVA: 0x0049FB0A File Offset: 0x0049DD0A
		// (set) Token: 0x06011917 RID: 71959 RVA: 0x0049FB12 File Offset: 0x0049DD12
		public int id { get; set; }

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06011918 RID: 71960 RVA: 0x0049FB1B File Offset: 0x0049DD1B
		// (set) Token: 0x06011919 RID: 71961 RVA: 0x0049FB23 File Offset: 0x0049DD23
		public int logic { get; set; }

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0601191A RID: 71962 RVA: 0x0049FB2C File Offset: 0x0049DD2C
		// (set) Token: 0x0601191B RID: 71963 RVA: 0x0049FB34 File Offset: 0x0049DD34
		public int next { get; set; }

		// Token: 0x0601191C RID: 71964 RVA: 0x0049FB40 File Offset: 0x0049DD40
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
