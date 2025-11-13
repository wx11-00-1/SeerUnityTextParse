using System;

namespace core.config
{
	// Token: 0x02001D2A RID: 7466
	public class IDeepSeaComponentInfo : IConfigItem
	{
		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x003D1498 File Offset: 0x003CF698
		// (set) Token: 0x0600DA13 RID: 55827 RVA: 0x003D14A0 File Offset: 0x003CF6A0
		public string monsterTxt { get; set; }

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x003D14A9 File Offset: 0x003CF6A9
		// (set) Token: 0x0600DA15 RID: 55829 RVA: 0x003D14B1 File Offset: 0x003CF6B1
		public string rewardDrop { get; set; }

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x003D14BA File Offset: 0x003CF6BA
		// (set) Token: 0x0600DA17 RID: 55831 RVA: 0x003D14C2 File Offset: 0x003CF6C2
		public string type { get; set; }

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x0600DA18 RID: 55832 RVA: 0x003D14CB File Offset: 0x003CF6CB
		// (set) Token: 0x0600DA19 RID: 55833 RVA: 0x003D14D3 File Offset: 0x003CF6D3
		public int battleUseID { get; set; }

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x003D14DC File Offset: 0x003CF6DC
		// (set) Token: 0x0600DA1B RID: 55835 RVA: 0x003D14E4 File Offset: 0x003CF6E4
		public int firstTalkID { get; set; }

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600DA1C RID: 55836 RVA: 0x003D14ED File Offset: 0x003CF6ED
		// (set) Token: 0x0600DA1D RID: 55837 RVA: 0x003D14F5 File Offset: 0x003CF6F5
		public int id { get; set; }

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600DA1E RID: 55838 RVA: 0x003D14FE File Offset: 0x003CF6FE
		// (set) Token: 0x0600DA1F RID: 55839 RVA: 0x003D1506 File Offset: 0x003CF706
		public int monsterID { get; set; }

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600DA20 RID: 55840 RVA: 0x003D150F File Offset: 0x003CF70F
		// (set) Token: 0x0600DA21 RID: 55841 RVA: 0x003D1517 File Offset: 0x003CF717
		public int originalState { get; set; }

		// Token: 0x0600DA22 RID: 55842 RVA: 0x003D1520 File Offset: 0x003CF720
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battleUseID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.firstTalkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.originalState = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardDrop = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
