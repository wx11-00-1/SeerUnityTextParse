using System;

namespace core.config
{
	// Token: 0x020026B1 RID: 9905
	public class IAbyssFisheryInfo : IConfigItem
	{
		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0601377B RID: 79739 RVA: 0x00583838 File Offset: 0x00581A38
		// (set) Token: 0x0601377C RID: 79740 RVA: 0x00583840 File Offset: 0x00581A40
		public string des { get; set; }

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0601377D RID: 79741 RVA: 0x00583849 File Offset: 0x00581A49
		// (set) Token: 0x0601377E RID: 79742 RVA: 0x00583851 File Offset: 0x00581A51
		public string name { get; set; }

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0601377F RID: 79743 RVA: 0x0058385A File Offset: 0x00581A5A
		// (set) Token: 0x06013780 RID: 79744 RVA: 0x00583862 File Offset: 0x00581A62
		public int gameid { get; set; }

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06013781 RID: 79745 RVA: 0x0058386B File Offset: 0x00581A6B
		// (set) Token: 0x06013782 RID: 79746 RVA: 0x00583873 File Offset: 0x00581A73
		public int id { get; set; }

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06013783 RID: 79747 RVA: 0x0058387C File Offset: 0x00581A7C
		// (set) Token: 0x06013784 RID: 79748 RVA: 0x00583884 File Offset: 0x00581A84
		public int rare { get; set; }

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06013785 RID: 79749 RVA: 0x0058388D File Offset: 0x00581A8D
		// (set) Token: 0x06013786 RID: 79750 RVA: 0x00583895 File Offset: 0x00581A95
		public int scale { get; set; }

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06013787 RID: 79751 RVA: 0x0058389E File Offset: 0x00581A9E
		// (set) Token: 0x06013788 RID: 79752 RVA: 0x005838A6 File Offset: 0x00581AA6
		public int showtype { get; set; }

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06013789 RID: 79753 RVA: 0x005838AF File Offset: 0x00581AAF
		// (set) Token: 0x0601378A RID: 79754 RVA: 0x005838B7 File Offset: 0x00581AB7
		public int star { get; set; }

		// Token: 0x0601378B RID: 79755 RVA: 0x005838C0 File Offset: 0x00581AC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gameid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.scale = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
