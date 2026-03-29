using System;

namespace core.config
{
	// Token: 0x020022DD RID: 8925
	public class IPackageUpdateInfo : IConfigItem
	{
		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06010F30 RID: 69424 RVA: 0x004938A4 File Offset: 0x00491AA4
		// (set) Token: 0x06010F31 RID: 69425 RVA: 0x004938AC File Offset: 0x00491AAC
		public string channel { get; set; }

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06010F32 RID: 69426 RVA: 0x004938B5 File Offset: 0x00491AB5
		// (set) Token: 0x06010F33 RID: 69427 RVA: 0x004938BD File Offset: 0x00491ABD
		public string msg { get; set; }

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06010F34 RID: 69428 RVA: 0x004938C6 File Offset: 0x00491AC6
		// (set) Token: 0x06010F35 RID: 69429 RVA: 0x004938CE File Offset: 0x00491ACE
		public string title { get; set; }

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06010F36 RID: 69430 RVA: 0x004938D7 File Offset: 0x00491AD7
		// (set) Token: 0x06010F37 RID: 69431 RVA: 0x004938DF File Offset: 0x00491ADF
		public string url { get; set; }

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06010F38 RID: 69432 RVA: 0x004938E8 File Offset: 0x00491AE8
		// (set) Token: 0x06010F39 RID: 69433 RVA: 0x004938F0 File Offset: 0x00491AF0
		public int force_update { get; set; }

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06010F3A RID: 69434 RVA: 0x004938F9 File Offset: 0x00491AF9
		// (set) Token: 0x06010F3B RID: 69435 RVA: 0x00493901 File Offset: 0x00491B01
		public int id { get; set; }

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06010F3C RID: 69436 RVA: 0x0049390A File Offset: 0x00491B0A
		// (set) Token: 0x06010F3D RID: 69437 RVA: 0x00493912 File Offset: 0x00491B12
		public int size { get; set; }

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06010F3E RID: 69438 RVA: 0x0049391B File Offset: 0x00491B1B
		// (set) Token: 0x06010F3F RID: 69439 RVA: 0x00493923 File Offset: 0x00491B23
		public int version { get; set; }

		// Token: 0x06010F40 RID: 69440 RVA: 0x0049392C File Offset: 0x00491B2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.channel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.force_update = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.size = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.version = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
