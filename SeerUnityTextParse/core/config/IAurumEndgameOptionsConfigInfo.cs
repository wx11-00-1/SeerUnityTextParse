using System;

namespace core.config
{
	// Token: 0x0200242D RID: 9261
	public class IAurumEndgameOptionsConfigInfo : IConfigItem
	{
		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06011834 RID: 71732 RVA: 0x005006CC File Offset: 0x004FE8CC
		// (set) Token: 0x06011835 RID: 71733 RVA: 0x005006D4 File Offset: 0x004FE8D4
		public string attritube { get; set; }

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06011836 RID: 71734 RVA: 0x005006DD File Offset: 0x004FE8DD
		// (set) Token: 0x06011837 RID: 71735 RVA: 0x005006E5 File Offset: 0x004FE8E5
		public string desc { get; set; }

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06011838 RID: 71736 RVA: 0x005006EE File Offset: 0x004FE8EE
		// (set) Token: 0x06011839 RID: 71737 RVA: 0x005006F6 File Offset: 0x004FE8F6
		public string name { get; set; }

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0601183A RID: 71738 RVA: 0x005006FF File Offset: 0x004FE8FF
		// (set) Token: 0x0601183B RID: 71739 RVA: 0x00500707 File Offset: 0x004FE907
		public int branchid { get; set; }

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x0601183C RID: 71740 RVA: 0x00500710 File Offset: 0x004FE910
		// (set) Token: 0x0601183D RID: 71741 RVA: 0x00500718 File Offset: 0x004FE918
		public int group { get; set; }

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0601183E RID: 71742 RVA: 0x00500721 File Offset: 0x004FE921
		// (set) Token: 0x0601183F RID: 71743 RVA: 0x00500729 File Offset: 0x004FE929
		public int id { get; set; }

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06011840 RID: 71744 RVA: 0x00500732 File Offset: 0x004FE932
		// (set) Token: 0x06011841 RID: 71745 RVA: 0x0050073A File Offset: 0x004FE93A
		public int maxnum { get; set; }

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06011842 RID: 71746 RVA: 0x00500743 File Offset: 0x004FE943
		// (set) Token: 0x06011843 RID: 71747 RVA: 0x0050074B File Offset: 0x004FE94B
		public int rarity { get; set; }

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06011844 RID: 71748 RVA: 0x00500754 File Offset: 0x004FE954
		// (set) Token: 0x06011845 RID: 71749 RVA: 0x0050075C File Offset: 0x004FE95C
		public int related { get; set; }

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06011846 RID: 71750 RVA: 0x00500765 File Offset: 0x004FE965
		// (set) Token: 0x06011847 RID: 71751 RVA: 0x0050076D File Offset: 0x004FE96D
		public int root { get; set; }

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06011848 RID: 71752 RVA: 0x00500776 File Offset: 0x004FE976
		// (set) Token: 0x06011849 RID: 71753 RVA: 0x0050077E File Offset: 0x004FE97E
		public int treeid { get; set; }

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0601184A RID: 71754 RVA: 0x00500787 File Offset: 0x004FE987
		// (set) Token: 0x0601184B RID: 71755 RVA: 0x0050078F File Offset: 0x004FE98F
		public int type { get; set; }

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0601184C RID: 71756 RVA: 0x00500798 File Offset: 0x004FE998
		// (set) Token: 0x0601184D RID: 71757 RVA: 0x005007A0 File Offset: 0x004FE9A0
		public int value { get; set; }

		// Token: 0x0601184E RID: 71758 RVA: 0x005007AC File Offset: 0x004FE9AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.attritube = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.branchid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.maxnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.related = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.root = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.treeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
