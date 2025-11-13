using System;

namespace core.config
{
	// Token: 0x02001DEC RID: 7660
	public class IPvpVoteInfo : IConfigItem
	{
		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x0600E1FC RID: 57852 RVA: 0x003DB27C File Offset: 0x003D947C
		// (set) Token: 0x0600E1FD RID: 57853 RVA: 0x003DB284 File Offset: 0x003D9484
		public string name { get; set; }

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x0600E1FE RID: 57854 RVA: 0x003DB28D File Offset: 0x003D948D
		// (set) Token: 0x0600E1FF RID: 57855 RVA: 0x003DB295 File Offset: 0x003D9495
		public string oldresult { get; set; }

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600E200 RID: 57856 RVA: 0x003DB29E File Offset: 0x003D949E
		// (set) Token: 0x0600E201 RID: 57857 RVA: 0x003DB2A6 File Offset: 0x003D94A6
		public string result { get; set; }

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600E202 RID: 57858 RVA: 0x003DB2AF File Offset: 0x003D94AF
		// (set) Token: 0x0600E203 RID: 57859 RVA: 0x003DB2B7 File Offset: 0x003D94B7
		public int id { get; set; }

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x0600E204 RID: 57860 RVA: 0x003DB2C0 File Offset: 0x003D94C0
		// (set) Token: 0x0600E205 RID: 57861 RVA: 0x003DB2C8 File Offset: 0x003D94C8
		public int number { get; set; }

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x0600E206 RID: 57862 RVA: 0x003DB2D1 File Offset: 0x003D94D1
		// (set) Token: 0x0600E207 RID: 57863 RVA: 0x003DB2D9 File Offset: 0x003D94D9
		public int ranklimit1 { get; set; }

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x0600E208 RID: 57864 RVA: 0x003DB2E2 File Offset: 0x003D94E2
		// (set) Token: 0x0600E209 RID: 57865 RVA: 0x003DB2EA File Offset: 0x003D94EA
		public int ranklimit2 { get; set; }

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x0600E20A RID: 57866 RVA: 0x003DB2F3 File Offset: 0x003D94F3
		// (set) Token: 0x0600E20B RID: 57867 RVA: 0x003DB2FB File Offset: 0x003D94FB
		public int subkey { get; set; }

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x0600E20C RID: 57868 RVA: 0x003DB304 File Offset: 0x003D9504
		// (set) Token: 0x0600E20D RID: 57869 RVA: 0x003DB30C File Offset: 0x003D950C
		public int time1 { get; set; }

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x0600E20E RID: 57870 RVA: 0x003DB315 File Offset: 0x003D9515
		// (set) Token: 0x0600E20F RID: 57871 RVA: 0x003DB31D File Offset: 0x003D951D
		public int time2 { get; set; }

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x0600E210 RID: 57872 RVA: 0x003DB326 File Offset: 0x003D9526
		// (set) Token: 0x0600E211 RID: 57873 RVA: 0x003DB32E File Offset: 0x003D952E
		public int type { get; set; }

		// Token: 0x0600E212 RID: 57874 RVA: 0x003DB338 File Offset: 0x003D9538
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.oldresult = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ranklimit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ranklimit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.result = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
