using System;

namespace core.config
{
	// Token: 0x02001E50 RID: 7760
	public class IStory1005Info : IConfigItem
	{
		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x0600E646 RID: 58950 RVA: 0x003E0B2C File Offset: 0x003DED2C
		// (set) Token: 0x0600E647 RID: 58951 RVA: 0x003E0B34 File Offset: 0x003DED34
		public string param1 { get; set; }

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600E648 RID: 58952 RVA: 0x003E0B3D File Offset: 0x003DED3D
		// (set) Token: 0x0600E649 RID: 58953 RVA: 0x003E0B45 File Offset: 0x003DED45
		public string param2 { get; set; }

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600E64A RID: 58954 RVA: 0x003E0B4E File Offset: 0x003DED4E
		// (set) Token: 0x0600E64B RID: 58955 RVA: 0x003E0B56 File Offset: 0x003DED56
		public string param3 { get; set; }

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x003E0B5F File Offset: 0x003DED5F
		// (set) Token: 0x0600E64D RID: 58957 RVA: 0x003E0B67 File Offset: 0x003DED67
		public string param4 { get; set; }

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600E64E RID: 58958 RVA: 0x003E0B70 File Offset: 0x003DED70
		// (set) Token: 0x0600E64F RID: 58959 RVA: 0x003E0B78 File Offset: 0x003DED78
		public string param5 { get; set; }

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600E650 RID: 58960 RVA: 0x003E0B81 File Offset: 0x003DED81
		// (set) Token: 0x0600E651 RID: 58961 RVA: 0x003E0B89 File Offset: 0x003DED89
		public float control { get; set; }

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x003E0B92 File Offset: 0x003DED92
		// (set) Token: 0x0600E653 RID: 58963 RVA: 0x003E0B9A File Offset: 0x003DED9A
		public int id { get; set; }

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x003E0BA3 File Offset: 0x003DEDA3
		// (set) Token: 0x0600E655 RID: 58965 RVA: 0x003E0BAB File Offset: 0x003DEDAB
		public int logic { get; set; }

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600E656 RID: 58966 RVA: 0x003E0BB4 File Offset: 0x003DEDB4
		// (set) Token: 0x0600E657 RID: 58967 RVA: 0x003E0BBC File Offset: 0x003DEDBC
		public int next { get; set; }

		// Token: 0x0600E658 RID: 58968 RVA: 0x003E0BC8 File Offset: 0x003DEDC8
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
