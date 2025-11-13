using System;

namespace core.config
{
	// Token: 0x02001E8C RID: 7820
	public class IYear2025QteButtonInfo : IConfigItem
	{
		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x0600E8CC RID: 59596 RVA: 0x003E3CCC File Offset: 0x003E1ECC
		// (set) Token: 0x0600E8CD RID: 59597 RVA: 0x003E3CD4 File Offset: 0x003E1ED4
		public int delay { get; set; }

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x0600E8CE RID: 59598 RVA: 0x003E3CDD File Offset: 0x003E1EDD
		// (set) Token: 0x0600E8CF RID: 59599 RVA: 0x003E3CE5 File Offset: 0x003E1EE5
		public int duration { get; set; }

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x0600E8D0 RID: 59600 RVA: 0x003E3CEE File Offset: 0x003E1EEE
		// (set) Token: 0x0600E8D1 RID: 59601 RVA: 0x003E3CF6 File Offset: 0x003E1EF6
		public int id { get; set; }

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600E8D2 RID: 59602 RVA: 0x003E3CFF File Offset: 0x003E1EFF
		// (set) Token: 0x0600E8D3 RID: 59603 RVA: 0x003E3D07 File Offset: 0x003E1F07
		public int keycode { get; set; }

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600E8D4 RID: 59604 RVA: 0x003E3D10 File Offset: 0x003E1F10
		// (set) Token: 0x0600E8D5 RID: 59605 RVA: 0x003E3D18 File Offset: 0x003E1F18
		public int posX { get; set; }

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x0600E8D6 RID: 59606 RVA: 0x003E3D21 File Offset: 0x003E1F21
		// (set) Token: 0x0600E8D7 RID: 59607 RVA: 0x003E3D29 File Offset: 0x003E1F29
		public int posY { get; set; }

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x003E3D32 File Offset: 0x003E1F32
		// (set) Token: 0x0600E8D9 RID: 59609 RVA: 0x003E3D3A File Offset: 0x003E1F3A
		public int type { get; set; }

		// Token: 0x0600E8DA RID: 59610 RVA: 0x003E3D44 File Offset: 0x003E1F44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.delay = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.duration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.keycode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.posX = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.posY = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
