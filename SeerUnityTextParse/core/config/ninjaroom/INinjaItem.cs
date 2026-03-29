using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002513 RID: 9491
	public class INinjaItem : IConfigItem
	{
		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0601260C RID: 75276 RVA: 0x004B7C86 File Offset: 0x004B5E86
		// (set) Token: 0x0601260D RID: 75277 RVA: 0x004B7C8E File Offset: 0x004B5E8E
		public string lv { get; set; }

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0601260E RID: 75278 RVA: 0x004B7C97 File Offset: 0x004B5E97
		// (set) Token: 0x0601260F RID: 75279 RVA: 0x004B7C9F File Offset: 0x004B5E9F
		public string rewardcnt { get; set; }

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06012610 RID: 75280 RVA: 0x004B7CA8 File Offset: 0x004B5EA8
		// (set) Token: 0x06012611 RID: 75281 RVA: 0x004B7CB0 File Offset: 0x004B5EB0
		public string rewardid { get; set; }

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06012612 RID: 75282 RVA: 0x004B7CB9 File Offset: 0x004B5EB9
		// (set) Token: 0x06012613 RID: 75283 RVA: 0x004B7CC1 File Offset: 0x004B5EC1
		public string rewardtype { get; set; }

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x06012614 RID: 75284 RVA: 0x004B7CCA File Offset: 0x004B5ECA
		// (set) Token: 0x06012615 RID: 75285 RVA: 0x004B7CD2 File Offset: 0x004B5ED2
		public string show { get; set; }

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06012616 RID: 75286 RVA: 0x004B7CDB File Offset: 0x004B5EDB
		// (set) Token: 0x06012617 RID: 75287 RVA: 0x004B7CE3 File Offset: 0x004B5EE3
		public int creat { get; set; }

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06012618 RID: 75288 RVA: 0x004B7CEC File Offset: 0x004B5EEC
		// (set) Token: 0x06012619 RID: 75289 RVA: 0x004B7CF4 File Offset: 0x004B5EF4
		public int id { get; set; }

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0601261A RID: 75290 RVA: 0x004B7CFD File Offset: 0x004B5EFD
		// (set) Token: 0x0601261B RID: 75291 RVA: 0x004B7D05 File Offset: 0x004B5F05
		public int NewStatLog { get; set; }

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0601261C RID: 75292 RVA: 0x004B7D0E File Offset: 0x004B5F0E
		// (set) Token: 0x0601261D RID: 75293 RVA: 0x004B7D16 File Offset: 0x004B5F16
		public int rank { get; set; }

		// Token: 0x0601261E RID: 75294 RVA: 0x004B7D20 File Offset: 0x004B5F20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewStatLog = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.creat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lv = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.show = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
