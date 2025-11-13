using System;

namespace core.config.achievement_rule
{
	// Token: 0x02002085 RID: 8325
	public class IBranchItem
	{
		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600FE25 RID: 65061 RVA: 0x00403F9E File Offset: 0x0040219E
		// (set) Token: 0x0600FE26 RID: 65062 RVA: 0x00403FA6 File Offset: 0x004021A6
		public int ID { get; set; }

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600FE27 RID: 65063 RVA: 0x00403FAF File Offset: 0x004021AF
		// (set) Token: 0x0600FE28 RID: 65064 RVA: 0x00403FB7 File Offset: 0x004021B7
		public int IsSingle { get; set; }

		// Token: 0x0600FE29 RID: 65065 RVA: 0x00403FC0 File Offset: 0x004021C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsSingle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
