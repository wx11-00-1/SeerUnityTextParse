using System;

namespace core.config.sp_hide_moves_bisaifu
{
	// Token: 0x02001F15 RID: 7957
	public class IConfig
	{
		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x0600EE46 RID: 60998 RVA: 0x003F2398 File Offset: 0x003F0598
		// (set) Token: 0x0600EE47 RID: 60999 RVA: 0x003F23A0 File Offset: 0x003F05A0
		public IShowMovesItem[] ShowMoves { get; set; }

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x0600EE48 RID: 61000 RVA: 0x003F23A9 File Offset: 0x003F05A9
		// (set) Token: 0x0600EE49 RID: 61001 RVA: 0x003F23B1 File Offset: 0x003F05B1
		public ISpMovesItem[] SpMoves { get; set; }

		// Token: 0x0600EE4A RID: 61002 RVA: 0x003F23BC File Offset: 0x003F05BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ShowMoves = new IShowMovesItem[num];
				for (int i = 0; i < num; i++)
				{
					this.ShowMoves[i] = new IShowMovesItem();
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
