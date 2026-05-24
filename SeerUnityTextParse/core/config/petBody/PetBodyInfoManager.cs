using System;
using System.Collections.Generic;
using common;

namespace core.config.petBody
{
	// Token: 0x02002778 RID: 10104
	public class PetBodyInfoManager : ResetableSingleTon<PetBodyInfoManager>
	{
		// Token: 0x06013DBB RID: 81339 RVA: 0x005362C1 File Offset: 0x005344C1
		public override void Reset()
		{
			base.Reset();
		}

		// Token: 0x0401323F RID: 78399
		private Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> _infos;

		// Token: 0x020062C2 RID: 25282
		public enum PetBodyPositionType
		{
			// Token: 0x04022E8F RID: 142991
			FullBody = 1,
			// Token: 0x04022E90 RID: 142992
			Head,
			// Token: 0x04022E91 RID: 142993
			Prefab
		}
	}
}
