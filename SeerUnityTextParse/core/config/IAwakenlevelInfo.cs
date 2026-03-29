using System;

namespace core.config
{
	// Token: 0x02002151 RID: 8529
	public class IAwakenlevelInfo : IConfigItem
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600FD98 RID: 64920 RVA: 0x0047E3DC File Offset: 0x0047C5DC
		// (set) Token: 0x0600FD99 RID: 64921 RVA: 0x0047E3E4 File Offset: 0x0047C5E4
		public string conditionid { get; set; }

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x0600FD9A RID: 64922 RVA: 0x0047E3ED File Offset: 0x0047C5ED
		// (set) Token: 0x0600FD9B RID: 64923 RVA: 0x0047E3F5 File Offset: 0x0047C5F5
		public string dailybattlerecordinfo { get; set; }

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x0600FD9C RID: 64924 RVA: 0x0047E3FE File Offset: 0x0047C5FE
		// (set) Token: 0x0600FD9D RID: 64925 RVA: 0x0047E406 File Offset: 0x0047C606
		public string monsterdes { get; set; }

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x0600FD9E RID: 64926 RVA: 0x0047E40F File Offset: 0x0047C60F
		// (set) Token: 0x0600FD9F RID: 64927 RVA: 0x0047E417 File Offset: 0x0047C617
		public string passrecordinfo { get; set; }

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600FDA0 RID: 64928 RVA: 0x0047E420 File Offset: 0x0047C620
		// (set) Token: 0x0600FDA1 RID: 64929 RVA: 0x0047E428 File Offset: 0x0047C628
		public string sceneeffect { get; set; }

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600FDA2 RID: 64930 RVA: 0x0047E431 File Offset: 0x0047C631
		// (set) Token: 0x0600FDA3 RID: 64931 RVA: 0x0047E439 File Offset: 0x0047C639
		public string troopid { get; set; }

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600FDA4 RID: 64932 RVA: 0x0047E442 File Offset: 0x0047C642
		// (set) Token: 0x0600FDA5 RID: 64933 RVA: 0x0047E44A File Offset: 0x0047C64A
		public int id { get; set; }

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x0600FDA6 RID: 64934 RVA: 0x0047E453 File Offset: 0x0047C653
		// (set) Token: 0x0600FDA7 RID: 64935 RVA: 0x0047E45B File Offset: 0x0047C65B
		public int time { get; set; }

		// Token: 0x0600FDA8 RID: 64936 RVA: 0x0047E464 File Offset: 0x0047C664
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.conditionid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dailybattlerecordinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.passrecordinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sceneeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.troopid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
