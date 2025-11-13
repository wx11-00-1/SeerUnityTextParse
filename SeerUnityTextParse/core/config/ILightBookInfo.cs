using System;

namespace core.config
{
	// Token: 0x02001D7A RID: 7546
	public class ILightBookInfo : IConfigItem
	{
		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x0600DD20 RID: 56608 RVA: 0x003D5298 File Offset: 0x003D3498
		// (set) Token: 0x0600DD21 RID: 56609 RVA: 0x003D52A0 File Offset: 0x003D34A0
		public string coinid { get; set; }

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x0600DD22 RID: 56610 RVA: 0x003D52A9 File Offset: 0x003D34A9
		// (set) Token: 0x0600DD23 RID: 56611 RVA: 0x003D52B1 File Offset: 0x003D34B1
		public string monsterID { get; set; }

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x0600DD24 RID: 56612 RVA: 0x003D52BA File Offset: 0x003D34BA
		// (set) Token: 0x0600DD25 RID: 56613 RVA: 0x003D52C2 File Offset: 0x003D34C2
		public string needmonID { get; set; }

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x003D52CB File Offset: 0x003D34CB
		// (set) Token: 0x0600DD27 RID: 56615 RVA: 0x003D52D3 File Offset: 0x003D34D3
		public string price { get; set; }

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x003D52DC File Offset: 0x003D34DC
		// (set) Token: 0x0600DD29 RID: 56617 RVA: 0x003D52E4 File Offset: 0x003D34E4
		public int id { get; set; }

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x003D52ED File Offset: 0x003D34ED
		// (set) Token: 0x0600DD2B RID: 56619 RVA: 0x003D52F5 File Offset: 0x003D34F5
		public int newest { get; set; }

		// Token: 0x0600DD2C RID: 56620 RVA: 0x003D5300 File Offset: 0x003D3500
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coinid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.needmonID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.newest = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
