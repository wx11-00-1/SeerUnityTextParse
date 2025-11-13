using System;
using System.Collections.Generic;
using System.Numerics;

namespace core.model
{
	// Token: 0x0200194A RID: 6474
	internal class NpcInfo
	{
		// Token: 0x0600CBD7 RID: 52183 RVA: 0x003B2DD6 File Offset: 0x003B0FD6
		public NpcInfo(object obj = null)
		{
		}

		// Token: 0x0400E149 RID: 57673
		public int npcId;

		// Token: 0x0400E14A RID: 57674
		public string npcName;

		// Token: 0x0400E14B RID: 57675
		public bool isSimple;

		// Token: 0x0400E14C RID: 57676
		public int nameY;

		// Token: 0x0400E14D RID: 57677
		public bool isStop;

		// Token: 0x0400E14E RID: 57678
		public string dir;

		// Token: 0x0400E14F RID: 57679
		public int sound;

		// Token: 0x0400E150 RID: 57680
		public string type;

		// Token: 0x0400E151 RID: 57681
		public Vector2 point;

		// Token: 0x0400E152 RID: 57682
		public List<Vector2> walkPoints = new List<Vector2>();

		// Token: 0x0400E153 RID: 57683
		public int color;

		// Token: 0x0400E154 RID: 57684
		public List<int> clothIds = new List<int>();

		// Token: 0x0400E155 RID: 57685
		public bool hasName;

		// Token: 0x0400E156 RID: 57686
		public bool isWalk = true;
	}
}
