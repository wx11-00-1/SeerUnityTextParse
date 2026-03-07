using System;

namespace core.config
{
	// Token: 0x02002111 RID: 8465
	public class IStory1015Info : IConfigItem
	{
		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x060101B8 RID: 65976 RVA: 0x00448804 File Offset: 0x00446A04
		// (set) Token: 0x060101B9 RID: 65977 RVA: 0x0044880C File Offset: 0x00446A0C
		public string param1 { get; set; }

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x060101BA RID: 65978 RVA: 0x00448815 File Offset: 0x00446A15
		// (set) Token: 0x060101BB RID: 65979 RVA: 0x0044881D File Offset: 0x00446A1D
		public string param2 { get; set; }

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x060101BC RID: 65980 RVA: 0x00448826 File Offset: 0x00446A26
		// (set) Token: 0x060101BD RID: 65981 RVA: 0x0044882E File Offset: 0x00446A2E
		public string param3 { get; set; }

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x060101BE RID: 65982 RVA: 0x00448837 File Offset: 0x00446A37
		// (set) Token: 0x060101BF RID: 65983 RVA: 0x0044883F File Offset: 0x00446A3F
		public string param4 { get; set; }

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x060101C0 RID: 65984 RVA: 0x00448848 File Offset: 0x00446A48
		// (set) Token: 0x060101C1 RID: 65985 RVA: 0x00448850 File Offset: 0x00446A50
		public string param5 { get; set; }

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x060101C2 RID: 65986 RVA: 0x00448859 File Offset: 0x00446A59
		// (set) Token: 0x060101C3 RID: 65987 RVA: 0x00448861 File Offset: 0x00446A61
		public float control { get; set; }

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x060101C4 RID: 65988 RVA: 0x0044886A File Offset: 0x00446A6A
		// (set) Token: 0x060101C5 RID: 65989 RVA: 0x00448872 File Offset: 0x00446A72
		public int id { get; set; }

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x060101C6 RID: 65990 RVA: 0x0044887B File Offset: 0x00446A7B
		// (set) Token: 0x060101C7 RID: 65991 RVA: 0x00448883 File Offset: 0x00446A83
		public int logic { get; set; }

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x060101C8 RID: 65992 RVA: 0x0044888C File Offset: 0x00446A8C
		// (set) Token: 0x060101C9 RID: 65993 RVA: 0x00448894 File Offset: 0x00446A94
		public int next { get; set; }

		// Token: 0x060101CA RID: 65994 RVA: 0x004488A0 File Offset: 0x00446AA0
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
