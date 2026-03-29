using System;

namespace core.config.LockedSpaceRoomConfig
{
	// Token: 0x0200257E RID: 9598
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06012A93 RID: 76435 RVA: 0x004BDE12 File Offset: 0x004BC012
		public override string fileName
		{
			get
			{
				return "LockedSpaceRoomConfig";
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06012A94 RID: 76436 RVA: 0x004BDE19 File Offset: 0x004BC019
		// (set) Token: 0x06012A95 RID: 76437 RVA: 0x004BDE21 File Offset: 0x004BC021
		public IRoot root { get; set; }

		// Token: 0x06012A96 RID: 76438 RVA: 0x004BDE2A File Offset: 0x004BC02A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012A97 RID: 76439 RVA: 0x004BDE50 File Offset: 0x004BC050
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
