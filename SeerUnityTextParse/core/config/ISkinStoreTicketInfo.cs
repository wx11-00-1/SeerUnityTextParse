using System;

namespace core.config
{
	// Token: 0x0200268F RID: 9871
	public class ISkinStoreTicketInfo : IConfigItem
	{
		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x060132F8 RID: 78584 RVA: 0x00520EF4 File Offset: 0x0051F0F4
		// (set) Token: 0x060132F9 RID: 78585 RVA: 0x00520EFC File Offset: 0x0051F0FC
		public int[] para { get; set; }

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x060132FA RID: 78586 RVA: 0x00520F05 File Offset: 0x0051F105
		// (set) Token: 0x060132FB RID: 78587 RVA: 0x00520F0D File Offset: 0x0051F10D
		public int id { get; set; }

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x060132FC RID: 78588 RVA: 0x00520F16 File Offset: 0x0051F116
		// (set) Token: 0x060132FD RID: 78589 RVA: 0x00520F1E File Offset: 0x0051F11E
		public int itemid { get; set; }

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x060132FE RID: 78590 RVA: 0x00520F27 File Offset: 0x0051F127
		// (set) Token: 0x060132FF RID: 78591 RVA: 0x00520F2F File Offset: 0x0051F12F
		public int productID { get; set; }

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06013300 RID: 78592 RVA: 0x00520F38 File Offset: 0x0051F138
		// (set) Token: 0x06013301 RID: 78593 RVA: 0x00520F40 File Offset: 0x0051F140
		public int tickettype { get; set; }

		// Token: 0x06013302 RID: 78594 RVA: 0x00520F4C File Offset: 0x0051F14C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.para = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.para[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tickettype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
