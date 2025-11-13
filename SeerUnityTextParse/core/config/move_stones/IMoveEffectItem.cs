using System;

namespace core.config.move_stones
{
	// Token: 0x02001F9E RID: 8094
	public class IMoveEffectItem
	{
		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x0600F344 RID: 62276 RVA: 0x003F83D8 File Offset: 0x003F65D8
		// (set) Token: 0x0600F345 RID: 62277 RVA: 0x003F83E0 File Offset: 0x003F65E0
		public int[] SideEffect { get; set; }

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x0600F346 RID: 62278 RVA: 0x003F83E9 File Offset: 0x003F65E9
		// (set) Token: 0x0600F347 RID: 62279 RVA: 0x003F83F1 File Offset: 0x003F65F1
		public int[] SideEffectArg { get; set; }

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600F348 RID: 62280 RVA: 0x003F83FA File Offset: 0x003F65FA
		// (set) Token: 0x0600F349 RID: 62281 RVA: 0x003F8402 File Offset: 0x003F6602
		public int ID { get; set; }

		// Token: 0x0600F34A RID: 62282 RVA: 0x003F840C File Offset: 0x003F660C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SideEffect = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.SideEffect[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SideEffectArg = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.SideEffectArg[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
