using System;

namespace core.config
{
	// Token: 0x02001CBC RID: 7356
	public class IBattlepassRewardInfo : IConfigItem
	{
		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x0600D55A RID: 54618 RVA: 0x003CB9E4 File Offset: 0x003C9BE4
		// (set) Token: 0x0600D55B RID: 54619 RVA: 0x003CB9EC File Offset: 0x003C9BEC
		public string freereward { get; set; }

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x003CB9F5 File Offset: 0x003C9BF5
		// (set) Token: 0x0600D55D RID: 54621 RVA: 0x003CB9FD File Offset: 0x003C9BFD
		public string paidreward { get; set; }

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x003CBA06 File Offset: 0x003C9C06
		// (set) Token: 0x0600D55F RID: 54623 RVA: 0x003CBA0E File Offset: 0x003C9C0E
		public int diamondnum { get; set; }

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600D560 RID: 54624 RVA: 0x003CBA17 File Offset: 0x003C9C17
		// (set) Token: 0x0600D561 RID: 54625 RVA: 0x003CBA1F File Offset: 0x003C9C1F
		public int exp { get; set; }

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x0600D562 RID: 54626 RVA: 0x003CBA28 File Offset: 0x003C9C28
		// (set) Token: 0x0600D563 RID: 54627 RVA: 0x003CBA30 File Offset: 0x003C9C30
		public int id { get; set; }

		// Token: 0x0600D564 RID: 54628 RVA: 0x003CBA3C File Offset: 0x003C9C3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.diamondnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.paidreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
