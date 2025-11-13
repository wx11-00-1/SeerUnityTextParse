using System;

namespace core.config.awakendetail
{
	// Token: 0x0200206B RID: 8299
	public class IRoot
	{
		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x0600FD73 RID: 64883 RVA: 0x0040321D File Offset: 0x0040141D
		// (set) Token: 0x0600FD74 RID: 64884 RVA: 0x00403225 File Offset: 0x00401425
		public ITaskItem[] Task { get; set; }

		// Token: 0x0600FD75 RID: 64885 RVA: 0x00403230 File Offset: 0x00401430
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Task = new ITaskItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Task[i] = new ITaskItem();
					this.Task[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
