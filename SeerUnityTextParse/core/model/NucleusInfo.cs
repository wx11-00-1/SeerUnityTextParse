using System;

namespace core.model
{
	// Token: 0x0200194B RID: 6475
	public class NucleusInfo : SingleItemInfo
	{
		// Token: 0x0600CBD8 RID: 52184 RVA: 0x003B2DFC File Offset: 0x003B0FFC
		public NucleusInfo(ByteArray data = null)
		{
			this.gen_item = (int)data.ReadUnsignedInt();
			this.gentm = (int)data.ReadUnsignedInt();
			this.left_time = (int)data.ReadUnsignedInt();
			this.updateTime = (uint)this.gentm;
			base.itemID = this.gen_item;
			this.itemNum = 1U;
		}

		// Token: 0x0400E157 RID: 57687
		public int gentm;

		// Token: 0x0400E158 RID: 57688
		public int left_time;

		// Token: 0x0400E159 RID: 57689
		public int gen_item;
	}
}
