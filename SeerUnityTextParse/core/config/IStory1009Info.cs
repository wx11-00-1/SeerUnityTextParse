using System;

namespace core.config
{
	// Token: 0x02001E58 RID: 7768
	public class IStory1009Info : IConfigItem
	{
		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x0600E6A6 RID: 59046 RVA: 0x003E123C File Offset: 0x003DF43C
		// (set) Token: 0x0600E6A7 RID: 59047 RVA: 0x003E1244 File Offset: 0x003DF444
		public string param1 { get; set; }

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600E6A8 RID: 59048 RVA: 0x003E124D File Offset: 0x003DF44D
		// (set) Token: 0x0600E6A9 RID: 59049 RVA: 0x003E1255 File Offset: 0x003DF455
		public string param2 { get; set; }

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x003E125E File Offset: 0x003DF45E
		// (set) Token: 0x0600E6AB RID: 59051 RVA: 0x003E1266 File Offset: 0x003DF466
		public string param3 { get; set; }

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x003E126F File Offset: 0x003DF46F
		// (set) Token: 0x0600E6AD RID: 59053 RVA: 0x003E1277 File Offset: 0x003DF477
		public string param4 { get; set; }

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x003E1280 File Offset: 0x003DF480
		// (set) Token: 0x0600E6AF RID: 59055 RVA: 0x003E1288 File Offset: 0x003DF488
		public string param5 { get; set; }

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x003E1291 File Offset: 0x003DF491
		// (set) Token: 0x0600E6B1 RID: 59057 RVA: 0x003E1299 File Offset: 0x003DF499
		public float control { get; set; }

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x003E12A2 File Offset: 0x003DF4A2
		// (set) Token: 0x0600E6B3 RID: 59059 RVA: 0x003E12AA File Offset: 0x003DF4AA
		public int id { get; set; }

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x003E12B3 File Offset: 0x003DF4B3
		// (set) Token: 0x0600E6B5 RID: 59061 RVA: 0x003E12BB File Offset: 0x003DF4BB
		public int logic { get; set; }

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x003E12C4 File Offset: 0x003DF4C4
		// (set) Token: 0x0600E6B7 RID: 59063 RVA: 0x003E12CC File Offset: 0x003DF4CC
		public int next { get; set; }

		// Token: 0x0600E6B8 RID: 59064 RVA: 0x003E12D8 File Offset: 0x003DF4D8
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
