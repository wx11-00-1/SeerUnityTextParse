using System;

namespace core.config
{
	// Token: 0x02001D02 RID: 7426
	public class IChessGameSkillInfo : IConfigItem
	{
		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600D878 RID: 55416 RVA: 0x003CF5D4 File Offset: 0x003CD7D4
		// (set) Token: 0x0600D879 RID: 55417 RVA: 0x003CF5DC File Offset: 0x003CD7DC
		public string condition { get; set; }

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600D87A RID: 55418 RVA: 0x003CF5E5 File Offset: 0x003CD7E5
		// (set) Token: 0x0600D87B RID: 55419 RVA: 0x003CF5ED File Offset: 0x003CD7ED
		public string mark { get; set; }

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600D87C RID: 55420 RVA: 0x003CF5F6 File Offset: 0x003CD7F6
		// (set) Token: 0x0600D87D RID: 55421 RVA: 0x003CF5FE File Offset: 0x003CD7FE
		public string skillact { get; set; }

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600D87E RID: 55422 RVA: 0x003CF607 File Offset: 0x003CD807
		// (set) Token: 0x0600D87F RID: 55423 RVA: 0x003CF60F File Offset: 0x003CD80F
		public string skillcarton { get; set; }

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600D880 RID: 55424 RVA: 0x003CF618 File Offset: 0x003CD818
		// (set) Token: 0x0600D881 RID: 55425 RVA: 0x003CF620 File Offset: 0x003CD820
		public string skilldesc { get; set; }

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600D882 RID: 55426 RVA: 0x003CF629 File Offset: 0x003CD829
		// (set) Token: 0x0600D883 RID: 55427 RVA: 0x003CF631 File Offset: 0x003CD831
		public string skilleffect { get; set; }

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600D884 RID: 55428 RVA: 0x003CF63A File Offset: 0x003CD83A
		// (set) Token: 0x0600D885 RID: 55429 RVA: 0x003CF642 File Offset: 0x003CD842
		public string skillicon { get; set; }

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600D886 RID: 55430 RVA: 0x003CF64B File Offset: 0x003CD84B
		// (set) Token: 0x0600D887 RID: 55431 RVA: 0x003CF653 File Offset: 0x003CD853
		public string skillname { get; set; }

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600D888 RID: 55432 RVA: 0x003CF65C File Offset: 0x003CD85C
		// (set) Token: 0x0600D889 RID: 55433 RVA: 0x003CF664 File Offset: 0x003CD864
		public string skillsound { get; set; }

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600D88A RID: 55434 RVA: 0x003CF66D File Offset: 0x003CD86D
		// (set) Token: 0x0600D88B RID: 55435 RVA: 0x003CF675 File Offset: 0x003CD875
		public int id { get; set; }

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600D88C RID: 55436 RVA: 0x003CF67E File Offset: 0x003CD87E
		// (set) Token: 0x0600D88D RID: 55437 RVA: 0x003CF686 File Offset: 0x003CD886
		public int skilltype { get; set; }

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600D88E RID: 55438 RVA: 0x003CF68F File Offset: 0x003CD88F
		// (set) Token: 0x0600D88F RID: 55439 RVA: 0x003CF697 File Offset: 0x003CD897
		public int takerange { get; set; }

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600D890 RID: 55440 RVA: 0x003CF6A0 File Offset: 0x003CD8A0
		// (set) Token: 0x0600D891 RID: 55441 RVA: 0x003CF6A8 File Offset: 0x003CD8A8
		public int takerangetype { get; set; }

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600D892 RID: 55442 RVA: 0x003CF6B1 File Offset: 0x003CD8B1
		// (set) Token: 0x0600D893 RID: 55443 RVA: 0x003CF6B9 File Offset: 0x003CD8B9
		public int userangelength { get; set; }

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600D894 RID: 55444 RVA: 0x003CF6C2 File Offset: 0x003CD8C2
		// (set) Token: 0x0600D895 RID: 55445 RVA: 0x003CF6CA File Offset: 0x003CD8CA
		public int userangetype { get; set; }

		// Token: 0x0600D896 RID: 55446 RVA: 0x003CF6D4 File Offset: 0x003CD8D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.condition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mark = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillact = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillcarton = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skilldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skilleffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillicon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillsound = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skilltype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.takerange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.takerangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userangelength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
