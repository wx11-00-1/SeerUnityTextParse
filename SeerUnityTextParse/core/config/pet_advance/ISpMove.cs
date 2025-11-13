using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F4B RID: 8011
	public class ISpMove
	{
		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600F04C RID: 61516 RVA: 0x003F4A58 File Offset: 0x003F2C58
		// (set) Token: 0x0600F04D RID: 61517 RVA: 0x003F4A60 File Offset: 0x003F2C60
		public int[] SpMoves { get; set; }

		// Token: 0x0600F04E RID: 61518 RVA: 0x003F4A6C File Offset: 0x003F2C6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SpMoves = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.SpMoves[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
