using System;

namespace core.config.move_stones
{
	// Token: 0x02001F9F RID: 8095
	public class IMoveStoneItem
	{
		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600F34C RID: 62284 RVA: 0x003F849E File Offset: 0x003F669E
		// (set) Token: 0x0600F34D RID: 62285 RVA: 0x003F84A6 File Offset: 0x003F66A6
		public IMoveEffectItem[] MoveEffect { get; set; }

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x0600F34E RID: 62286 RVA: 0x003F84AF File Offset: 0x003F66AF
		// (set) Token: 0x0600F34F RID: 62287 RVA: 0x003F84B7 File Offset: 0x003F66B7
		public string Name { get; set; }

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x0600F350 RID: 62288 RVA: 0x003F84C0 File Offset: 0x003F66C0
		// (set) Token: 0x0600F351 RID: 62289 RVA: 0x003F84C8 File Offset: 0x003F66C8
		public int ID { get; set; }

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x0600F352 RID: 62290 RVA: 0x003F84D1 File Offset: 0x003F66D1
		// (set) Token: 0x0600F353 RID: 62291 RVA: 0x003F84D9 File Offset: 0x003F66D9
		public int MaxPP { get; set; }

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600F354 RID: 62292 RVA: 0x003F84E2 File Offset: 0x003F66E2
		// (set) Token: 0x0600F355 RID: 62293 RVA: 0x003F84EA File Offset: 0x003F66EA
		public int Power { get; set; }

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600F356 RID: 62294 RVA: 0x003F84F3 File Offset: 0x003F66F3
		// (set) Token: 0x0600F357 RID: 62295 RVA: 0x003F84FB File Offset: 0x003F66FB
		public int Type { get; set; }

		// Token: 0x0600F358 RID: 62296 RVA: 0x003F8504 File Offset: 0x003F6704
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MaxPP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MoveEffect = new IMoveEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.MoveEffect[i] = new IMoveEffectItem();
					this.MoveEffect[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
