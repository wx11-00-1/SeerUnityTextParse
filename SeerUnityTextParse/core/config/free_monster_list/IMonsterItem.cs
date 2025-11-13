using System;

namespace core.config.free_monster_list
{
	// Token: 0x02002030 RID: 8240
	public class IMonsterItem
	{
		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600FB99 RID: 64409 RVA: 0x00400F34 File Offset: 0x003FF134
		// (set) Token: 0x0600FB9A RID: 64410 RVA: 0x00400F3C File Offset: 0x003FF13C
		public int isNew { get; set; }

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600FB9B RID: 64411 RVA: 0x00400F45 File Offset: 0x003FF145
		// (set) Token: 0x0600FB9C RID: 64412 RVA: 0x00400F4D File Offset: 0x003FF14D
		public int petId { get; set; }

		// Token: 0x0600FB9D RID: 64413 RVA: 0x00400F56 File Offset: 0x003FF156
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.isNew = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
