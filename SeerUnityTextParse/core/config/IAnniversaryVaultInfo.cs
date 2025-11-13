using System;

namespace core.config
{
	// Token: 0x02001CA0 RID: 7328
	public class IAnniversaryVaultInfo : IConfigItem
	{
		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x0600D43A RID: 54330 RVA: 0x003CA458 File Offset: 0x003C8658
		// (set) Token: 0x0600D43B RID: 54331 RVA: 0x003CA460 File Offset: 0x003C8660
		public string commodity { get; set; }

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600D43C RID: 54332 RVA: 0x003CA469 File Offset: 0x003C8669
		// (set) Token: 0x0600D43D RID: 54333 RVA: 0x003CA471 File Offset: 0x003C8671
		public string petinfo { get; set; }

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600D43E RID: 54334 RVA: 0x003CA47A File Offset: 0x003C867A
		// (set) Token: 0x0600D43F RID: 54335 RVA: 0x003CA482 File Offset: 0x003C8682
		public int id { get; set; }

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600D440 RID: 54336 RVA: 0x003CA48B File Offset: 0x003C868B
		// (set) Token: 0x0600D441 RID: 54337 RVA: 0x003CA493 File Offset: 0x003C8693
		public int needID { get; set; }

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x0600D442 RID: 54338 RVA: 0x003CA49C File Offset: 0x003C869C
		// (set) Token: 0x0600D443 RID: 54339 RVA: 0x003CA4A4 File Offset: 0x003C86A4
		public int needNum { get; set; }

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x0600D444 RID: 54340 RVA: 0x003CA4AD File Offset: 0x003C86AD
		// (set) Token: 0x0600D445 RID: 54341 RVA: 0x003CA4B5 File Offset: 0x003C86B5
		public int needtype { get; set; }

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x0600D446 RID: 54342 RVA: 0x003CA4BE File Offset: 0x003C86BE
		// (set) Token: 0x0600D447 RID: 54343 RVA: 0x003CA4C6 File Offset: 0x003C86C6
		public int price { get; set; }

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600D448 RID: 54344 RVA: 0x003CA4CF File Offset: 0x003C86CF
		// (set) Token: 0x0600D449 RID: 54345 RVA: 0x003CA4D7 File Offset: 0x003C86D7
		public int quantity { get; set; }

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600D44A RID: 54346 RVA: 0x003CA4E0 File Offset: 0x003C86E0
		// (set) Token: 0x0600D44B RID: 54347 RVA: 0x003CA4E8 File Offset: 0x003C86E8
		public int tab { get; set; }

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x0600D44C RID: 54348 RVA: 0x003CA4F1 File Offset: 0x003C86F1
		// (set) Token: 0x0600D44D RID: 54349 RVA: 0x003CA4F9 File Offset: 0x003C86F9
		public int unique { get; set; }

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x0600D44E RID: 54350 RVA: 0x003CA502 File Offset: 0x003C8702
		// (set) Token: 0x0600D44F RID: 54351 RVA: 0x003CA50A File Offset: 0x003C870A
		public int userInfoId { get; set; }

		// Token: 0x0600D450 RID: 54352 RVA: 0x003CA514 File Offset: 0x003C8714
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unique = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
