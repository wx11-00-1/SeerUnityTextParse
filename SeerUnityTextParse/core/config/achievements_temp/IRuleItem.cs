using System;

namespace core.config.achievements_temp
{
	// Token: 0x0200235B RID: 9051
	public class IRuleItem
	{
		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06011A58 RID: 72280 RVA: 0x0046DF14 File Offset: 0x0046C114
		// (set) Token: 0x06011A59 RID: 72281 RVA: 0x0046DF1C File Offset: 0x0046C11C
		public string abtext { get; set; }

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06011A5A RID: 72282 RVA: 0x0046DF25 File Offset: 0x0046C125
		// (set) Token: 0x06011A5B RID: 72283 RVA: 0x0046DF2D File Offset: 0x0046C12D
		public string achName { get; set; }

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06011A5C RID: 72284 RVA: 0x0046DF36 File Offset: 0x0046C136
		// (set) Token: 0x06011A5D RID: 72285 RVA: 0x0046DF3E File Offset: 0x0046C13E
		public string Desc { get; set; }

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06011A5E RID: 72286 RVA: 0x0046DF47 File Offset: 0x0046C147
		// (set) Token: 0x06011A5F RID: 72287 RVA: 0x0046DF4F File Offset: 0x0046C14F
		public string Threshold { get; set; }

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06011A60 RID: 72288 RVA: 0x0046DF58 File Offset: 0x0046C158
		// (set) Token: 0x06011A61 RID: 72289 RVA: 0x0046DF60 File Offset: 0x0046C160
		public string title { get; set; }

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06011A62 RID: 72290 RVA: 0x0046DF69 File Offset: 0x0046C169
		// (set) Token: 0x06011A63 RID: 72291 RVA: 0x0046DF71 File Offset: 0x0046C171
		public string titleColor { get; set; }

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06011A64 RID: 72292 RVA: 0x0046DF7A File Offset: 0x0046C17A
		// (set) Token: 0x06011A65 RID: 72293 RVA: 0x0046DF82 File Offset: 0x0046C182
		public int AbilityTitle { get; set; }

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06011A66 RID: 72294 RVA: 0x0046DF8B File Offset: 0x0046C18B
		// (set) Token: 0x06011A67 RID: 72295 RVA: 0x0046DF93 File Offset: 0x0046C193
		public int AchievementPoint { get; set; }

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x06011A68 RID: 72296 RVA: 0x0046DF9C File Offset: 0x0046C19C
		// (set) Token: 0x06011A69 RID: 72297 RVA: 0x0046DFA4 File Offset: 0x0046C1A4
		public int hide { get; set; }

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x06011A6A RID: 72298 RVA: 0x0046DFAD File Offset: 0x0046C1AD
		// (set) Token: 0x06011A6B RID: 72299 RVA: 0x0046DFB5 File Offset: 0x0046C1B5
		public int ID { get; set; }

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06011A6C RID: 72300 RVA: 0x0046DFBE File Offset: 0x0046C1BE
		// (set) Token: 0x06011A6D RID: 72301 RVA: 0x0046DFC6 File Offset: 0x0046C1C6
		public int proicon { get; set; }

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06011A6E RID: 72302 RVA: 0x0046DFCF File Offset: 0x0046C1CF
		// (set) Token: 0x06011A6F RID: 72303 RVA: 0x0046DFD7 File Offset: 0x0046C1D7
		public int SpeNameBonus { get; set; }

		// Token: 0x06011A70 RID: 72304 RVA: 0x0046DFE0 File Offset: 0x0046C1E0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.AbilityTitle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.AchievementPoint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SpeNameBonus = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Threshold = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.abtext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.achName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.proicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.titleColor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
