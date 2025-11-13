using System;

namespace core.config.energyCollect
{
	// Token: 0x02002044 RID: 8260
	public class IEnergyItem
	{
		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600FC3F RID: 64575 RVA: 0x00401B14 File Offset: 0x003FFD14
		// (set) Token: 0x0600FC40 RID: 64576 RVA: 0x00401B1C File Offset: 0x003FFD1C
		public string collectType { get; set; }

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600FC41 RID: 64577 RVA: 0x00401B25 File Offset: 0x003FFD25
		// (set) Token: 0x0600FC42 RID: 64578 RVA: 0x00401B2D File Offset: 0x003FFD2D
		public string name { get; set; }

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600FC43 RID: 64579 RVA: 0x00401B36 File Offset: 0x003FFD36
		// (set) Token: 0x0600FC44 RID: 64580 RVA: 0x00401B3E File Offset: 0x003FFD3E
		public string unit { get; set; }

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600FC45 RID: 64581 RVA: 0x00401B47 File Offset: 0x003FFD47
		// (set) Token: 0x0600FC46 RID: 64582 RVA: 0x00401B4F File Offset: 0x003FFD4F
		public int collectCnt { get; set; }

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600FC47 RID: 64583 RVA: 0x00401B58 File Offset: 0x003FFD58
		// (set) Token: 0x0600FC48 RID: 64584 RVA: 0x00401B60 File Offset: 0x003FFD60
		public int dir { get; set; }

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600FC49 RID: 64585 RVA: 0x00401B69 File Offset: 0x003FFD69
		// (set) Token: 0x0600FC4A RID: 64586 RVA: 0x00401B71 File Offset: 0x003FFD71
		public int type { get; set; }

		// Token: 0x0600FC4B RID: 64587 RVA: 0x00401B7C File Offset: 0x003FFD7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.collectCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.collectType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
