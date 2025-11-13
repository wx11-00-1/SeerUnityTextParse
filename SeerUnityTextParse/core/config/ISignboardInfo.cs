using System;

namespace core.config
{
	// Token: 0x02001E20 RID: 7712
	public class ISignboardInfo : IConfigItem
	{
		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600E434 RID: 58420 RVA: 0x003DE160 File Offset: 0x003DC360
		// (set) Token: 0x0600E435 RID: 58421 RVA: 0x003DE168 File Offset: 0x003DC368
		public string content { get; set; }

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600E436 RID: 58422 RVA: 0x003DE171 File Offset: 0x003DC371
		// (set) Token: 0x0600E437 RID: 58423 RVA: 0x003DE179 File Offset: 0x003DC379
		public string voice { get; set; }

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x0600E438 RID: 58424 RVA: 0x003DE182 File Offset: 0x003DC382
		// (set) Token: 0x0600E439 RID: 58425 RVA: 0x003DE18A File Offset: 0x003DC38A
		public int[] endtime { get; set; }

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x0600E43A RID: 58426 RVA: 0x003DE193 File Offset: 0x003DC393
		// (set) Token: 0x0600E43B RID: 58427 RVA: 0x003DE19B File Offset: 0x003DC39B
		public int[] month { get; set; }

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x0600E43C RID: 58428 RVA: 0x003DE1A4 File Offset: 0x003DC3A4
		// (set) Token: 0x0600E43D RID: 58429 RVA: 0x003DE1AC File Offset: 0x003DC3AC
		public int[] starttime { get; set; }

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x0600E43E RID: 58430 RVA: 0x003DE1B5 File Offset: 0x003DC3B5
		// (set) Token: 0x0600E43F RID: 58431 RVA: 0x003DE1BD File Offset: 0x003DC3BD
		public int id { get; set; }

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x0600E440 RID: 58432 RVA: 0x003DE1C6 File Offset: 0x003DC3C6
		// (set) Token: 0x0600E441 RID: 58433 RVA: 0x003DE1CE File Offset: 0x003DC3CE
		public int monid { get; set; }

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600E442 RID: 58434 RVA: 0x003DE1D7 File Offset: 0x003DC3D7
		// (set) Token: 0x0600E443 RID: 58435 RVA: 0x003DE1DF File Offset: 0x003DC3DF
		public int x { get; set; }

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600E444 RID: 58436 RVA: 0x003DE1E8 File Offset: 0x003DC3E8
		// (set) Token: 0x0600E445 RID: 58437 RVA: 0x003DE1F0 File Offset: 0x003DC3F0
		public int y { get; set; }

		// Token: 0x0600E446 RID: 58438 RVA: 0x003DE1FC File Offset: 0x003DC3FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.endtime = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.endtime[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.month = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.month[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.starttime = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.starttime[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.voice = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.x = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.y = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
