using System;

namespace core.config
{
	// Token: 0x02001C88 RID: 7304
	public class IActivityCenterInfo : IConfigItem
	{
		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x0600D2F6 RID: 54006 RVA: 0x003C8D8C File Offset: 0x003C6F8C
		// (set) Token: 0x0600D2F7 RID: 54007 RVA: 0x003C8D94 File Offset: 0x003C6F94
		public string args { get; set; }

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x0600D2F8 RID: 54008 RVA: 0x003C8D9D File Offset: 0x003C6F9D
		// (set) Token: 0x0600D2F9 RID: 54009 RVA: 0x003C8DA5 File Offset: 0x003C6FA5
		public string beginning { get; set; }

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x0600D2FA RID: 54010 RVA: 0x003C8DAE File Offset: 0x003C6FAE
		// (set) Token: 0x0600D2FB RID: 54011 RVA: 0x003C8DB6 File Offset: 0x003C6FB6
		public string ending { get; set; }

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x003C8DBF File Offset: 0x003C6FBF
		// (set) Token: 0x0600D2FD RID: 54013 RVA: 0x003C8DC7 File Offset: 0x003C6FC7
		public string labelName { get; set; }

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x003C8DD0 File Offset: 0x003C6FD0
		// (set) Token: 0x0600D2FF RID: 54015 RVA: 0x003C8DD8 File Offset: 0x003C6FD8
		public string name { get; set; }

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x0600D300 RID: 54016 RVA: 0x003C8DE1 File Offset: 0x003C6FE1
		// (set) Token: 0x0600D301 RID: 54017 RVA: 0x003C8DE9 File Offset: 0x003C6FE9
		public int channel { get; set; }

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600D302 RID: 54018 RVA: 0x003C8DF2 File Offset: 0x003C6FF2
		// (set) Token: 0x0600D303 RID: 54019 RVA: 0x003C8DFA File Offset: 0x003C6FFA
		public int Go { get; set; }

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x0600D304 RID: 54020 RVA: 0x003C8E03 File Offset: 0x003C7003
		// (set) Token: 0x0600D305 RID: 54021 RVA: 0x003C8E0B File Offset: 0x003C700B
		public int helptips { get; set; }

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x0600D306 RID: 54022 RVA: 0x003C8E14 File Offset: 0x003C7014
		// (set) Token: 0x0600D307 RID: 54023 RVA: 0x003C8E1C File Offset: 0x003C701C
		public int id { get; set; }

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x0600D308 RID: 54024 RVA: 0x003C8E25 File Offset: 0x003C7025
		// (set) Token: 0x0600D309 RID: 54025 RVA: 0x003C8E2D File Offset: 0x003C702D
		public int iOSreviewshow { get; set; }

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600D30A RID: 54026 RVA: 0x003C8E36 File Offset: 0x003C7036
		// (set) Token: 0x0600D30B RID: 54027 RVA: 0x003C8E3E File Offset: 0x003C703E
		public int isShow { get; set; }

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600D30C RID: 54028 RVA: 0x003C8E47 File Offset: 0x003C7047
		// (set) Token: 0x0600D30D RID: 54029 RVA: 0x003C8E4F File Offset: 0x003C704F
		public int redbadge { get; set; }

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600D30E RID: 54030 RVA: 0x003C8E58 File Offset: 0x003C7058
		// (set) Token: 0x0600D30F RID: 54031 RVA: 0x003C8E60 File Offset: 0x003C7060
		public int signType { get; set; }

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x003C8E69 File Offset: 0x003C7069
		// (set) Token: 0x0600D311 RID: 54033 RVA: 0x003C8E71 File Offset: 0x003C7071
		public int sorting { get; set; }

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600D312 RID: 54034 RVA: 0x003C8E7A File Offset: 0x003C707A
		// (set) Token: 0x0600D313 RID: 54035 RVA: 0x003C8E82 File Offset: 0x003C7082
		public int type { get; set; }

		// Token: 0x0600D314 RID: 54036 RVA: 0x003C8E8C File Offset: 0x003C708C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.channel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.helptips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.iOSreviewshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.labelName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.signType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
