using System;

namespace core.config.figure_reward
{
	// Token: 0x02002039 RID: 8249
	public class IMonsterItem
	{
		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600FBE9 RID: 64489 RVA: 0x00401412 File Offset: 0x003FF612
		// (set) Token: 0x0600FBEA RID: 64490 RVA: 0x0040141A File Offset: 0x003FF61A
		public int ID { get; set; }

		// Token: 0x0600FBEB RID: 64491 RVA: 0x00401423 File Offset: 0x003FF623
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
