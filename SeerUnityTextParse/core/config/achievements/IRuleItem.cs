using System;

namespace core.config.achievements
{
	// Token: 0x02002087 RID: 8327
	public class IRuleItem
	{
		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600FE31 RID: 65073 RVA: 0x00404040 File Offset: 0x00402240
		// (set) Token: 0x0600FE32 RID: 65074 RVA: 0x00404048 File Offset: 0x00402248
		public string abtext { get; set; }

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600FE33 RID: 65075 RVA: 0x00404051 File Offset: 0x00402251
		// (set) Token: 0x0600FE34 RID: 65076 RVA: 0x00404059 File Offset: 0x00402259
		public string achName { get; set; }

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600FE35 RID: 65077 RVA: 0x00404062 File Offset: 0x00402262
		// (set) Token: 0x0600FE36 RID: 65078 RVA: 0x0040406A File Offset: 0x0040226A
		public string Desc { get; set; }

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600FE37 RID: 65079 RVA: 0x00404073 File Offset: 0x00402273
		// (set) Token: 0x0600FE38 RID: 65080 RVA: 0x0040407B File Offset: 0x0040227B
		public string Threshold { get; set; }

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600FE39 RID: 65081 RVA: 0x00404084 File Offset: 0x00402284
		// (set) Token: 0x0600FE3A RID: 65082 RVA: 0x0040408C File Offset: 0x0040228C
		public string title { get; set; }

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600FE3B RID: 65083 RVA: 0x00404095 File Offset: 0x00402295
		// (set) Token: 0x0600FE3C RID: 65084 RVA: 0x0040409D File Offset: 0x0040229D
		public string titleColor { get; set; }

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600FE3D RID: 65085 RVA: 0x004040A6 File Offset: 0x004022A6
		// (set) Token: 0x0600FE3E RID: 65086 RVA: 0x004040AE File Offset: 0x004022AE
		public int AbilityTitle { get; set; }

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600FE3F RID: 65087 RVA: 0x004040B7 File Offset: 0x004022B7
		// (set) Token: 0x0600FE40 RID: 65088 RVA: 0x004040BF File Offset: 0x004022BF
		public int AchievementPoint { get; set; }

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600FE41 RID: 65089 RVA: 0x004040C8 File Offset: 0x004022C8
		// (set) Token: 0x0600FE42 RID: 65090 RVA: 0x004040D0 File Offset: 0x004022D0
		public int hide { get; set; }

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600FE43 RID: 65091 RVA: 0x004040D9 File Offset: 0x004022D9
		// (set) Token: 0x0600FE44 RID: 65092 RVA: 0x004040E1 File Offset: 0x004022E1
		public int ID { get; set; }

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600FE45 RID: 65093 RVA: 0x004040EA File Offset: 0x004022EA
		// (set) Token: 0x0600FE46 RID: 65094 RVA: 0x004040F2 File Offset: 0x004022F2
		public int proicon { get; set; }

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600FE47 RID: 65095 RVA: 0x004040FB File Offset: 0x004022FB
		// (set) Token: 0x0600FE48 RID: 65096 RVA: 0x00404103 File Offset: 0x00402303
		public int SpeNameBonus { get; set; }

		// Token: 0x0600FE49 RID: 65097 RVA: 0x0040410C File Offset: 0x0040230C
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

		// Token: 0x0400F682 RID: 63106
		public int branchId;

		// Token: 0x0400F683 RID: 63107
		public string branchDesc;

		// Token: 0x0400F684 RID: 63108
		public int isShowPro;

		// Token: 0x0400F685 RID: 63109
		public int IsSingle;

		// Token: 0x0400F686 RID: 63110
		public int type;
	}
}
