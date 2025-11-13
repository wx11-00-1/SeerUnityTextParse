using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F4C RID: 8012
	public class ITaskItem
	{
		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600F050 RID: 61520 RVA: 0x003F4AB9 File Offset: 0x003F2CB9
		// (set) Token: 0x0600F051 RID: 61521 RVA: 0x003F4AC1 File Offset: 0x003F2CC1
		public IAdvances Advances { get; set; }

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600F052 RID: 61522 RVA: 0x003F4ACA File Offset: 0x003F2CCA
		// (set) Token: 0x0600F053 RID: 61523 RVA: 0x003F4AD2 File Offset: 0x003F2CD2
		public IBattle Battle { get; set; }

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x0600F054 RID: 61524 RVA: 0x003F4ADB File Offset: 0x003F2CDB
		// (set) Token: 0x0600F055 RID: 61525 RVA: 0x003F4AE3 File Offset: 0x003F2CE3
		public string Desc { get; set; }

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600F056 RID: 61526 RVA: 0x003F4AEC File Offset: 0x003F2CEC
		// (set) Token: 0x0600F057 RID: 61527 RVA: 0x003F4AF4 File Offset: 0x003F2CF4
		public IExchange Exchange { get; set; }

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x0600F058 RID: 61528 RVA: 0x003F4AFD File Offset: 0x003F2CFD
		// (set) Token: 0x0600F059 RID: 61529 RVA: 0x003F4B05 File Offset: 0x003F2D05
		public int AllProgress { get; set; }

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x0600F05A RID: 61530 RVA: 0x003F4B0E File Offset: 0x003F2D0E
		// (set) Token: 0x0600F05B RID: 61531 RVA: 0x003F4B16 File Offset: 0x003F2D16
		public int BattleBoss { get; set; }

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x0600F05C RID: 61532 RVA: 0x003F4B1F File Offset: 0x003F2D1F
		// (set) Token: 0x0600F05D RID: 61533 RVA: 0x003F4B27 File Offset: 0x003F2D27
		public int ID { get; set; }

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x0600F05E RID: 61534 RVA: 0x003F4B30 File Offset: 0x003F2D30
		// (set) Token: 0x0600F05F RID: 61535 RVA: 0x003F4B38 File Offset: 0x003F2D38
		public int OutItemKey { get; set; }

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x0600F060 RID: 61536 RVA: 0x003F4B41 File Offset: 0x003F2D41
		// (set) Token: 0x0600F061 RID: 61537 RVA: 0x003F4B49 File Offset: 0x003F2D49
		public int PerCostCoinA { get; set; }

		// Token: 0x0600F062 RID: 61538 RVA: 0x003F4B54 File Offset: 0x003F2D54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Advances = new IAdvances();
				this.Advances.Parse(bytes, ref byteIndex);
			}
			this.AllProgress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Battle = new IBattle();
				this.Battle.Parse(bytes, ref byteIndex);
			}
			this.BattleBoss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Exchange = new IExchange();
				this.Exchange.Parse(bytes, ref byteIndex);
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.OutItemKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PerCostCoinA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
