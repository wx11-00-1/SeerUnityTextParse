using System;

namespace core.model.task
{
	// Token: 0x0200198E RID: 6542
	public class TaskInfo
	{
		// Token: 0x0600CD2B RID: 52523 RVA: 0x003B8F85 File Offset: 0x003B7185
		public TaskInfo(uint _id, uint _pro, Action<bool> _callback)
		{
			this.id = _id;
			this.pro = _pro;
			this.callback = _callback;
		}

		// Token: 0x0400E4A7 RID: 58535
		public uint id;

		// Token: 0x0400E4A8 RID: 58536
		public uint pro;

		// Token: 0x0400E4A9 RID: 58537
		public Action<bool> callback;

		// Token: 0x0400E4AA RID: 58538
		public uint outType;

		// Token: 0x0400E4AB RID: 58539
		public bool status;

		// Token: 0x0400E4AC RID: 58540
		public bool isComplete;

		// Token: 0x0400E4AD RID: 58541
		public uint type;
	}
}
