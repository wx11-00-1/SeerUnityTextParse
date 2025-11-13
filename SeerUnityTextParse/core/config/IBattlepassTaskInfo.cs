using System;

namespace core.config
{
	// Token: 0x02001CC0 RID: 7360
	public class IBattlepassTaskInfo : IConfigItem
	{
		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x0600D582 RID: 54658 RVA: 0x003CBCC4 File Offset: 0x003C9EC4
		// (set) Token: 0x0600D583 RID: 54659 RVA: 0x003CBCCC File Offset: 0x003C9ECC
		public string describe { get; set; }

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x0600D584 RID: 54660 RVA: 0x003CBCD5 File Offset: 0x003C9ED5
		// (set) Token: 0x0600D585 RID: 54661 RVA: 0x003CBCDD File Offset: 0x003C9EDD
		public string timeend { get; set; }

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x003CBCE6 File Offset: 0x003C9EE6
		// (set) Token: 0x0600D587 RID: 54663 RVA: 0x003CBCEE File Offset: 0x003C9EEE
		public string timelimit { get; set; }

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x0600D588 RID: 54664 RVA: 0x003CBCF7 File Offset: 0x003C9EF7
		// (set) Token: 0x0600D589 RID: 54665 RVA: 0x003CBCFF File Offset: 0x003C9EFF
		public string timestart { get; set; }

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600D58A RID: 54666 RVA: 0x003CBD08 File Offset: 0x003C9F08
		// (set) Token: 0x0600D58B RID: 54667 RVA: 0x003CBD10 File Offset: 0x003C9F10
		public int exp { get; set; }

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600D58C RID: 54668 RVA: 0x003CBD19 File Offset: 0x003C9F19
		// (set) Token: 0x0600D58D RID: 54669 RVA: 0x003CBD21 File Offset: 0x003C9F21
		public int id { get; set; }

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600D58E RID: 54670 RVA: 0x003CBD2A File Offset: 0x003C9F2A
		// (set) Token: 0x0600D58F RID: 54671 RVA: 0x003CBD32 File Offset: 0x003C9F32
		public int time { get; set; }

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600D590 RID: 54672 RVA: 0x003CBD3B File Offset: 0x003C9F3B
		// (set) Token: 0x0600D591 RID: 54673 RVA: 0x003CBD43 File Offset: 0x003C9F43
		public int userinfo { get; set; }

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600D592 RID: 54674 RVA: 0x003CBD4C File Offset: 0x003C9F4C
		// (set) Token: 0x0600D593 RID: 54675 RVA: 0x003CBD54 File Offset: 0x003C9F54
		public int value { get; set; }

		// Token: 0x0600D594 RID: 54676 RVA: 0x003CBD60 File Offset: 0x003C9F60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
