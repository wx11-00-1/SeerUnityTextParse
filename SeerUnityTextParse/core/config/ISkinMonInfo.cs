using System;

namespace core.config
{
	// Token: 0x0200268B RID: 9867
	public class ISkinMonInfo : IConfigItem
	{
		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x060132AE RID: 78510 RVA: 0x005209D4 File Offset: 0x0051EBD4
		// (set) Token: 0x060132AF RID: 78511 RVA: 0x005209DC File Offset: 0x0051EBDC
		public int[] oncereward { get; set; }

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x060132B0 RID: 78512 RVA: 0x005209E5 File Offset: 0x0051EBE5
		// (set) Token: 0x060132B1 RID: 78513 RVA: 0x005209ED File Offset: 0x0051EBED
		public int[] taskreward { get; set; }

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x060132B2 RID: 78514 RVA: 0x005209F6 File Offset: 0x0051EBF6
		// (set) Token: 0x060132B3 RID: 78515 RVA: 0x005209FE File Offset: 0x0051EBFE
		public int endtime { get; set; }

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x060132B4 RID: 78516 RVA: 0x00520A07 File Offset: 0x0051EC07
		// (set) Token: 0x060132B5 RID: 78517 RVA: 0x00520A0F File Offset: 0x0051EC0F
		public int id { get; set; }

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x060132B6 RID: 78518 RVA: 0x00520A18 File Offset: 0x0051EC18
		// (set) Token: 0x060132B7 RID: 78519 RVA: 0x00520A20 File Offset: 0x0051EC20
		public int itemID { get; set; }

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x060132B8 RID: 78520 RVA: 0x00520A29 File Offset: 0x0051EC29
		// (set) Token: 0x060132B9 RID: 78521 RVA: 0x00520A31 File Offset: 0x0051EC31
		public int onsaleprice { get; set; }

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x060132BA RID: 78522 RVA: 0x00520A3A File Offset: 0x0051EC3A
		// (set) Token: 0x060132BB RID: 78523 RVA: 0x00520A42 File Offset: 0x0051EC42
		public int price { get; set; }

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x060132BC RID: 78524 RVA: 0x00520A4B File Offset: 0x0051EC4B
		// (set) Token: 0x060132BD RID: 78525 RVA: 0x00520A53 File Offset: 0x0051EC53
		public int productID { get; set; }

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x060132BE RID: 78526 RVA: 0x00520A5C File Offset: 0x0051EC5C
		// (set) Token: 0x060132BF RID: 78527 RVA: 0x00520A64 File Offset: 0x0051EC64
		public int rewardtime { get; set; }

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x060132C0 RID: 78528 RVA: 0x00520A6D File Offset: 0x0051EC6D
		// (set) Token: 0x060132C1 RID: 78529 RVA: 0x00520A75 File Offset: 0x0051EC75
		public int starttime { get; set; }

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x060132C2 RID: 78530 RVA: 0x00520A7E File Offset: 0x0051EC7E
		// (set) Token: 0x060132C3 RID: 78531 RVA: 0x00520A86 File Offset: 0x0051EC86
		public int userinfo1 { get; set; }

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x060132C4 RID: 78532 RVA: 0x00520A8F File Offset: 0x0051EC8F
		// (set) Token: 0x060132C5 RID: 78533 RVA: 0x00520A97 File Offset: 0x0051EC97
		public int userinfo2 { get; set; }

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x060132C6 RID: 78534 RVA: 0x00520AA0 File Offset: 0x0051ECA0
		// (set) Token: 0x060132C7 RID: 78535 RVA: 0x00520AA8 File Offset: 0x0051ECA8
		public int userinfo3 { get; set; }

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x060132C8 RID: 78536 RVA: 0x00520AB1 File Offset: 0x0051ECB1
		// (set) Token: 0x060132C9 RID: 78537 RVA: 0x00520AB9 File Offset: 0x0051ECB9
		public int value { get; set; }

		// Token: 0x060132CA RID: 78538 RVA: 0x00520AC4 File Offset: 0x0051ECC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.oncereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.oncereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.onsaleprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.taskreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.taskreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.userinfo1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
