using System;

namespace core.config
{
	// Token: 0x02001DE2 RID: 7650
	public class IPvpRewardInfo : IConfigItem
	{
		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x0600E176 RID: 57718 RVA: 0x003DA91C File Offset: 0x003D8B1C
		// (set) Token: 0x0600E177 RID: 57719 RVA: 0x003DA924 File Offset: 0x003D8B24
		public string rewardshow { get; set; }

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x0600E178 RID: 57720 RVA: 0x003DA92D File Offset: 0x003D8B2D
		// (set) Token: 0x0600E179 RID: 57721 RVA: 0x003DA935 File Offset: 0x003D8B35
		public int group { get; set; }

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x0600E17A RID: 57722 RVA: 0x003DA93E File Offset: 0x003D8B3E
		// (set) Token: 0x0600E17B RID: 57723 RVA: 0x003DA946 File Offset: 0x003D8B46
		public int id { get; set; }

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600E17C RID: 57724 RVA: 0x003DA94F File Offset: 0x003D8B4F
		// (set) Token: 0x0600E17D RID: 57725 RVA: 0x003DA957 File Offset: 0x003D8B57
		public int type { get; set; }

		// Token: 0x0600E17E RID: 57726 RVA: 0x003DA960 File Offset: 0x003D8B60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardshow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
