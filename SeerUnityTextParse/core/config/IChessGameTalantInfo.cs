using System;

namespace core.config
{
	// Token: 0x02001D06 RID: 7430
	public class IChessGameTalantInfo : IConfigItem
	{
		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x0600D8B8 RID: 55480 RVA: 0x003CFA68 File Offset: 0x003CDC68
		// (set) Token: 0x0600D8B9 RID: 55481 RVA: 0x003CFA70 File Offset: 0x003CDC70
		public string cost { get; set; }

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600D8BA RID: 55482 RVA: 0x003CFA79 File Offset: 0x003CDC79
		// (set) Token: 0x0600D8BB RID: 55483 RVA: 0x003CFA81 File Offset: 0x003CDC81
		public string desc { get; set; }

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600D8BC RID: 55484 RVA: 0x003CFA8A File Offset: 0x003CDC8A
		// (set) Token: 0x0600D8BD RID: 55485 RVA: 0x003CFA92 File Offset: 0x003CDC92
		public string effect { get; set; }

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600D8BE RID: 55486 RVA: 0x003CFA9B File Offset: 0x003CDC9B
		// (set) Token: 0x0600D8BF RID: 55487 RVA: 0x003CFAA3 File Offset: 0x003CDCA3
		public string icon { get; set; }

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x0600D8C0 RID: 55488 RVA: 0x003CFAAC File Offset: 0x003CDCAC
		// (set) Token: 0x0600D8C1 RID: 55489 RVA: 0x003CFAB4 File Offset: 0x003CDCB4
		public string name { get; set; }

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x0600D8C2 RID: 55490 RVA: 0x003CFABD File Offset: 0x003CDCBD
		// (set) Token: 0x0600D8C3 RID: 55491 RVA: 0x003CFAC5 File Offset: 0x003CDCC5
		public int front { get; set; }

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600D8C4 RID: 55492 RVA: 0x003CFACE File Offset: 0x003CDCCE
		// (set) Token: 0x0600D8C5 RID: 55493 RVA: 0x003CFAD6 File Offset: 0x003CDCD6
		public int group { get; set; }

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x003CFADF File Offset: 0x003CDCDF
		// (set) Token: 0x0600D8C7 RID: 55495 RVA: 0x003CFAE7 File Offset: 0x003CDCE7
		public int id { get; set; }

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x003CFAF0 File Offset: 0x003CDCF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cost = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.effect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.front = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
