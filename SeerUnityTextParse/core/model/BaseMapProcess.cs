using System;

namespace core.model
{
	// Token: 0x0200191D RID: 6429
	public class BaseMapProcess
	{
		// Token: 0x0600CA3A RID: 51770 RVA: 0x003AF77B File Offset: 0x003AD97B
		public BaseMapProcess(MapModel mapMod)
		{
			this.mapUi = mapMod;
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x003AF78A File Offset: 0x003AD98A
		public void init()
		{
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x003AF78C File Offset: 0x003AD98C
		public void destroy()
		{
			this.mapUi = null;
		}

		// Token: 0x0400DF14 RID: 57108
		protected MapModel mapUi;
	}
}
