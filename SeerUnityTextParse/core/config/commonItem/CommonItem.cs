using System;
using core.config.itemsOptimize;

namespace core.config.commonItem
{
	// Token: 0x02001EE4 RID: 7908
	public class CommonItem : ItemData
	{
		// Token: 0x0600ECBB RID: 60603 RVA: 0x003F07D0 File Offset: 0x003EE9D0
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600ECBC RID: 60604 RVA: 0x003F07D8 File Offset: 0x003EE9D8
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600ECBD RID: 60605 RVA: 0x003F07E0 File Offset: 0x003EE9E0
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600ECBE RID: 60606 RVA: 0x003F07E8 File Offset: 0x003EE9E8
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0400F00A RID: 61450
		public int ID;

		// Token: 0x0400F00B RID: 61451
		public string Name = string.Empty;

		// Token: 0x0400F00C RID: 61452
		public int Max;

		// Token: 0x0400F00D RID: 61453
		public int catID;
	}
}
