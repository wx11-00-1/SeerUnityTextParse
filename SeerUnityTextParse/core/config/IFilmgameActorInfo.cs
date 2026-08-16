using System;

namespace core.config
{
	// Token: 0x020028C1 RID: 10433
	public class IFilmgameActorInfo : IConfigItem
	{
		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06014E56 RID: 85590 RVA: 0x005B6360 File Offset: 0x005B4560
		// (set) Token: 0x06014E57 RID: 85591 RVA: 0x005B6368 File Offset: 0x005B4568
		public string character { get; set; }

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06014E58 RID: 85592 RVA: 0x005B6371 File Offset: 0x005B4571
		// (set) Token: 0x06014E59 RID: 85593 RVA: 0x005B6379 File Offset: 0x005B4579
		public string image { get; set; }

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06014E5A RID: 85594 RVA: 0x005B6382 File Offset: 0x005B4582
		// (set) Token: 0x06014E5B RID: 85595 RVA: 0x005B638A File Offset: 0x005B458A
		public string name { get; set; }

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06014E5C RID: 85596 RVA: 0x005B6393 File Offset: 0x005B4593
		// (set) Token: 0x06014E5D RID: 85597 RVA: 0x005B639B File Offset: 0x005B459B
		public int changey { get; set; }

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06014E5E RID: 85598 RVA: 0x005B63A4 File Offset: 0x005B45A4
		// (set) Token: 0x06014E5F RID: 85599 RVA: 0x005B63AC File Offset: 0x005B45AC
		public int id { get; set; }

		// Token: 0x06014E60 RID: 85600 RVA: 0x005B63B8 File Offset: 0x005B45B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.changey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.character = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
