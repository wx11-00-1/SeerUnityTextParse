using System;

namespace core.model
{
	// Token: 0x0200197D RID: 6525
	public class TeamPkHistoryInfo
	{
		// Token: 0x0600CCCC RID: 52428 RVA: 0x003B6478 File Offset: 0x003B4678
		public TeamPkHistoryInfo(ByteArray data)
		{
			this.killPlayer = (int)data.ReadUnsignedInt();
			this.killBuilding = (int)data.ReadUnsignedInt();
			this.mvpNum = (int)data.ReadUnsignedInt();
			this.winTimes = (int)data.ReadUnsignedInt();
			this.lostTimes = (int)data.ReadUnsignedInt();
			this.drawTimes = (int)data.ReadUnsignedInt();
			this._week = data.ReadSignedInt();
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600CCCD RID: 52429 RVA: 0x003B64DF File Offset: 0x003B46DF
		public int week
		{
			get
			{
				if (this._week <= 0)
				{
					return 1;
				}
				return this._week;
			}
		}

		// Token: 0x0400E31E RID: 58142
		public int killPlayer;

		// Token: 0x0400E31F RID: 58143
		public int killBuilding;

		// Token: 0x0400E320 RID: 58144
		public int mvpNum;

		// Token: 0x0400E321 RID: 58145
		public int winTimes;

		// Token: 0x0400E322 RID: 58146
		public int lostTimes;

		// Token: 0x0400E323 RID: 58147
		public int drawTimes;

		// Token: 0x0400E324 RID: 58148
		private int _week;
	}
}
