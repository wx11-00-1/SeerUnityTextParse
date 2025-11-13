using System;

namespace core.config
{
	// Token: 0x02001DF2 RID: 7666
	public class IRechargeInfo : IConfigItem
	{
		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x0600E242 RID: 57922 RVA: 0x003DB790 File Offset: 0x003D9990
		// (set) Token: 0x0600E243 RID: 57923 RVA: 0x003DB798 File Offset: 0x003D9998
		public string name { get; set; }

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x0600E244 RID: 57924 RVA: 0x003DB7A1 File Offset: 0x003D99A1
		// (set) Token: 0x0600E245 RID: 57925 RVA: 0x003DB7A9 File Offset: 0x003D99A9
		public string quantity { get; set; }

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x0600E246 RID: 57926 RVA: 0x003DB7B2 File Offset: 0x003D99B2
		// (set) Token: 0x0600E247 RID: 57927 RVA: 0x003DB7BA File Offset: 0x003D99BA
		public int give { get; set; }

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x0600E248 RID: 57928 RVA: 0x003DB7C3 File Offset: 0x003D99C3
		// (set) Token: 0x0600E249 RID: 57929 RVA: 0x003DB7CB File Offset: 0x003D99CB
		public int heat { get; set; }

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x0600E24A RID: 57930 RVA: 0x003DB7D4 File Offset: 0x003D99D4
		// (set) Token: 0x0600E24B RID: 57931 RVA: 0x003DB7DC File Offset: 0x003D99DC
		public int id { get; set; }

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x0600E24C RID: 57932 RVA: 0x003DB7E5 File Offset: 0x003D99E5
		// (set) Token: 0x0600E24D RID: 57933 RVA: 0x003DB7ED File Offset: 0x003D99ED
		public int money { get; set; }

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x0600E24E RID: 57934 RVA: 0x003DB7F6 File Offset: 0x003D99F6
		// (set) Token: 0x0600E24F RID: 57935 RVA: 0x003DB7FE File Offset: 0x003D99FE
		public int productID { get; set; }

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600E250 RID: 57936 RVA: 0x003DB807 File Offset: 0x003D9A07
		// (set) Token: 0x0600E251 RID: 57937 RVA: 0x003DB80F File Offset: 0x003D9A0F
		public int type { get; set; }

		// Token: 0x0600E252 RID: 57938 RVA: 0x003DB818 File Offset: 0x003D9A18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.give = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.heat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.money = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
