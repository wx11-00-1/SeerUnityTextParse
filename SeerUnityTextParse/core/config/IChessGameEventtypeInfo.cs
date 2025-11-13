using System;

namespace core.config
{
	// Token: 0x02001CFE RID: 7422
	public class IChessGameEventtypeInfo : IConfigItem
	{
		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600D846 RID: 55366 RVA: 0x003CF220 File Offset: 0x003CD420
		// (set) Token: 0x0600D847 RID: 55367 RVA: 0x003CF228 File Offset: 0x003CD428
		public string eventicon { get; set; }

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600D848 RID: 55368 RVA: 0x003CF231 File Offset: 0x003CD431
		// (set) Token: 0x0600D849 RID: 55369 RVA: 0x003CF239 File Offset: 0x003CD439
		public string eventname { get; set; }

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x0600D84A RID: 55370 RVA: 0x003CF242 File Offset: 0x003CD442
		// (set) Token: 0x0600D84B RID: 55371 RVA: 0x003CF24A File Offset: 0x003CD44A
		public string eventposition { get; set; }

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600D84C RID: 55372 RVA: 0x003CF253 File Offset: 0x003CD453
		// (set) Token: 0x0600D84D RID: 55373 RVA: 0x003CF25B File Offset: 0x003CD45B
		public int eventtype { get; set; }

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600D84E RID: 55374 RVA: 0x003CF264 File Offset: 0x003CD464
		// (set) Token: 0x0600D84F RID: 55375 RVA: 0x003CF26C File Offset: 0x003CD46C
		public int id { get; set; }

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x0600D850 RID: 55376 RVA: 0x003CF275 File Offset: 0x003CD475
		// (set) Token: 0x0600D851 RID: 55377 RVA: 0x003CF27D File Offset: 0x003CD47D
		public int towerid { get; set; }

		// Token: 0x0600D852 RID: 55378 RVA: 0x003CF288 File Offset: 0x003CD488
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.eventicon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventposition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.towerid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
