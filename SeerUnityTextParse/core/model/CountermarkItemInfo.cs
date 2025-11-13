using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001924 RID: 6436
	public class CountermarkItemInfo
	{
		// Token: 0x0600CAAB RID: 51883 RVA: 0x003B04F4 File Offset: 0x003AE6F4
		public CountermarkItemInfo(ByteArray data = null)
		{
			this.obtainTime = data.ReadSignedInt();
			this.itemID = data.ReadSignedInt();
			this.bindMonId = data.ReadSignedInt();
			this.bindMoveId = data.ReadSignedInt();
			for (int i = 0; i < 6; i++)
			{
				int num = data.ReadSignedInt();
				this.attriAdj[i] = num;
				if (num > 0)
				{
					this.attriIndex.Add(i);
				}
			}
			this.gemId = data.ReadSignedInt();
			this.installedPet = data.ReadSignedInt();
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600CAAC RID: 51884 RVA: 0x003B0593 File Offset: 0x003AE793
		public bool isBindMon
		{
			get
			{
				return this.bindMonId > 0;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x003B059E File Offset: 0x003AE79E
		public bool isInstall
		{
			get
			{
				return this.installedPet > 0;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x0600CAAE RID: 51886 RVA: 0x003B05A9 File Offset: 0x003AE7A9
		public bool isBindMove
		{
			get
			{
				return this.bindMoveId > 0;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x003B05B4 File Offset: 0x003AE7B4
		public bool isBindGem
		{
			get
			{
				return this.gemId > 0;
			}
		}

		// Token: 0x0400DF5B RID: 57179
		public int obtainTime;

		// Token: 0x0400DF5C RID: 57180
		public int itemID;

		// Token: 0x0400DF5D RID: 57181
		public int bindMonId;

		// Token: 0x0400DF5E RID: 57182
		public int bindMoveId;

		// Token: 0x0400DF5F RID: 57183
		public int[] attriAdj = new int[6];

		// Token: 0x0400DF60 RID: 57184
		public int gemId;

		// Token: 0x0400DF61 RID: 57185
		public int installedPet;

		// Token: 0x0400DF62 RID: 57186
		public List<int> attriIndex = new List<int>(6);
	}
}
