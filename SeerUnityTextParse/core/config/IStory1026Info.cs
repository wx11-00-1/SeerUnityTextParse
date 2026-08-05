using System;

namespace core.config
{
	// Token: 0x020029E9 RID: 10729
	public class IStory1026Info : IConfigItem
	{
		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x06015C2F RID: 89135 RVA: 0x005AFC38 File Offset: 0x005ADE38
		// (set) Token: 0x06015C30 RID: 89136 RVA: 0x005AFC40 File Offset: 0x005ADE40
		public string param1 { get; set; }

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06015C31 RID: 89137 RVA: 0x005AFC49 File Offset: 0x005ADE49
		// (set) Token: 0x06015C32 RID: 89138 RVA: 0x005AFC51 File Offset: 0x005ADE51
		public string param2 { get; set; }

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06015C33 RID: 89139 RVA: 0x005AFC5A File Offset: 0x005ADE5A
		// (set) Token: 0x06015C34 RID: 89140 RVA: 0x005AFC62 File Offset: 0x005ADE62
		public string param3 { get; set; }

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x06015C35 RID: 89141 RVA: 0x005AFC6B File Offset: 0x005ADE6B
		// (set) Token: 0x06015C36 RID: 89142 RVA: 0x005AFC73 File Offset: 0x005ADE73
		public string param4 { get; set; }

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06015C37 RID: 89143 RVA: 0x005AFC7C File Offset: 0x005ADE7C
		// (set) Token: 0x06015C38 RID: 89144 RVA: 0x005AFC84 File Offset: 0x005ADE84
		public string param5 { get; set; }

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06015C39 RID: 89145 RVA: 0x005AFC8D File Offset: 0x005ADE8D
		// (set) Token: 0x06015C3A RID: 89146 RVA: 0x005AFC95 File Offset: 0x005ADE95
		public float control { get; set; }

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06015C3B RID: 89147 RVA: 0x005AFC9E File Offset: 0x005ADE9E
		// (set) Token: 0x06015C3C RID: 89148 RVA: 0x005AFCA6 File Offset: 0x005ADEA6
		public int id { get; set; }

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06015C3D RID: 89149 RVA: 0x005AFCAF File Offset: 0x005ADEAF
		// (set) Token: 0x06015C3E RID: 89150 RVA: 0x005AFCB7 File Offset: 0x005ADEB7
		public int logic { get; set; }

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x06015C3F RID: 89151 RVA: 0x005AFCC0 File Offset: 0x005ADEC0
		// (set) Token: 0x06015C40 RID: 89152 RVA: 0x005AFCC8 File Offset: 0x005ADEC8
		public int next { get; set; }

		// Token: 0x06015C41 RID: 89153 RVA: 0x005AFCD4 File Offset: 0x005ADED4
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
