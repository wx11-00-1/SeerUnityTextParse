using System;

namespace core.config
{
	// Token: 0x02001D1E RID: 7454
	public class ICrystalLegendTalentInfo : IConfigItem
	{
		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x003D0C64 File Offset: 0x003CEE64
		// (set) Token: 0x0600D9A5 RID: 55717 RVA: 0x003D0C6C File Offset: 0x003CEE6C
		public string des { get; set; }

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x003D0C75 File Offset: 0x003CEE75
		// (set) Token: 0x0600D9A7 RID: 55719 RVA: 0x003D0C7D File Offset: 0x003CEE7D
		public string name { get; set; }

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600D9A8 RID: 55720 RVA: 0x003D0C86 File Offset: 0x003CEE86
		// (set) Token: 0x0600D9A9 RID: 55721 RVA: 0x003D0C8E File Offset: 0x003CEE8E
		public int consumeNum { get; set; }

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600D9AA RID: 55722 RVA: 0x003D0C97 File Offset: 0x003CEE97
		// (set) Token: 0x0600D9AB RID: 55723 RVA: 0x003D0C9F File Offset: 0x003CEE9F
		public int frontID { get; set; }

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600D9AC RID: 55724 RVA: 0x003D0CA8 File Offset: 0x003CEEA8
		// (set) Token: 0x0600D9AD RID: 55725 RVA: 0x003D0CB0 File Offset: 0x003CEEB0
		public int iconID { get; set; }

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x003D0CB9 File Offset: 0x003CEEB9
		// (set) Token: 0x0600D9AF RID: 55727 RVA: 0x003D0CC1 File Offset: 0x003CEEC1
		public int id { get; set; }

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x003D0CCC File Offset: 0x003CEECC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.consumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.frontID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
