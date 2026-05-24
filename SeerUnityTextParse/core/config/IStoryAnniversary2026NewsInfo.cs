using System;

namespace core.config
{
	// Token: 0x020026C3 RID: 9923
	public class IStoryAnniversary2026NewsInfo : IConfigItem
	{
		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06013528 RID: 79144 RVA: 0x00523A1C File Offset: 0x00521C1C
		// (set) Token: 0x06013529 RID: 79145 RVA: 0x00523A24 File Offset: 0x00521C24
		public string desc { get; set; }

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0601352A RID: 79146 RVA: 0x00523A2D File Offset: 0x00521C2D
		// (set) Token: 0x0601352B RID: 79147 RVA: 0x00523A35 File Offset: 0x00521C35
		public string image { get; set; }

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0601352C RID: 79148 RVA: 0x00523A3E File Offset: 0x00521C3E
		// (set) Token: 0x0601352D RID: 79149 RVA: 0x00523A46 File Offset: 0x00521C46
		public string name { get; set; }

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0601352E RID: 79150 RVA: 0x00523A4F File Offset: 0x00521C4F
		// (set) Token: 0x0601352F RID: 79151 RVA: 0x00523A57 File Offset: 0x00521C57
		public string time { get; set; }

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06013530 RID: 79152 RVA: 0x00523A60 File Offset: 0x00521C60
		// (set) Token: 0x06013531 RID: 79153 RVA: 0x00523A68 File Offset: 0x00521C68
		public int id { get; set; }

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06013532 RID: 79154 RVA: 0x00523A71 File Offset: 0x00521C71
		// (set) Token: 0x06013533 RID: 79155 RVA: 0x00523A79 File Offset: 0x00521C79
		public int sort { get; set; }

		// Token: 0x06013534 RID: 79156 RVA: 0x00523A84 File Offset: 0x00521C84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
