using System;

namespace core.config
{
	// Token: 0x02001E56 RID: 7766
	public class IStory1008Info : IConfigItem
	{
		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x0600E68E RID: 59022 RVA: 0x003E1078 File Offset: 0x003DF278
		// (set) Token: 0x0600E68F RID: 59023 RVA: 0x003E1080 File Offset: 0x003DF280
		public string param1 { get; set; }

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x0600E690 RID: 59024 RVA: 0x003E1089 File Offset: 0x003DF289
		// (set) Token: 0x0600E691 RID: 59025 RVA: 0x003E1091 File Offset: 0x003DF291
		public string param2 { get; set; }

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x0600E692 RID: 59026 RVA: 0x003E109A File Offset: 0x003DF29A
		// (set) Token: 0x0600E693 RID: 59027 RVA: 0x003E10A2 File Offset: 0x003DF2A2
		public string param3 { get; set; }

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x0600E694 RID: 59028 RVA: 0x003E10AB File Offset: 0x003DF2AB
		// (set) Token: 0x0600E695 RID: 59029 RVA: 0x003E10B3 File Offset: 0x003DF2B3
		public string param4 { get; set; }

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x0600E696 RID: 59030 RVA: 0x003E10BC File Offset: 0x003DF2BC
		// (set) Token: 0x0600E697 RID: 59031 RVA: 0x003E10C4 File Offset: 0x003DF2C4
		public string param5 { get; set; }

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600E698 RID: 59032 RVA: 0x003E10CD File Offset: 0x003DF2CD
		// (set) Token: 0x0600E699 RID: 59033 RVA: 0x003E10D5 File Offset: 0x003DF2D5
		public float control { get; set; }

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x0600E69A RID: 59034 RVA: 0x003E10DE File Offset: 0x003DF2DE
		// (set) Token: 0x0600E69B RID: 59035 RVA: 0x003E10E6 File Offset: 0x003DF2E6
		public int id { get; set; }

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x0600E69C RID: 59036 RVA: 0x003E10EF File Offset: 0x003DF2EF
		// (set) Token: 0x0600E69D RID: 59037 RVA: 0x003E10F7 File Offset: 0x003DF2F7
		public int logic { get; set; }

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x0600E69E RID: 59038 RVA: 0x003E1100 File Offset: 0x003DF300
		// (set) Token: 0x0600E69F RID: 59039 RVA: 0x003E1108 File Offset: 0x003DF308
		public int next { get; set; }

		// Token: 0x0600E6A0 RID: 59040 RVA: 0x003E1114 File Offset: 0x003DF314
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
