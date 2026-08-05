using System;

namespace core.config
{
	// Token: 0x020026C7 RID: 9927
	public class IActivityTimeUpdateConfigInfo : IConfigItem
	{
		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x060138CB RID: 80075 RVA: 0x00584FF0 File Offset: 0x005831F0
		// (set) Token: 0x060138CC RID: 80076 RVA: 0x00584FF8 File Offset: 0x005831F8
		public string beginning { get; set; }

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x060138CD RID: 80077 RVA: 0x00585001 File Offset: 0x00583201
		// (set) Token: 0x060138CE RID: 80078 RVA: 0x00585009 File Offset: 0x00583209
		public string ending { get; set; }

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x060138CF RID: 80079 RVA: 0x00585012 File Offset: 0x00583212
		// (set) Token: 0x060138D0 RID: 80080 RVA: 0x0058501A File Offset: 0x0058321A
		public string name { get; set; }

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x060138D1 RID: 80081 RVA: 0x00585023 File Offset: 0x00583223
		// (set) Token: 0x060138D2 RID: 80082 RVA: 0x0058502B File Offset: 0x0058322B
		public string parametersDesc { get; set; }

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060138D3 RID: 80083 RVA: 0x00585034 File Offset: 0x00583234
		// (set) Token: 0x060138D4 RID: 80084 RVA: 0x0058503C File Offset: 0x0058323C
		public int id { get; set; }

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060138D5 RID: 80085 RVA: 0x00585045 File Offset: 0x00583245
		// (set) Token: 0x060138D6 RID: 80086 RVA: 0x0058504D File Offset: 0x0058324D
		public int parameters1 { get; set; }

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x060138D7 RID: 80087 RVA: 0x00585056 File Offset: 0x00583256
		// (set) Token: 0x060138D8 RID: 80088 RVA: 0x0058505E File Offset: 0x0058325E
		public int parameters2 { get; set; }

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x060138D9 RID: 80089 RVA: 0x00585067 File Offset: 0x00583267
		// (set) Token: 0x060138DA RID: 80090 RVA: 0x0058506F File Offset: 0x0058326F
		public int parameters3 { get; set; }

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x060138DB RID: 80091 RVA: 0x00585078 File Offset: 0x00583278
		// (set) Token: 0x060138DC RID: 80092 RVA: 0x00585080 File Offset: 0x00583280
		public int parameters4 { get; set; }

		// Token: 0x060138DD RID: 80093 RVA: 0x0058508C File Offset: 0x0058328C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.parameters1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.parameters2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.parameters3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.parameters4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.parametersDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
