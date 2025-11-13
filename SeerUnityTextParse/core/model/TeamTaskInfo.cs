using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200197E RID: 6526
	public class TeamTaskInfo
	{
		// Token: 0x0400E325 RID: 58149
		public int time = 1;

		// Token: 0x0400E326 RID: 58150
		public int id;

		// Token: 0x0400E327 RID: 58151
		public string name;

		// Token: 0x0400E328 RID: 58152
		public int level;

		// Token: 0x0400E329 RID: 58153
		public string des;

		// Token: 0x0400E32A RID: 58154
		public int state;

		// Token: 0x0400E32B RID: 58155
		public List<object> rewards;

		// Token: 0x0400E32C RID: 58156
		public int taskTimeStamp;

		// Token: 0x0400E32D RID: 58157
		public List<int> recommendPets;

		// Token: 0x0400E32E RID: 58158
		public List<int> inSpirit;

		// Token: 0x0400E32F RID: 58159
		public List<object> extraRewards;

		// Token: 0x0400E330 RID: 58160
		public int needMonstersNum;

		// Token: 0x0400E331 RID: 58161
		public List<string> taskTotalTime;

		// Token: 0x0400E332 RID: 58162
		public int taskOver;

		// Token: 0x0400E333 RID: 58163
		public int rewardState;

		// Token: 0x0400E334 RID: 58164
		public int index;

		// Token: 0x0400E335 RID: 58165
		public int successRate;

		// Token: 0x0400E336 RID: 58166
		public bool isExtraReward;
	}
}
