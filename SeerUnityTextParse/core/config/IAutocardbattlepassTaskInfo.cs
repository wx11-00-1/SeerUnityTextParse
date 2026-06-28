using System;

namespace core.config
{
	// Token: 0x0200255D RID: 9565
	public class IAutocardbattlepassTaskInfo : IConfigItem
	{
		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x0601287F RID: 75903 RVA: 0x00545394 File Offset: 0x00543594
		// (set) Token: 0x06012880 RID: 75904 RVA: 0x0054539C File Offset: 0x0054359C
		public string describe { get; set; }

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06012881 RID: 75905 RVA: 0x005453A5 File Offset: 0x005435A5
		// (set) Token: 0x06012882 RID: 75906 RVA: 0x005453AD File Offset: 0x005435AD
		public int exp { get; set; }

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06012883 RID: 75907 RVA: 0x005453B6 File Offset: 0x005435B6
		// (set) Token: 0x06012884 RID: 75908 RVA: 0x005453BE File Offset: 0x005435BE
		public int id { get; set; }

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06012885 RID: 75909 RVA: 0x005453C7 File Offset: 0x005435C7
		// (set) Token: 0x06012886 RID: 75910 RVA: 0x005453CF File Offset: 0x005435CF
		public int rewardbit { get; set; }

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06012887 RID: 75911 RVA: 0x005453D8 File Offset: 0x005435D8
		// (set) Token: 0x06012888 RID: 75912 RVA: 0x005453E0 File Offset: 0x005435E0
		public int rewarduserinfo { get; set; }

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06012889 RID: 75913 RVA: 0x005453E9 File Offset: 0x005435E9
		// (set) Token: 0x0601288A RID: 75914 RVA: 0x005453F1 File Offset: 0x005435F1
		public int time { get; set; }

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x0601288B RID: 75915 RVA: 0x005453FA File Offset: 0x005435FA
		// (set) Token: 0x0601288C RID: 75916 RVA: 0x00545402 File Offset: 0x00543602
		public int userinfo { get; set; }

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x0601288D RID: 75917 RVA: 0x0054540B File Offset: 0x0054360B
		// (set) Token: 0x0601288E RID: 75918 RVA: 0x00545413 File Offset: 0x00543613
		public int value { get; set; }

		// Token: 0x0601288F RID: 75919 RVA: 0x0054541C File Offset: 0x0054361C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardbit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewarduserinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
