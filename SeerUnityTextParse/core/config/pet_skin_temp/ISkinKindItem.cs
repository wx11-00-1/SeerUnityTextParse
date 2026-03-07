using System;

namespace core.config.pet_skin_temp
{
	// Token: 0x02002201 RID: 8705
	public class ISkinKindItem
	{
		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06010B6B RID: 68459 RVA: 0x0045C612 File Offset: 0x0045A812
		// (set) Token: 0x06010B6C RID: 68460 RVA: 0x0045C61A File Offset: 0x0045A81A
		public int ID { get; set; }

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06010B6D RID: 68461 RVA: 0x0045C623 File Offset: 0x0045A823
		// (set) Token: 0x06010B6E RID: 68462 RVA: 0x0045C62B File Offset: 0x0045A82B
		public int LifeTime { get; set; }

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06010B6F RID: 68463 RVA: 0x0045C634 File Offset: 0x0045A834
		// (set) Token: 0x06010B70 RID: 68464 RVA: 0x0045C63C File Offset: 0x0045A83C
		public int SkinType { get; set; }

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06010B71 RID: 68465 RVA: 0x0045C645 File Offset: 0x0045A845
		// (set) Token: 0x06010B72 RID: 68466 RVA: 0x0045C64D File Offset: 0x0045A84D
		public int Type { get; set; }

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06010B73 RID: 68467 RVA: 0x0045C656 File Offset: 0x0045A856
		// (set) Token: 0x06010B74 RID: 68468 RVA: 0x0045C65E File Offset: 0x0045A85E
		public int Year { get; set; }

		// Token: 0x06010B75 RID: 68469 RVA: 0x0045C668 File Offset: 0x0045A868
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SkinType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Year = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
