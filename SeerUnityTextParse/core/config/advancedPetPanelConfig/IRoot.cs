using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x0200207B RID: 8315
	public class IRoot
	{
		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600FDDB RID: 64987 RVA: 0x0040394B File Offset: 0x00401B4B
		// (set) Token: 0x0600FDDC RID: 64988 RVA: 0x00403953 File Offset: 0x00401B53
		public ITaskItem[] Task { get; set; }

		// Token: 0x0600FDDD RID: 64989 RVA: 0x0040395C File Offset: 0x00401B5C
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
