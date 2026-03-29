using System;

namespace core.config.newguideStep2020
{
	// Token: 0x0200252E RID: 9518
	public class IStepsItem
	{
		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0601271C RID: 75548 RVA: 0x004B9444 File Offset: 0x004B7644
		// (set) Token: 0x0601271D RID: 75549 RVA: 0x004B944C File Offset: 0x004B764C
		public string npcs { get; set; }

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0601271E RID: 75550 RVA: 0x004B9455 File Offset: 0x004B7655
		// (set) Token: 0x0601271F RID: 75551 RVA: 0x004B945D File Offset: 0x004B765D
		public ISubstepItem[] substep { get; set; }

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06012720 RID: 75552 RVA: 0x004B9466 File Offset: 0x004B7666
		// (set) Token: 0x06012721 RID: 75553 RVA: 0x004B946E File Offset: 0x004B766E
		public string tool { get; set; }

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06012722 RID: 75554 RVA: 0x004B9477 File Offset: 0x004B7677
		// (set) Token: 0x06012723 RID: 75555 RVA: 0x004B947F File Offset: 0x004B767F
		public int auto { get; set; }

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06012724 RID: 75556 RVA: 0x004B9488 File Offset: 0x004B7688
		// (set) Token: 0x06012725 RID: 75557 RVA: 0x004B9490 File Offset: 0x004B7690
		public int step { get; set; }

		// Token: 0x06012726 RID: 75558 RVA: 0x004B949C File Offset: 0x004B769C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.auto = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.npcs = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.substep = new ISubstepItem[num];
				for (int i = 0; i < num; i++)
				{
					this.substep[i] = new ISubstepItem();
					this.substep[i].Parse(bytes, ref byteIndex);
				}
			}
			this.tool = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
