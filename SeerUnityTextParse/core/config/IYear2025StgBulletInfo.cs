using System;

namespace core.config
{
	// Token: 0x02001E90 RID: 7824
	public class IYear2025StgBulletInfo : IConfigItem
	{
		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x003E3F90 File Offset: 0x003E2190
		// (set) Token: 0x0600E8EF RID: 59631 RVA: 0x003E3F98 File Offset: 0x003E2198
		public string prefabPath { get; set; }

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x003E3FA1 File Offset: 0x003E21A1
		// (set) Token: 0x0600E8F1 RID: 59633 RVA: 0x003E3FA9 File Offset: 0x003E21A9
		public int[] args { get; set; }

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600E8F2 RID: 59634 RVA: 0x003E3FB2 File Offset: 0x003E21B2
		// (set) Token: 0x0600E8F3 RID: 59635 RVA: 0x003E3FBA File Offset: 0x003E21BA
		public int atk { get; set; }

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x003E3FC3 File Offset: 0x003E21C3
		// (set) Token: 0x0600E8F5 RID: 59637 RVA: 0x003E3FCB File Offset: 0x003E21CB
		public int def { get; set; }

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x0600E8F6 RID: 59638 RVA: 0x003E3FD4 File Offset: 0x003E21D4
		// (set) Token: 0x0600E8F7 RID: 59639 RVA: 0x003E3FDC File Offset: 0x003E21DC
		public int hp { get; set; }

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x003E3FE5 File Offset: 0x003E21E5
		// (set) Token: 0x0600E8F9 RID: 59641 RVA: 0x003E3FED File Offset: 0x003E21ED
		public int id { get; set; }

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x0600E8FA RID: 59642 RVA: 0x003E3FF6 File Offset: 0x003E21F6
		// (set) Token: 0x0600E8FB RID: 59643 RVA: 0x003E3FFE File Offset: 0x003E21FE
		public int speed { get; set; }

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x0600E8FC RID: 59644 RVA: 0x003E4007 File Offset: 0x003E2207
		// (set) Token: 0x0600E8FD RID: 59645 RVA: 0x003E400F File Offset: 0x003E220F
		public int type { get; set; }

		// Token: 0x0600E8FE RID: 59646 RVA: 0x003E4018 File Offset: 0x003E2218
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.args = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.prefabPath = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
