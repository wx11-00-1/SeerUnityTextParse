using System;

namespace core.config
{
	// Token: 0x02002155 RID: 8533
	public class IAwakentaskInfo : IConfigItem
	{
		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600FDD4 RID: 64980 RVA: 0x0047E81C File Offset: 0x0047CA1C
		// (set) Token: 0x0600FDD5 RID: 64981 RVA: 0x0047E824 File Offset: 0x0047CA24
		public string des { get; set; }

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600FDD6 RID: 64982 RVA: 0x0047E82D File Offset: 0x0047CA2D
		// (set) Token: 0x0600FDD7 RID: 64983 RVA: 0x0047E835 File Offset: 0x0047CA35
		public string finishrecordinfo { get; set; }

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600FDD8 RID: 64984 RVA: 0x0047E83E File Offset: 0x0047CA3E
		// (set) Token: 0x0600FDD9 RID: 64985 RVA: 0x0047E846 File Offset: 0x0047CA46
		public string limitrewardinfo { get; set; }

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600FDDA RID: 64986 RVA: 0x0047E84F File Offset: 0x0047CA4F
		// (set) Token: 0x0600FDDB RID: 64987 RVA: 0x0047E857 File Offset: 0x0047CA57
		public string rewardinfo { get; set; }

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x0600FDDC RID: 64988 RVA: 0x0047E860 File Offset: 0x0047CA60
		// (set) Token: 0x0600FDDD RID: 64989 RVA: 0x0047E868 File Offset: 0x0047CA68
		public string taskparam { get; set; }

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x0600FDDE RID: 64990 RVA: 0x0047E871 File Offset: 0x0047CA71
		// (set) Token: 0x0600FDDF RID: 64991 RVA: 0x0047E879 File Offset: 0x0047CA79
		public int id { get; set; }

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x0600FDE0 RID: 64992 RVA: 0x0047E882 File Offset: 0x0047CA82
		// (set) Token: 0x0600FDE1 RID: 64993 RVA: 0x0047E88A File Offset: 0x0047CA8A
		public int NewStatLog { get; set; }

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600FDE2 RID: 64994 RVA: 0x0047E893 File Offset: 0x0047CA93
		// (set) Token: 0x0600FDE3 RID: 64995 RVA: 0x0047E89B File Offset: 0x0047CA9B
		public int tasktype { get; set; }

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600FDE4 RID: 64996 RVA: 0x0047E8A4 File Offset: 0x0047CAA4
		// (set) Token: 0x0600FDE5 RID: 64997 RVA: 0x0047E8AC File Offset: 0x0047CAAC
		public int value { get; set; }

		// Token: 0x0600FDE6 RID: 64998 RVA: 0x0047E8B8 File Offset: 0x0047CAB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewStatLog = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.finishrecordinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitrewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
