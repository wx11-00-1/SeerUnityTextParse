using System;

namespace core.config.peak_battle_mons
{
	// Token: 0x02001F74 RID: 8052
	public class IVirtualBattle
	{
		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x0600F1A2 RID: 61858 RVA: 0x003F657C File Offset: 0x003F477C
		// (set) Token: 0x0600F1A3 RID: 61859 RVA: 0x003F6584 File Offset: 0x003F4784
		public IPeakBtGlobalRule PeakBtGlobalRule { get; set; }

		// Token: 0x0600F1A4 RID: 61860 RVA: 0x003F658D File Offset: 0x003F478D
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PeakBtGlobalRule = new IPeakBtGlobalRule();
				this.PeakBtGlobalRule.Parse(bytes, ref byteIndex);
			}
		}
	}
}
