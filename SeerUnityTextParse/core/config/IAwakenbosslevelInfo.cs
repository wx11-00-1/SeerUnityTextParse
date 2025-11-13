using System;

namespace core.config
{
	// Token: 0x02001CAC RID: 7340
	public class IAwakenbosslevelInfo : IConfigItem
	{
		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600D4B2 RID: 54450 RVA: 0x003CADA0 File Offset: 0x003C8FA0
		// (set) Token: 0x0600D4B3 RID: 54451 RVA: 0x003CADA8 File Offset: 0x003C8FA8
		public string itemid { get; set; }

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x003CADB1 File Offset: 0x003C8FB1
		// (set) Token: 0x0600D4B5 RID: 54453 RVA: 0x003CADB9 File Offset: 0x003C8FB9
		public string sceneeffect { get; set; }

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x003CADC2 File Offset: 0x003C8FC2
		// (set) Token: 0x0600D4B7 RID: 54455 RVA: 0x003CADCA File Offset: 0x003C8FCA
		public string troopid { get; set; }

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600D4B8 RID: 54456 RVA: 0x003CADD3 File Offset: 0x003C8FD3
		// (set) Token: 0x0600D4B9 RID: 54457 RVA: 0x003CADDB File Offset: 0x003C8FDB
		public int id { get; set; }

		// Token: 0x0600D4BA RID: 54458 RVA: 0x003CADE4 File Offset: 0x003C8FE4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sceneeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.troopid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
