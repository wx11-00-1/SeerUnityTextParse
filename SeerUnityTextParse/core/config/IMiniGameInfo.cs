using System;

namespace core.config
{
	// Token: 0x02001D96 RID: 7574
	public class IMiniGameInfo : IConfigItem
	{
		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x003D6A48 File Offset: 0x003D4C48
		// (set) Token: 0x0600DE4D RID: 56909 RVA: 0x003D6A50 File Offset: 0x003D4C50
		public string path { get; set; }

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x003D6A59 File Offset: 0x003D4C59
		// (set) Token: 0x0600DE4F RID: 56911 RVA: 0x003D6A61 File Offset: 0x003D4C61
		public int[] child { get; set; }

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600DE50 RID: 56912 RVA: 0x003D6A6A File Offset: 0x003D4C6A
		// (set) Token: 0x0600DE51 RID: 56913 RVA: 0x003D6A72 File Offset: 0x003D4C72
		public int health { get; set; }

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x0600DE52 RID: 56914 RVA: 0x003D6A7B File Offset: 0x003D4C7B
		// (set) Token: 0x0600DE53 RID: 56915 RVA: 0x003D6A83 File Offset: 0x003D4C83
		public int id { get; set; }

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x003D6A8C File Offset: 0x003D4C8C
		// (set) Token: 0x0600DE55 RID: 56917 RVA: 0x003D6A94 File Offset: 0x003D4C94
		public int realId { get; set; }

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x0600DE56 RID: 56918 RVA: 0x003D6A9D File Offset: 0x003D4C9D
		// (set) Token: 0x0600DE57 RID: 56919 RVA: 0x003D6AA5 File Offset: 0x003D4CA5
		public int type { get; set; }

		// Token: 0x0600DE58 RID: 56920 RVA: 0x003D6AB0 File Offset: 0x003D4CB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.child = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.child[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.path = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.realId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
