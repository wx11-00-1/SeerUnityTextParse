using System;

namespace core.config
{
	// Token: 0x02001DB0 RID: 7600
	public class INpcInfo : IConfigItem
	{
		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x0600DF70 RID: 57200 RVA: 0x003D8188 File Offset: 0x003D6388
		// (set) Token: 0x0600DF71 RID: 57201 RVA: 0x003D8190 File Offset: 0x003D6390
		public string emoji { get; set; }

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x0600DF72 RID: 57202 RVA: 0x003D8199 File Offset: 0x003D6399
		// (set) Token: 0x0600DF73 RID: 57203 RVA: 0x003D81A1 File Offset: 0x003D63A1
		public string initialposition { get; set; }

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600DF74 RID: 57204 RVA: 0x003D81AA File Offset: 0x003D63AA
		// (set) Token: 0x0600DF75 RID: 57205 RVA: 0x003D81B2 File Offset: 0x003D63B2
		public string name { get; set; }

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600DF76 RID: 57206 RVA: 0x003D81BB File Offset: 0x003D63BB
		// (set) Token: 0x0600DF77 RID: 57207 RVA: 0x003D81C3 File Offset: 0x003D63C3
		public string portrait { get; set; }

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x003D81CC File Offset: 0x003D63CC
		// (set) Token: 0x0600DF79 RID: 57209 RVA: 0x003D81D4 File Offset: 0x003D63D4
		public int CharacterID { get; set; }

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x0600DF7A RID: 57210 RVA: 0x003D81DD File Offset: 0x003D63DD
		// (set) Token: 0x0600DF7B RID: 57211 RVA: 0x003D81E5 File Offset: 0x003D63E5
		public int id { get; set; }

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x003D81EE File Offset: 0x003D63EE
		// (set) Token: 0x0600DF7D RID: 57213 RVA: 0x003D81F6 File Offset: 0x003D63F6
		public int scale { get; set; }

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x003D81FF File Offset: 0x003D63FF
		// (set) Token: 0x0600DF7F RID: 57215 RVA: 0x003D8207 File Offset: 0x003D6407
		public int silhouette { get; set; }

		// Token: 0x0600DF80 RID: 57216 RVA: 0x003D8210 File Offset: 0x003D6410
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.CharacterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.emoji = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.portrait = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.scale = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.silhouette = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
