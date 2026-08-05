using System;

namespace core.config
{
	// Token: 0x0200290B RID: 10507
	public class IPvpCostModeVoteInfo : IConfigItem
	{
		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06015227 RID: 86567 RVA: 0x005A385C File Offset: 0x005A1A5C
		// (set) Token: 0x06015228 RID: 86568 RVA: 0x005A3864 File Offset: 0x005A1A64
		public string adjust { get; set; }

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06015229 RID: 86569 RVA: 0x005A386D File Offset: 0x005A1A6D
		// (set) Token: 0x0601522A RID: 86570 RVA: 0x005A3875 File Offset: 0x005A1A75
		public string resultpet { get; set; }

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0601522B RID: 86571 RVA: 0x005A387E File Offset: 0x005A1A7E
		// (set) Token: 0x0601522C RID: 86572 RVA: 0x005A3886 File Offset: 0x005A1A86
		public string votepet { get; set; }

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0601522D RID: 86573 RVA: 0x005A388F File Offset: 0x005A1A8F
		// (set) Token: 0x0601522E RID: 86574 RVA: 0x005A3897 File Offset: 0x005A1A97
		public int id { get; set; }

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0601522F RID: 86575 RVA: 0x005A38A0 File Offset: 0x005A1AA0
		// (set) Token: 0x06015230 RID: 86576 RVA: 0x005A38A8 File Offset: 0x005A1AA8
		public int number { get; set; }

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06015231 RID: 86577 RVA: 0x005A38B1 File Offset: 0x005A1AB1
		// (set) Token: 0x06015232 RID: 86578 RVA: 0x005A38B9 File Offset: 0x005A1AB9
		public int pool { get; set; }

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06015233 RID: 86579 RVA: 0x005A38C2 File Offset: 0x005A1AC2
		// (set) Token: 0x06015234 RID: 86580 RVA: 0x005A38CA File Offset: 0x005A1ACA
		public int ranklimit1 { get; set; }

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06015235 RID: 86581 RVA: 0x005A38D3 File Offset: 0x005A1AD3
		// (set) Token: 0x06015236 RID: 86582 RVA: 0x005A38DB File Offset: 0x005A1ADB
		public int ranklimit2 { get; set; }

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06015237 RID: 86583 RVA: 0x005A38E4 File Offset: 0x005A1AE4
		// (set) Token: 0x06015238 RID: 86584 RVA: 0x005A38EC File Offset: 0x005A1AEC
		public int time1 { get; set; }

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06015239 RID: 86585 RVA: 0x005A38F5 File Offset: 0x005A1AF5
		// (set) Token: 0x0601523A RID: 86586 RVA: 0x005A38FD File Offset: 0x005A1AFD
		public int time2 { get; set; }

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0601523B RID: 86587 RVA: 0x005A3906 File Offset: 0x005A1B06
		// (set) Token: 0x0601523C RID: 86588 RVA: 0x005A390E File Offset: 0x005A1B0E
		public int time3 { get; set; }

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0601523D RID: 86589 RVA: 0x005A3917 File Offset: 0x005A1B17
		// (set) Token: 0x0601523E RID: 86590 RVA: 0x005A391F File Offset: 0x005A1B1F
		public int type { get; set; }

		// Token: 0x0601523F RID: 86591 RVA: 0x005A3928 File Offset: 0x005A1B28
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.adjust = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pool = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ranklimit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ranklimit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.resultpet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.votepet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
