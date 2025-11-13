using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F42 RID: 8002
	public class IAdvances
	{
		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x0600F002 RID: 61442 RVA: 0x003F4489 File Offset: 0x003F2689
		// (set) Token: 0x0600F003 RID: 61443 RVA: 0x003F4491 File Offset: 0x003F2691
		public IAdvEffect AdvEffect { get; set; }

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x0600F004 RID: 61444 RVA: 0x003F449A File Offset: 0x003F269A
		// (set) Token: 0x0600F005 RID: 61445 RVA: 0x003F44A2 File Offset: 0x003F26A2
		public IExMove exMove { get; set; }

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600F006 RID: 61446 RVA: 0x003F44AB File Offset: 0x003F26AB
		// (set) Token: 0x0600F007 RID: 61447 RVA: 0x003F44B3 File Offset: 0x003F26B3
		public IRace Race { get; set; }

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x0600F008 RID: 61448 RVA: 0x003F44BC File Offset: 0x003F26BC
		// (set) Token: 0x0600F009 RID: 61449 RVA: 0x003F44C4 File Offset: 0x003F26C4
		public ISpMove spMove { get; set; }

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x0600F00A RID: 61450 RVA: 0x003F44CD File Offset: 0x003F26CD
		// (set) Token: 0x0600F00B RID: 61451 RVA: 0x003F44D5 File Offset: 0x003F26D5
		public int AdvType { get; set; }

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x0600F00C RID: 61452 RVA: 0x003F44DE File Offset: 0x003F26DE
		// (set) Token: 0x0600F00D RID: 61453 RVA: 0x003F44E6 File Offset: 0x003F26E6
		public int MonsterId { get; set; }

		// Token: 0x0600F00E RID: 61454 RVA: 0x003F44F0 File Offset: 0x003F26F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AdvEffect = new IAdvEffect();
				this.AdvEffect.Parse(bytes, ref byteIndex);
			}
			this.AdvType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Race = new IRace();
				this.Race.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.exMove = new IExMove();
				this.exMove.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.spMove = new ISpMove();
				this.spMove.Parse(bytes, ref byteIndex);
			}
		}
	}
}
