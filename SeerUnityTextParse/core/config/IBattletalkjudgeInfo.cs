using System;

namespace core.config
{
	// Token: 0x02001CC6 RID: 7366
	public class IBattletalkjudgeInfo : IConfigItem
	{
		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x0600D5C8 RID: 54728 RVA: 0x003CC1C4 File Offset: 0x003CA3C4
		// (set) Token: 0x0600D5C9 RID: 54729 RVA: 0x003CC1CC File Offset: 0x003CA3CC
		public int battleid { get; set; }

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600D5CA RID: 54730 RVA: 0x003CC1D5 File Offset: 0x003CA3D5
		// (set) Token: 0x0600D5CB RID: 54731 RVA: 0x003CC1DD File Offset: 0x003CA3DD
		public int id { get; set; }

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x003CC1E6 File Offset: 0x003CA3E6
		// (set) Token: 0x0600D5CD RID: 54733 RVA: 0x003CC1EE File Offset: 0x003CA3EE
		public int judge { get; set; }

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x003CC1F7 File Offset: 0x003CA3F7
		// (set) Token: 0x0600D5CF RID: 54735 RVA: 0x003CC1FF File Offset: 0x003CA3FF
		public float param1 { get; set; }

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x003CC208 File Offset: 0x003CA408
		// (set) Token: 0x0600D5D1 RID: 54737 RVA: 0x003CC210 File Offset: 0x003CA410
		public int param2 { get; set; }

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x003CC219 File Offset: 0x003CA419
		// (set) Token: 0x0600D5D3 RID: 54739 RVA: 0x003CC221 File Offset: 0x003CA421
		public int rank { get; set; }

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x003CC22A File Offset: 0x003CA42A
		// (set) Token: 0x0600D5D5 RID: 54741 RVA: 0x003CC232 File Offset: 0x003CA432
		public int repeat { get; set; }

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x003CC23B File Offset: 0x003CA43B
		// (set) Token: 0x0600D5D7 RID: 54743 RVA: 0x003CC243 File Offset: 0x003CA443
		public int talkid { get; set; }

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x003CC24C File Offset: 0x003CA44C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battleid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.judge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.param2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.repeat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.talkid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
