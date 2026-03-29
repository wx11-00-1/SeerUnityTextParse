using System;

namespace core.config
{
	// Token: 0x02002389 RID: 9097
	public class IStartrekbossconfigInfo : IConfigItem
	{
		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x060116A6 RID: 71334 RVA: 0x0049CC80 File Offset: 0x0049AE80
		// (set) Token: 0x060116A7 RID: 71335 RVA: 0x0049CC88 File Offset: 0x0049AE88
		public string monsterMove { get; set; }

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x060116A8 RID: 71336 RVA: 0x0049CC91 File Offset: 0x0049AE91
		// (set) Token: 0x060116A9 RID: 71337 RVA: 0x0049CC99 File Offset: 0x0049AE99
		public string monsterName { get; set; }

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x060116AA RID: 71338 RVA: 0x0049CCA2 File Offset: 0x0049AEA2
		// (set) Token: 0x060116AB RID: 71339 RVA: 0x0049CCAA File Offset: 0x0049AEAA
		public string monsterNewse { get; set; }

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x060116AC RID: 71340 RVA: 0x0049CCB3 File Offset: 0x0049AEB3
		// (set) Token: 0x060116AD RID: 71341 RVA: 0x0049CCBB File Offset: 0x0049AEBB
		public int Atk { get; set; }

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x060116AE RID: 71342 RVA: 0x0049CCC4 File Offset: 0x0049AEC4
		// (set) Token: 0x060116AF RID: 71343 RVA: 0x0049CCCC File Offset: 0x0049AECC
		public int Def { get; set; }

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x060116B0 RID: 71344 RVA: 0x0049CCD5 File Offset: 0x0049AED5
		// (set) Token: 0x060116B1 RID: 71345 RVA: 0x0049CCDD File Offset: 0x0049AEDD
		public int HP { get; set; }

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x060116B2 RID: 71346 RVA: 0x0049CCE6 File Offset: 0x0049AEE6
		// (set) Token: 0x060116B3 RID: 71347 RVA: 0x0049CCEE File Offset: 0x0049AEEE
		public int id { get; set; }

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x060116B4 RID: 71348 RVA: 0x0049CCF7 File Offset: 0x0049AEF7
		// (set) Token: 0x060116B5 RID: 71349 RVA: 0x0049CCFF File Offset: 0x0049AEFF
		public int monsterId { get; set; }

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x060116B6 RID: 71350 RVA: 0x0049CD08 File Offset: 0x0049AF08
		// (set) Token: 0x060116B7 RID: 71351 RVA: 0x0049CD10 File Offset: 0x0049AF10
		public int SP_Atk { get; set; }

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060116B8 RID: 71352 RVA: 0x0049CD19 File Offset: 0x0049AF19
		// (set) Token: 0x060116B9 RID: 71353 RVA: 0x0049CD21 File Offset: 0x0049AF21
		public int SP_Def { get; set; }

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x060116BA RID: 71354 RVA: 0x0049CD2A File Offset: 0x0049AF2A
		// (set) Token: 0x060116BB RID: 71355 RVA: 0x0049CD32 File Offset: 0x0049AF32
		public int Spd { get; set; }

		// Token: 0x060116BC RID: 71356 RVA: 0x0049CD3C File Offset: 0x0049AF3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SP_Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SP_Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterMove = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterNewse = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
