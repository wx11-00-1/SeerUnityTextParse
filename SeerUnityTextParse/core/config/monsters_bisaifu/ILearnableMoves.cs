using System;

namespace core.config.monsters_bisaifu
{
	// Token: 0x02001FAD RID: 8109
	public class ILearnableMoves
	{
		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x003F8E48 File Offset: 0x003F7048
		// (set) Token: 0x0600F3C1 RID: 62401 RVA: 0x003F8E50 File Offset: 0x003F7050
		public ISpMoveItem[] AdvMove { get; set; }

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600F3C2 RID: 62402 RVA: 0x003F8E59 File Offset: 0x003F7059
		// (set) Token: 0x0600F3C3 RID: 62403 RVA: 0x003F8E61 File Offset: 0x003F7061
		public ISpMoveItem ExtraMove { get; set; }

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x003F8E6A File Offset: 0x003F706A
		// (set) Token: 0x0600F3C5 RID: 62405 RVA: 0x003F8E72 File Offset: 0x003F7072
		public IMoveItem[] Move { get; set; }

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x0600F3C6 RID: 62406 RVA: 0x003F8E7B File Offset: 0x003F707B
		// (set) Token: 0x0600F3C7 RID: 62407 RVA: 0x003F8E83 File Offset: 0x003F7083
		public ISpMoveItem[] SpMove { get; set; }

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x003F8E8C File Offset: 0x003F708C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.AdvMove = new ISpMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					this.AdvMove[i] = new ISpMoveItem();
					this.AdvMove[i].Parse(bytes, ref byteIndex);
				}
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.ExtraMove = new ISpMoveItem();
				this.ExtraMove.Parse(bytes, ref byteIndex);
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Move = new IMoveItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.Move[j] = new IMoveItem();
					this.Move[j].Parse(bytes, ref byteIndex);
				}
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
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

		// Token: 0x0400F2C0 RID: 62144
		private bool b;
	}
}
