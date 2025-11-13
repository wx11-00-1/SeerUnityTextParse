using System;

namespace core.config.moves
{
	// Token: 0x02001FA5 RID: 8101
	public class IMoveItem
	{
		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600F37A RID: 62330 RVA: 0x003F87FC File Offset: 0x003F69FC
		// (set) Token: 0x0600F37B RID: 62331 RVA: 0x003F8804 File Offset: 0x003F6A04
		public string info { get; set; }

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x0600F37C RID: 62332 RVA: 0x003F880D File Offset: 0x003F6A0D
		// (set) Token: 0x0600F37D RID: 62333 RVA: 0x003F8815 File Offset: 0x003F6A15
		public string Name { get; set; }

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x0600F37E RID: 62334 RVA: 0x003F881E File Offset: 0x003F6A1E
		// (set) Token: 0x0600F37F RID: 62335 RVA: 0x003F8826 File Offset: 0x003F6A26
		public int[] FriendSideEffect { get; set; }

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600F380 RID: 62336 RVA: 0x003F882F File Offset: 0x003F6A2F
		// (set) Token: 0x0600F381 RID: 62337 RVA: 0x003F8837 File Offset: 0x003F6A37
		public int[] FriendSideEffectArg { get; set; }

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x0600F382 RID: 62338 RVA: 0x003F8840 File Offset: 0x003F6A40
		// (set) Token: 0x0600F383 RID: 62339 RVA: 0x003F8848 File Offset: 0x003F6A48
		public int[] SideEffect { get; set; }

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600F384 RID: 62340 RVA: 0x003F8851 File Offset: 0x003F6A51
		// (set) Token: 0x0600F385 RID: 62341 RVA: 0x003F8859 File Offset: 0x003F6A59
		public int[] SideEffectArg { get; set; }

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600F386 RID: 62342 RVA: 0x003F8862 File Offset: 0x003F6A62
		// (set) Token: 0x0600F387 RID: 62343 RVA: 0x003F886A File Offset: 0x003F6A6A
		public int AtkNum { get; set; }

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600F388 RID: 62344 RVA: 0x003F8873 File Offset: 0x003F6A73
		// (set) Token: 0x0600F389 RID: 62345 RVA: 0x003F887B File Offset: 0x003F6A7B
		public int AtkType { get; set; }

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600F38A RID: 62346 RVA: 0x003F8884 File Offset: 0x003F6A84
		// (set) Token: 0x0600F38B RID: 62347 RVA: 0x003F888C File Offset: 0x003F6A8C
		public int Category { get; set; }

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600F38C RID: 62348 RVA: 0x003F8895 File Offset: 0x003F6A95
		// (set) Token: 0x0600F38D RID: 62349 RVA: 0x003F889D File Offset: 0x003F6A9D
		public int ID { get; set; }

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600F38E RID: 62350 RVA: 0x003F88A6 File Offset: 0x003F6AA6
		// (set) Token: 0x0600F38F RID: 62351 RVA: 0x003F88AE File Offset: 0x003F6AAE
		public int MaxPP { get; set; }

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600F390 RID: 62352 RVA: 0x003F88B7 File Offset: 0x003F6AB7
		// (set) Token: 0x0600F391 RID: 62353 RVA: 0x003F88BF File Offset: 0x003F6ABF
		public int MonID { get; set; }

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600F392 RID: 62354 RVA: 0x003F88C8 File Offset: 0x003F6AC8
		// (set) Token: 0x0600F393 RID: 62355 RVA: 0x003F88D0 File Offset: 0x003F6AD0
		public int MustHit { get; set; }

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600F394 RID: 62356 RVA: 0x003F88D9 File Offset: 0x003F6AD9
		// (set) Token: 0x0600F395 RID: 62357 RVA: 0x003F88E1 File Offset: 0x003F6AE1
		public int ordinary { get; set; }

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x0600F396 RID: 62358 RVA: 0x003F88EA File Offset: 0x003F6AEA
		// (set) Token: 0x0600F397 RID: 62359 RVA: 0x003F88F2 File Offset: 0x003F6AF2
		public int Power { get; set; }

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600F398 RID: 62360 RVA: 0x003F88FB File Offset: 0x003F6AFB
		// (set) Token: 0x0600F399 RID: 62361 RVA: 0x003F8903 File Offset: 0x003F6B03
		public int Priority { get; set; }

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600F39A RID: 62362 RVA: 0x003F890C File Offset: 0x003F6B0C
		// (set) Token: 0x0600F39B RID: 62363 RVA: 0x003F8914 File Offset: 0x003F6B14
		public int Type { get; set; }

		// Token: 0x0600F39C RID: 62364 RVA: 0x003F8920 File Offset: 0x003F6B20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.AtkNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.AtkType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Category = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.FriendSideEffect = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.FriendSideEffect[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.FriendSideEffectArg = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.FriendSideEffectArg[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MaxPP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MustHit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SideEffect = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.SideEffect[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SideEffectArg = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.SideEffectArg[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ordinary = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
