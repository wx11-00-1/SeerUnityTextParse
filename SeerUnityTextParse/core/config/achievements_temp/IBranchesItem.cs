using System;

namespace core.config.achievements_temp
{
	// Token: 0x02002359 RID: 9049
	public class IBranchesItem
	{
		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06011A4E RID: 72270 RVA: 0x0046DE49 File Offset: 0x0046C049
		// (set) Token: 0x06011A4F RID: 72271 RVA: 0x0046DE51 File Offset: 0x0046C051
		public IBranchItem[] Branch { get; set; }

		// Token: 0x06011A50 RID: 72272 RVA: 0x0046DE5C File Offset: 0x0046C05C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branch = new IBranchItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branch[i] = new IBranchItem();
					this.Branch[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
