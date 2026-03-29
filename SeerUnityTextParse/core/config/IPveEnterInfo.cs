using System;

namespace core.config
{
	// Token: 0x0200230D RID: 8973
	public class IPveEnterInfo : IConfigItem
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x0601111A RID: 69914 RVA: 0x00495E24 File Offset: 0x00494024
		// (set) Token: 0x0601111B RID: 69915 RVA: 0x00495E2C File Offset: 0x0049402C
		public string openParam { get; set; }

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0601111C RID: 69916 RVA: 0x00495E35 File Offset: 0x00494035
		// (set) Token: 0x0601111D RID: 69917 RVA: 0x00495E3D File Offset: 0x0049403D
		public string pveName { get; set; }

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0601111E RID: 69918 RVA: 0x00495E46 File Offset: 0x00494046
		// (set) Token: 0x0601111F RID: 69919 RVA: 0x00495E4E File Offset: 0x0049404E
		public string res { get; set; }

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06011120 RID: 69920 RVA: 0x00495E57 File Offset: 0x00494057
		// (set) Token: 0x06011121 RID: 69921 RVA: 0x00495E5F File Offset: 0x0049405F
		public string reward { get; set; }

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06011122 RID: 69922 RVA: 0x00495E68 File Offset: 0x00494068
		// (set) Token: 0x06011123 RID: 69923 RVA: 0x00495E70 File Offset: 0x00494070
		public string statLog { get; set; }

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06011124 RID: 69924 RVA: 0x00495E79 File Offset: 0x00494079
		// (set) Token: 0x06011125 RID: 69925 RVA: 0x00495E81 File Offset: 0x00494081
		public string timeLimit { get; set; }

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06011126 RID: 69926 RVA: 0x00495E8A File Offset: 0x0049408A
		// (set) Token: 0x06011127 RID: 69927 RVA: 0x00495E92 File Offset: 0x00494092
		public int id { get; set; }

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06011128 RID: 69928 RVA: 0x00495E9B File Offset: 0x0049409B
		// (set) Token: 0x06011129 RID: 69929 RVA: 0x00495EA3 File Offset: 0x004940A3
		public int isOpen { get; set; }

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x0601112A RID: 69930 RVA: 0x00495EAC File Offset: 0x004940AC
		// (set) Token: 0x0601112B RID: 69931 RVA: 0x00495EB4 File Offset: 0x004940B4
		public int isShow { get; set; }

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x0601112C RID: 69932 RVA: 0x00495EBD File Offset: 0x004940BD
		// (set) Token: 0x0601112D RID: 69933 RVA: 0x00495EC5 File Offset: 0x004940C5
		public int kind { get; set; }

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0601112E RID: 69934 RVA: 0x00495ECE File Offset: 0x004940CE
		// (set) Token: 0x0601112F RID: 69935 RVA: 0x00495ED6 File Offset: 0x004940D6
		public int moduleID { get; set; }

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06011130 RID: 69936 RVA: 0x00495EDF File Offset: 0x004940DF
		// (set) Token: 0x06011131 RID: 69937 RVA: 0x00495EE7 File Offset: 0x004940E7
		public int monsterid { get; set; }

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06011132 RID: 69938 RVA: 0x00495EF0 File Offset: 0x004940F0
		// (set) Token: 0x06011133 RID: 69939 RVA: 0x00495EF8 File Offset: 0x004940F8
		public int order { get; set; }

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06011134 RID: 69940 RVA: 0x00495F01 File Offset: 0x00494101
		// (set) Token: 0x06011135 RID: 69941 RVA: 0x00495F09 File Offset: 0x00494109
		public int showType { get; set; }

		// Token: 0x06011136 RID: 69942 RVA: 0x00495F14 File Offset: 0x00494114
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isOpen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moduleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.openParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pveName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.res = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statLog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timeLimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
