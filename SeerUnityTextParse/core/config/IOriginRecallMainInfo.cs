using System;

namespace core.config
{
	// Token: 0x02001DB2 RID: 7602
	public class IOriginRecallMainInfo : IConfigItem
	{
		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x0600DF86 RID: 57222 RVA: 0x003D8324 File Offset: 0x003D6524
		// (set) Token: 0x0600DF87 RID: 57223 RVA: 0x003D832C File Offset: 0x003D652C
		public string contactid { get; set; }

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x0600DF88 RID: 57224 RVA: 0x003D8335 File Offset: 0x003D6535
		// (set) Token: 0x0600DF89 RID: 57225 RVA: 0x003D833D File Offset: 0x003D653D
		public string jump { get; set; }

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x003D8346 File Offset: 0x003D6546
		// (set) Token: 0x0600DF8B RID: 57227 RVA: 0x003D834E File Offset: 0x003D654E
		public string name { get; set; }

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x0600DF8C RID: 57228 RVA: 0x003D8357 File Offset: 0x003D6557
		// (set) Token: 0x0600DF8D RID: 57229 RVA: 0x003D835F File Offset: 0x003D655F
		public string petinfo { get; set; }

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x003D8368 File Offset: 0x003D6568
		// (set) Token: 0x0600DF8F RID: 57231 RVA: 0x003D8370 File Offset: 0x003D6570
		public string reward { get; set; }

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x003D8379 File Offset: 0x003D6579
		// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x003D8381 File Offset: 0x003D6581
		public string showdescribe { get; set; }

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x003D838A File Offset: 0x003D658A
		// (set) Token: 0x0600DF93 RID: 57235 RVA: 0x003D8392 File Offset: 0x003D6592
		public string showtime { get; set; }

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x0600DF94 RID: 57236 RVA: 0x003D839B File Offset: 0x003D659B
		// (set) Token: 0x0600DF95 RID: 57237 RVA: 0x003D83A3 File Offset: 0x003D65A3
		public int beginning { get; set; }

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x0600DF96 RID: 57238 RVA: 0x003D83AC File Offset: 0x003D65AC
		// (set) Token: 0x0600DF97 RID: 57239 RVA: 0x003D83B4 File Offset: 0x003D65B4
		public int id { get; set; }

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x003D83BD File Offset: 0x003D65BD
		// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x003D83C5 File Offset: 0x003D65C5
		public int jumptalkgroupId1 { get; set; }

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x003D83CE File Offset: 0x003D65CE
		// (set) Token: 0x0600DF9B RID: 57243 RVA: 0x003D83D6 File Offset: 0x003D65D6
		public int jumptalkgroupId2 { get; set; }

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x003D83DF File Offset: 0x003D65DF
		// (set) Token: 0x0600DF9D RID: 57245 RVA: 0x003D83E7 File Offset: 0x003D65E7
		public int level { get; set; }

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x0600DF9E RID: 57246 RVA: 0x003D83F0 File Offset: 0x003D65F0
		// (set) Token: 0x0600DF9F RID: 57247 RVA: 0x003D83F8 File Offset: 0x003D65F8
		public int showtype { get; set; }

		// Token: 0x0600DFA0 RID: 57248 RVA: 0x003D8404 File Offset: 0x003D6604
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.beginning = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.contactid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.jumptalkgroupId1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumptalkgroupId2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
