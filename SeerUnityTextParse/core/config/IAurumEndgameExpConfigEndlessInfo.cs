using System;

namespace core.config
{
	// Token: 0x0200242B RID: 9259
	public class IAurumEndgameExpConfigEndlessInfo : IConfigItem
	{
		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06011828 RID: 71720 RVA: 0x005005E4 File Offset: 0x004FE7E4
		// (set) Token: 0x06011829 RID: 71721 RVA: 0x005005EC File Offset: 0x004FE7EC
		public string @event { get; set; }

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x0601182A RID: 71722 RVA: 0x005005F5 File Offset: 0x004FE7F5
		// (set) Token: 0x0601182B RID: 71723 RVA: 0x005005FD File Offset: 0x004FE7FD
		public int exp { get; set; }

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0601182C RID: 71724 RVA: 0x00500606 File Offset: 0x004FE806
		// (set) Token: 0x0601182D RID: 71725 RVA: 0x0050060E File Offset: 0x004FE80E
		public int id { get; set; }

		// Token: 0x0601182E RID: 71726 RVA: 0x00500617 File Offset: 0x004FE817
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@event = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
