using System;

namespace core.config
{
	// Token: 0x02001EFF RID: 7935
	public class IBagTowerStageInfo : IConfigItem
	{
		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600EAE6 RID: 60134 RVA: 0x0042C748 File Offset: 0x0042A948
		// (set) Token: 0x0600EAE7 RID: 60135 RVA: 0x0042C750 File Offset: 0x0042A950
		public string name { get; set; }

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600EAE8 RID: 60136 RVA: 0x0042C759 File Offset: 0x0042A959
		// (set) Token: 0x0600EAE9 RID: 60137 RVA: 0x0042C761 File Offset: 0x0042A961
		public int bg { get; set; }

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x0600EAEA RID: 60138 RVA: 0x0042C76A File Offset: 0x0042A96A
		// (set) Token: 0x0600EAEB RID: 60139 RVA: 0x0042C772 File Offset: 0x0042A972
		public int id { get; set; }

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x0600EAEC RID: 60140 RVA: 0x0042C77B File Offset: 0x0042A97B
		// (set) Token: 0x0600EAED RID: 60141 RVA: 0x0042C783 File Offset: 0x0042A983
		public int initialcoin { get; set; }

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x0600EAEE RID: 60142 RVA: 0x0042C78C File Offset: 0x0042A98C
		// (set) Token: 0x0600EAEF RID: 60143 RVA: 0x0042C794 File Offset: 0x0042A994
		public int lockequip { get; set; }

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x0600EAF0 RID: 60144 RVA: 0x0042C79D File Offset: 0x0042A99D
		// (set) Token: 0x0600EAF1 RID: 60145 RVA: 0x0042C7A5 File Offset: 0x0042A9A5
		public int stagetype { get; set; }

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600EAF2 RID: 60146 RVA: 0x0042C7AE File Offset: 0x0042A9AE
		// (set) Token: 0x0600EAF3 RID: 60147 RVA: 0x0042C7B6 File Offset: 0x0042A9B6
		public int time { get; set; }

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600EAF4 RID: 60148 RVA: 0x0042C7BF File Offset: 0x0042A9BF
		// (set) Token: 0x0600EAF5 RID: 60149 RVA: 0x0042C7C7 File Offset: 0x0042A9C7
		public int unlock { get; set; }

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600EAF6 RID: 60150 RVA: 0x0042C7D0 File Offset: 0x0042A9D0
		// (set) Token: 0x0600EAF7 RID: 60151 RVA: 0x0042C7D8 File Offset: 0x0042A9D8
		public int wavenum { get; set; }

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x0042C7E4 File Offset: 0x0042A9E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialcoin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lockequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wavenum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
