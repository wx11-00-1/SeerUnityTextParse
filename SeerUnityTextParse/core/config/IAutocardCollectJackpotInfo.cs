using System;

namespace core.config
{
	// Token: 0x0200256B RID: 9579
	public class IAutocardCollectJackpotInfo : IConfigItem
	{
		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06012901 RID: 76033 RVA: 0x00545D2C File Offset: 0x00543F2C
		// (set) Token: 0x06012902 RID: 76034 RVA: 0x00545D34 File Offset: 0x00543F34
		public int card_id { get; set; }

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06012903 RID: 76035 RVA: 0x00545D3D File Offset: 0x00543F3D
		// (set) Token: 0x06012904 RID: 76036 RVA: 0x00545D45 File Offset: 0x00543F45
		public int cardlevel { get; set; }

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06012905 RID: 76037 RVA: 0x00545D4E File Offset: 0x00543F4E
		// (set) Token: 0x06012906 RID: 76038 RVA: 0x00545D56 File Offset: 0x00543F56
		public int id { get; set; }

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06012907 RID: 76039 RVA: 0x00545D5F File Offset: 0x00543F5F
		// (set) Token: 0x06012908 RID: 76040 RVA: 0x00545D67 File Offset: 0x00543F67
		public int pro { get; set; }

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06012909 RID: 76041 RVA: 0x00545D70 File Offset: 0x00543F70
		// (set) Token: 0x0601290A RID: 76042 RVA: 0x00545D78 File Offset: 0x00543F78
		public int sesisson { get; set; }

		// Token: 0x0601290B RID: 76043 RVA: 0x00545D84 File Offset: 0x00543F84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.card_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cardlevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pro = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sesisson = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
