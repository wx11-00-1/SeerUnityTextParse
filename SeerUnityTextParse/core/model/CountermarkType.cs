using System;

namespace core.model
{
	// Token: 0x02001925 RID: 6437
	public class CountermarkType
	{
		// Token: 0x0600CAB0 RID: 51888 RVA: 0x003B05BF File Offset: 0x003AE7BF
		public static bool isAbilityMark(int type)
		{
			return type == 0 || type == 3;
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x003B05CA File Offset: 0x003AE7CA
		public static bool isSkillMark(int type)
		{
			return type == 1;
		}

		// Token: 0x0400DF63 RID: 57187
		public const int MARK_IS_COMMON_ABLITY = 0;

		// Token: 0x0400DF64 RID: 57188
		public const int MARK_IS_SKILL = 1;

		// Token: 0x0400DF65 RID: 57189
		public const int MARK_IS_UNIVERSAL = 3;

		// Token: 0x0400DF66 RID: 57190
		public const int MARK_IS_PIECE = 4;

		// Token: 0x0400DF67 RID: 57191
		public const int MARK_IS_QUAN_XIAO = 55;

		// Token: 0x0400DF68 RID: 57192
		public const int HOLE_IS_ABILITY = 0;

		// Token: 0x0400DF69 RID: 57193
		public const int HOLE_IS_SKILL = 1;

		// Token: 0x0400DF6A RID: 57194
		public const int HOLE_IS_COMMON = 2;

		// Token: 0x0400DF6B RID: 57195
		public const int POS_IS_BAG = 0;

		// Token: 0x0400DF6C RID: 57196
		public const int POS_IS_WILD = 1;

		// Token: 0x0400DF6D RID: 57197
		public const int POS_IS_STORAGE = 2;
	}
}
