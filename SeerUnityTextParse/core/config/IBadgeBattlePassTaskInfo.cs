using System;

namespace core.config
{
	// Token: 0x02001CB4 RID: 7348
	public class IBadgeBattlePassTaskInfo : IConfigItem
	{
		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600D504 RID: 54532 RVA: 0x003CB3A4 File Offset: 0x003C95A4
		// (set) Token: 0x0600D505 RID: 54533 RVA: 0x003CB3AC File Offset: 0x003C95AC
		public string describe { get; set; }

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x003CB3B5 File Offset: 0x003C95B5
		// (set) Token: 0x0600D507 RID: 54535 RVA: 0x003CB3BD File Offset: 0x003C95BD
		public string timeend { get; set; }

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x003CB3C6 File Offset: 0x003C95C6
		// (set) Token: 0x0600D509 RID: 54537 RVA: 0x003CB3CE File Offset: 0x003C95CE
		public string timelimit { get; set; }

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x003CB3D7 File Offset: 0x003C95D7
		// (set) Token: 0x0600D50B RID: 54539 RVA: 0x003CB3DF File Offset: 0x003C95DF
		public string timestart { get; set; }

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x0600D50C RID: 54540 RVA: 0x003CB3E8 File Offset: 0x003C95E8
		// (set) Token: 0x0600D50D RID: 54541 RVA: 0x003CB3F0 File Offset: 0x003C95F0
		public int exp { get; set; }

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x003CB3F9 File Offset: 0x003C95F9
		// (set) Token: 0x0600D50F RID: 54543 RVA: 0x003CB401 File Offset: 0x003C9601
		public int go { get; set; }

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x0600D510 RID: 54544 RVA: 0x003CB40A File Offset: 0x003C960A
		// (set) Token: 0x0600D511 RID: 54545 RVA: 0x003CB412 File Offset: 0x003C9612
		public int id { get; set; }

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x0600D512 RID: 54546 RVA: 0x003CB41B File Offset: 0x003C961B
		// (set) Token: 0x0600D513 RID: 54547 RVA: 0x003CB423 File Offset: 0x003C9623
		public int time { get; set; }

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x0600D514 RID: 54548 RVA: 0x003CB42C File Offset: 0x003C962C
		// (set) Token: 0x0600D515 RID: 54549 RVA: 0x003CB434 File Offset: 0x003C9634
		public int userinfo { get; set; }

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x0600D516 RID: 54550 RVA: 0x003CB43D File Offset: 0x003C963D
		// (set) Token: 0x0600D517 RID: 54551 RVA: 0x003CB445 File Offset: 0x003C9645
		public int value { get; set; }

		// Token: 0x0600D518 RID: 54552 RVA: 0x003CB450 File Offset: 0x003C9650
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timeend = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timelimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timestart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
