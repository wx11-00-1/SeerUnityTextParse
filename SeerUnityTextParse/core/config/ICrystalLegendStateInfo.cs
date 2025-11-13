using System;

namespace core.config
{
	// Token: 0x02001D1C RID: 7452
	public class ICrystalLegendStateInfo : IConfigItem
	{
		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600D992 RID: 55698 RVA: 0x003D0B08 File Offset: 0x003CED08
		// (set) Token: 0x0600D993 RID: 55699 RVA: 0x003D0B10 File Offset: 0x003CED10
		public string battleDes { get; set; }

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600D994 RID: 55700 RVA: 0x003D0B19 File Offset: 0x003CED19
		// (set) Token: 0x0600D995 RID: 55701 RVA: 0x003D0B21 File Offset: 0x003CED21
		public string des { get; set; }

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x0600D996 RID: 55702 RVA: 0x003D0B2A File Offset: 0x003CED2A
		// (set) Token: 0x0600D997 RID: 55703 RVA: 0x003D0B32 File Offset: 0x003CED32
		public string name { get; set; }

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x0600D998 RID: 55704 RVA: 0x003D0B3B File Offset: 0x003CED3B
		// (set) Token: 0x0600D999 RID: 55705 RVA: 0x003D0B43 File Offset: 0x003CED43
		public int iconID { get; set; }

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x0600D99A RID: 55706 RVA: 0x003D0B4C File Offset: 0x003CED4C
		// (set) Token: 0x0600D99B RID: 55707 RVA: 0x003D0B54 File Offset: 0x003CED54
		public int id { get; set; }

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x0600D99C RID: 55708 RVA: 0x003D0B5D File Offset: 0x003CED5D
		// (set) Token: 0x0600D99D RID: 55709 RVA: 0x003D0B65 File Offset: 0x003CED65
		public int isApproved { get; set; }

		// Token: 0x0600D99E RID: 55710 RVA: 0x003D0B70 File Offset: 0x003CED70
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battleDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isApproved = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
