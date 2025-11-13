using System;

namespace core.config
{
	// Token: 0x02001DDE RID: 7646
	public class IPvpExpertSeasonrankInfo : IConfigItem
	{
		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x0600E14C RID: 57676 RVA: 0x003DA620 File Offset: 0x003D8820
		// (set) Token: 0x0600E14D RID: 57677 RVA: 0x003DA628 File Offset: 0x003D8828
		public string time { get; set; }

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600E14E RID: 57678 RVA: 0x003DA631 File Offset: 0x003D8831
		// (set) Token: 0x0600E14F RID: 57679 RVA: 0x003DA639 File Offset: 0x003D8839
		public int account1 { get; set; }

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x0600E150 RID: 57680 RVA: 0x003DA642 File Offset: 0x003D8842
		// (set) Token: 0x0600E151 RID: 57681 RVA: 0x003DA64A File Offset: 0x003D884A
		public int account2 { get; set; }

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600E152 RID: 57682 RVA: 0x003DA653 File Offset: 0x003D8853
		// (set) Token: 0x0600E153 RID: 57683 RVA: 0x003DA65B File Offset: 0x003D885B
		public int account3 { get; set; }

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x0600E154 RID: 57684 RVA: 0x003DA664 File Offset: 0x003D8864
		// (set) Token: 0x0600E155 RID: 57685 RVA: 0x003DA66C File Offset: 0x003D886C
		public int id { get; set; }

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600E156 RID: 57686 RVA: 0x003DA675 File Offset: 0x003D8875
		// (set) Token: 0x0600E157 RID: 57687 RVA: 0x003DA67D File Offset: 0x003D887D
		public int score1 { get; set; }

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x0600E158 RID: 57688 RVA: 0x003DA686 File Offset: 0x003D8886
		// (set) Token: 0x0600E159 RID: 57689 RVA: 0x003DA68E File Offset: 0x003D888E
		public int score2 { get; set; }

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x0600E15A RID: 57690 RVA: 0x003DA697 File Offset: 0x003D8897
		// (set) Token: 0x0600E15B RID: 57691 RVA: 0x003DA69F File Offset: 0x003D889F
		public int score3 { get; set; }

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x003DA6A8 File Offset: 0x003D88A8
		// (set) Token: 0x0600E15D RID: 57693 RVA: 0x003DA6B0 File Offset: 0x003D88B0
		public int winrate1 { get; set; }

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x0600E15E RID: 57694 RVA: 0x003DA6B9 File Offset: 0x003D88B9
		// (set) Token: 0x0600E15F RID: 57695 RVA: 0x003DA6C1 File Offset: 0x003D88C1
		public int winrate2 { get; set; }

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x003DA6CA File Offset: 0x003D88CA
		// (set) Token: 0x0600E161 RID: 57697 RVA: 0x003DA6D2 File Offset: 0x003D88D2
		public int winrate3 { get; set; }

		// Token: 0x0600E162 RID: 57698 RVA: 0x003DA6DC File Offset: 0x003D88DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.account1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.account2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.account3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.score1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.score2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.score3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.winrate1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.winrate2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.winrate3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
