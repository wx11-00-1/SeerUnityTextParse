using System;

namespace core.config.sp_hide_moves
{
	// Token: 0x02001F19 RID: 7961
	public class IConfig
	{
		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x0600EE7C RID: 61052 RVA: 0x003F2753 File Offset: 0x003F0953
		// (set) Token: 0x0600EE7D RID: 61053 RVA: 0x003F275B File Offset: 0x003F095B
		public ISpMovesItem[] ShowMoves { get; set; }

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600EE7E RID: 61054 RVA: 0x003F2764 File Offset: 0x003F0964
		// (set) Token: 0x0600EE7F RID: 61055 RVA: 0x003F276C File Offset: 0x003F096C
		public ISpMovesItem[] SpMoves { get; set; }

		// Token: 0x0600EE80 RID: 61056 RVA: 0x003F2778 File Offset: 0x003F0978
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ShowMoves = new ISpMovesItem[num];
				for (int i = 0; i < num; i++)
				{
					this.ShowMoves[i] = new ISpMovesItem();
					this.ShowMoves[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SpMoves = new ISpMovesItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.SpMoves[j] = new ISpMovesItem();
					this.SpMoves[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
