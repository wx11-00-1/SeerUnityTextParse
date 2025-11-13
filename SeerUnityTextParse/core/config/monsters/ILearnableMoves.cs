using System;

namespace core.config.monsters
{
	// Token: 0x02001FB3 RID: 8115
	public class ILearnableMoves
	{
		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x0600F456 RID: 62550 RVA: 0x003F98D8 File Offset: 0x003F7AD8
		// (set) Token: 0x0600F457 RID: 62551 RVA: 0x003F98E0 File Offset: 0x003F7AE0
		public ISpMoveItem[] AdvMove { get; set; }

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x0600F458 RID: 62552 RVA: 0x003F98E9 File Offset: 0x003F7AE9
		// (set) Token: 0x0600F459 RID: 62553 RVA: 0x003F98F1 File Offset: 0x003F7AF1
		public IMoveItem[] Move { get; set; }

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600F45A RID: 62554 RVA: 0x003F98FA File Offset: 0x003F7AFA
		// (set) Token: 0x0600F45B RID: 62555 RVA: 0x003F9902 File Offset: 0x003F7B02
		public ISpMoveItem[] SpMove { get; set; }

		// Token: 0x0600F45C RID: 62556 RVA: 0x003F990C File Offset: 0x003F7B0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.AdvMove = new ISpMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					this.AdvMove[i] = new ISpMoveItem();
					this.AdvMove[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Move = new IMoveItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.Move[j] = new IMoveItem();
					this.Move[j].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SpMove = new ISpMoveItem[num3];
				for (int k = 0; k < num3; k++)
				{
					this.SpMove[k] = new ISpMoveItem();
					this.SpMove[k].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
