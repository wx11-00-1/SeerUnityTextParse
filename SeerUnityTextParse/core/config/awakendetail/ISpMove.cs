using System;

namespace core.config.awakendetail
{
	// Token: 0x0200206D RID: 8301
	public class ISpMove
	{
		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600FD7D RID: 64893 RVA: 0x004032E8 File Offset: 0x004014E8
		// (set) Token: 0x0600FD7E RID: 64894 RVA: 0x004032F0 File Offset: 0x004014F0
		public int[] SpMoves { get; set; }

		// Token: 0x0600FD7F RID: 64895 RVA: 0x004032FC File Offset: 0x004014FC
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
