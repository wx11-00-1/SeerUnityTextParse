using System;

namespace core.model
{
	// Token: 0x0200193D RID: 6461
	public class ImprintListItemInfo
	{
		// Token: 0x0600CB9B RID: 52123 RVA: 0x003B2250 File Offset: 0x003B0450
		public ImprintListItemInfo()
		{
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x003B2258 File Offset: 0x003B0458
		public ImprintListItemInfo(int id, int layers)
		{
			this.id = id;
			this.layers = layers;
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x003B226E File Offset: 0x003B046E
		public void SetData(int id, int layers)
		{
			this.id = id;
			this.layers = layers;
		}

		// Token: 0x0400E0DC RID: 57564
		public int id;

		// Token: 0x0400E0DD RID: 57565
		public int layers;
	}
}
