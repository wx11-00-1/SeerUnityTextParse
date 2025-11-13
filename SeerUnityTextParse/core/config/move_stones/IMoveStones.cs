using System;

namespace core.config.move_stones
{
	// Token: 0x02001FA0 RID: 8096
	public class IMoveStones
	{
		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x0600F35A RID: 62298 RVA: 0x003F85A6 File Offset: 0x003F67A6
		// (set) Token: 0x0600F35B RID: 62299 RVA: 0x003F85AE File Offset: 0x003F67AE
		public IMoveStoneItem[] MoveStone { get; set; }

		// Token: 0x0600F35C RID: 62300 RVA: 0x003F85B8 File Offset: 0x003F67B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MoveStone = new IMoveStoneItem[num];
				for (int i = 0; i < num; i++)
				{
					this.MoveStone[i] = new IMoveStoneItem();
					this.MoveStone[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
