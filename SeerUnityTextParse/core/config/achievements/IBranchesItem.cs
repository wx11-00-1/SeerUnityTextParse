using System;

namespace core.config.achievements
{
	// Token: 0x0200208A RID: 8330
	public class IBranchesItem
	{
		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600FE5D RID: 65117 RVA: 0x00404361 File Offset: 0x00402561
		// (set) Token: 0x0600FE5E RID: 65118 RVA: 0x00404369 File Offset: 0x00402569
		public IBranchItem[] Branch { get; set; }

		// Token: 0x0600FE5F RID: 65119 RVA: 0x00404374 File Offset: 0x00402574
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
