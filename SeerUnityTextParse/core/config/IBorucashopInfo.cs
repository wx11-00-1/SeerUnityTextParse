using System;

namespace core.config
{
	// Token: 0x02002495 RID: 9365
	public class IBorucashopInfo : IConfigItem
	{
		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06011CBE RID: 72894 RVA: 0x00505CA0 File Offset: 0x00503EA0
		// (set) Token: 0x06011CBF RID: 72895 RVA: 0x00505CA8 File Offset: 0x00503EA8
		public int endtime { get; set; }

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06011CC0 RID: 72896 RVA: 0x00505CB1 File Offset: 0x00503EB1
		// (set) Token: 0x06011CC1 RID: 72897 RVA: 0x00505CB9 File Offset: 0x00503EB9
		public int id { get; set; }

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06011CC2 RID: 72898 RVA: 0x00505CC2 File Offset: 0x00503EC2
		// (set) Token: 0x06011CC3 RID: 72899 RVA: 0x00505CCA File Offset: 0x00503ECA
		public int itemid { get; set; }

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06011CC4 RID: 72900 RVA: 0x00505CD3 File Offset: 0x00503ED3
		// (set) Token: 0x06011CC5 RID: 72901 RVA: 0x00505CDB File Offset: 0x00503EDB
		public int price { get; set; }

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06011CC6 RID: 72902 RVA: 0x00505CE4 File Offset: 0x00503EE4
		// (set) Token: 0x06011CC7 RID: 72903 RVA: 0x00505CEC File Offset: 0x00503EEC
		public int quantity { get; set; }

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06011CC8 RID: 72904 RVA: 0x00505CF5 File Offset: 0x00503EF5
		// (set) Token: 0x06011CC9 RID: 72905 RVA: 0x00505CFD File Offset: 0x00503EFD
		public int quota { get; set; }

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06011CCA RID: 72906 RVA: 0x00505D06 File Offset: 0x00503F06
		// (set) Token: 0x06011CCB RID: 72907 RVA: 0x00505D0E File Offset: 0x00503F0E
		public int starttime { get; set; }

		// Token: 0x06011CCC RID: 72908 RVA: 0x00505D18 File Offset: 0x00503F18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
