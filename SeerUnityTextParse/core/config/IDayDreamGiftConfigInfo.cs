using System;

namespace core.config
{
	// Token: 0x02002661 RID: 9825
	public class IDayDreamGiftConfigInfo : IConfigItem
	{
		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06013443 RID: 78915 RVA: 0x00553100 File Offset: 0x00551300
		// (set) Token: 0x06013444 RID: 78916 RVA: 0x00553108 File Offset: 0x00551308
		public string icon { get; set; }

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06013445 RID: 78917 RVA: 0x00553111 File Offset: 0x00551311
		// (set) Token: 0x06013446 RID: 78918 RVA: 0x00553119 File Offset: 0x00551319
		public string name { get; set; }

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06013447 RID: 78919 RVA: 0x00553122 File Offset: 0x00551322
		// (set) Token: 0x06013448 RID: 78920 RVA: 0x0055312A File Offset: 0x0055132A
		public int id { get; set; }

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06013449 RID: 78921 RVA: 0x00553133 File Offset: 0x00551333
		// (set) Token: 0x0601344A RID: 78922 RVA: 0x0055313B File Offset: 0x0055133B
		public int notA { get; set; }

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x0601344B RID: 78923 RVA: 0x00553144 File Offset: 0x00551344
		// (set) Token: 0x0601344C RID: 78924 RVA: 0x0055314C File Offset: 0x0055134C
		public int notB { get; set; }

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x0601344D RID: 78925 RVA: 0x00553155 File Offset: 0x00551355
		// (set) Token: 0x0601344E RID: 78926 RVA: 0x0055315D File Offset: 0x0055135D
		public int notC { get; set; }

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x0601344F RID: 78927 RVA: 0x00553166 File Offset: 0x00551366
		// (set) Token: 0x06013450 RID: 78928 RVA: 0x0055316E File Offset: 0x0055136E
		public int toA { get; set; }

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06013451 RID: 78929 RVA: 0x00553177 File Offset: 0x00551377
		// (set) Token: 0x06013452 RID: 78930 RVA: 0x0055317F File Offset: 0x0055137F
		public int toB { get; set; }

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06013453 RID: 78931 RVA: 0x00553188 File Offset: 0x00551388
		// (set) Token: 0x06013454 RID: 78932 RVA: 0x00553190 File Offset: 0x00551390
		public int toC { get; set; }

		// Token: 0x06013455 RID: 78933 RVA: 0x0055319C File Offset: 0x0055139C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.notA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.notB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.notC = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.toA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.toB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.toC = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
