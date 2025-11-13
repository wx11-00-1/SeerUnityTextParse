using System;

namespace core.config.move_change
{
	// Token: 0x02001FA2 RID: 8098
	public class IMove
	{
		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600F364 RID: 62308 RVA: 0x003F8670 File Offset: 0x003F6870
		// (set) Token: 0x0600F365 RID: 62309 RVA: 0x003F8678 File Offset: 0x003F6878
		public IMovesItem[] Moves { get; set; }

		// Token: 0x0600F366 RID: 62310 RVA: 0x003F8684 File Offset: 0x003F6884
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Moves = new IMovesItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Moves[i] = new IMovesItem();
					this.Moves[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
