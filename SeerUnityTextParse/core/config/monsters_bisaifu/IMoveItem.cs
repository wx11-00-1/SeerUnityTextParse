using System;

namespace core.config.monsters_bisaifu
{
	// Token: 0x02001FB0 RID: 8112
	public class IMoveItem
	{
		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x0600F43E RID: 62526 RVA: 0x003F978A File Offset: 0x003F798A
		// (set) Token: 0x0600F43F RID: 62527 RVA: 0x003F9792 File Offset: 0x003F7992
		public int ID { get; set; }

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600F440 RID: 62528 RVA: 0x003F979B File Offset: 0x003F799B
		// (set) Token: 0x0600F441 RID: 62529 RVA: 0x003F97A3 File Offset: 0x003F79A3
		public int LearningLv { get; set; }

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x0600F442 RID: 62530 RVA: 0x003F97AC File Offset: 0x003F79AC
		// (set) Token: 0x0600F443 RID: 62531 RVA: 0x003F97B4 File Offset: 0x003F79B4
		public int Rec { get; set; }

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x0600F444 RID: 62532 RVA: 0x003F97BD File Offset: 0x003F79BD
		// (set) Token: 0x0600F445 RID: 62533 RVA: 0x003F97C5 File Offset: 0x003F79C5
		public int Tag { get; set; }

		// Token: 0x0600F446 RID: 62534 RVA: 0x003F97CE File Offset: 0x003F79CE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LearningLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
