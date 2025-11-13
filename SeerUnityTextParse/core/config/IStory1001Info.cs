using System;

namespace core.config
{
	// Token: 0x02001E48 RID: 7752
	public class IStory1001Info : IConfigItem
	{
		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x003E041C File Offset: 0x003DE61C
		// (set) Token: 0x0600E5E7 RID: 58855 RVA: 0x003E0424 File Offset: 0x003DE624
		public string param1 { get; set; }

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x003E042D File Offset: 0x003DE62D
		// (set) Token: 0x0600E5E9 RID: 58857 RVA: 0x003E0435 File Offset: 0x003DE635
		public string param2 { get; set; }

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x0600E5EA RID: 58858 RVA: 0x003E043E File Offset: 0x003DE63E
		// (set) Token: 0x0600E5EB RID: 58859 RVA: 0x003E0446 File Offset: 0x003DE646
		public string param3 { get; set; }

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x003E044F File Offset: 0x003DE64F
		// (set) Token: 0x0600E5ED RID: 58861 RVA: 0x003E0457 File Offset: 0x003DE657
		public string param4 { get; set; }

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600E5EE RID: 58862 RVA: 0x003E0460 File Offset: 0x003DE660
		// (set) Token: 0x0600E5EF RID: 58863 RVA: 0x003E0468 File Offset: 0x003DE668
		public string param5 { get; set; }

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x0600E5F0 RID: 58864 RVA: 0x003E0471 File Offset: 0x003DE671
		// (set) Token: 0x0600E5F1 RID: 58865 RVA: 0x003E0479 File Offset: 0x003DE679
		public float control { get; set; }

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x0600E5F2 RID: 58866 RVA: 0x003E0482 File Offset: 0x003DE682
		// (set) Token: 0x0600E5F3 RID: 58867 RVA: 0x003E048A File Offset: 0x003DE68A
		public int id { get; set; }

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600E5F4 RID: 58868 RVA: 0x003E0493 File Offset: 0x003DE693
		// (set) Token: 0x0600E5F5 RID: 58869 RVA: 0x003E049B File Offset: 0x003DE69B
		public int logic { get; set; }

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x0600E5F6 RID: 58870 RVA: 0x003E04A4 File Offset: 0x003DE6A4
		// (set) Token: 0x0600E5F7 RID: 58871 RVA: 0x003E04AC File Offset: 0x003DE6AC
		public int next { get; set; }

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x003E04B8 File Offset: 0x003DE6B8
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
