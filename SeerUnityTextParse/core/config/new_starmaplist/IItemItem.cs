using System;

namespace core.config.new_starmaplist
{
	// Token: 0x02002523 RID: 9507
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x060126AE RID: 75438 RVA: 0x004B8CC8 File Offset: 0x004B6EC8
		// (set) Token: 0x060126AF RID: 75439 RVA: 0x004B8CD0 File Offset: 0x004B6ED0
		public string name { get; set; }

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x060126B0 RID: 75440 RVA: 0x004B8CD9 File Offset: 0x004B6ED9
		// (set) Token: 0x060126B1 RID: 75441 RVA: 0x004B8CE1 File Offset: 0x004B6EE1
		public string StarID { get; set; }

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x060126B2 RID: 75442 RVA: 0x004B8CEA File Offset: 0x004B6EEA
		// (set) Token: 0x060126B3 RID: 75443 RVA: 0x004B8CF2 File Offset: 0x004B6EF2
		public int id { get; set; }

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x060126B4 RID: 75444 RVA: 0x004B8CFB File Offset: 0x004B6EFB
		// (set) Token: 0x060126B5 RID: 75445 RVA: 0x004B8D03 File Offset: 0x004B6F03
		public int isopen { get; set; }

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x060126B6 RID: 75446 RVA: 0x004B8D0C File Offset: 0x004B6F0C
		// (set) Token: 0x060126B7 RID: 75447 RVA: 0x004B8D14 File Offset: 0x004B6F14
		public int pic { get; set; }

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x060126B8 RID: 75448 RVA: 0x004B8D1D File Offset: 0x004B6F1D
		// (set) Token: 0x060126B9 RID: 75449 RVA: 0x004B8D25 File Offset: 0x004B6F25
		public int StarBG { get; set; }

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x060126BA RID: 75450 RVA: 0x004B8D2E File Offset: 0x004B6F2E
		// (set) Token: 0x060126BB RID: 75451 RVA: 0x004B8D36 File Offset: 0x004B6F36
		public int type { get; set; }

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x060126BC RID: 75452 RVA: 0x004B8D3F File Offset: 0x004B6F3F
		// (set) Token: 0x060126BD RID: 75453 RVA: 0x004B8D47 File Offset: 0x004B6F47
		public int uni { get; set; }

		// Token: 0x060126BE RID: 75454 RVA: 0x004B8D50 File Offset: 0x004B6F50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.StarBG = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StarID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.uni = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
