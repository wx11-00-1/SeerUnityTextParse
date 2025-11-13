using System;

namespace core.config
{
	// Token: 0x02001D62 RID: 7522
	public class IGuidePetRecommendInfo : IConfigItem
	{
		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600DC40 RID: 56384 RVA: 0x003D40AC File Offset: 0x003D22AC
		// (set) Token: 0x0600DC41 RID: 56385 RVA: 0x003D40B4 File Offset: 0x003D22B4
		public string[] fifthProgress { get; set; }

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600DC42 RID: 56386 RVA: 0x003D40BD File Offset: 0x003D22BD
		// (set) Token: 0x0600DC43 RID: 56387 RVA: 0x003D40C5 File Offset: 0x003D22C5
		public string gainday { get; set; }

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600DC44 RID: 56388 RVA: 0x003D40CE File Offset: 0x003D22CE
		// (set) Token: 0x0600DC45 RID: 56389 RVA: 0x003D40D6 File Offset: 0x003D22D6
		public string[] judge5thmoveByvalue { get; set; }

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x0600DC46 RID: 56390 RVA: 0x003D40DF File Offset: 0x003D22DF
		// (set) Token: 0x0600DC47 RID: 56391 RVA: 0x003D40E7 File Offset: 0x003D22E7
		public string[] judgeNewseByvalue { get; set; }

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600DC48 RID: 56392 RVA: 0x003D40F0 File Offset: 0x003D22F0
		// (set) Token: 0x0600DC49 RID: 56393 RVA: 0x003D40F8 File Offset: 0x003D22F8
		public string[] judgePetByvalue { get; set; }

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600DC4A RID: 56394 RVA: 0x003D4101 File Offset: 0x003D2301
		// (set) Token: 0x0600DC4B RID: 56395 RVA: 0x003D4109 File Offset: 0x003D2309
		public string[] petProgress { get; set; }

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x003D4112 File Offset: 0x003D2312
		// (set) Token: 0x0600DC4D RID: 56397 RVA: 0x003D411A File Offset: 0x003D231A
		public string[] seProgress { get; set; }

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600DC4E RID: 56398 RVA: 0x003D4123 File Offset: 0x003D2323
		// (set) Token: 0x0600DC4F RID: 56399 RVA: 0x003D412B File Offset: 0x003D232B
		public int[] strategy { get; set; }

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x003D4134 File Offset: 0x003D2334
		// (set) Token: 0x0600DC51 RID: 56401 RVA: 0x003D413C File Offset: 0x003D233C
		public int id { get; set; }

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x0600DC52 RID: 56402 RVA: 0x003D4145 File Offset: 0x003D2345
		// (set) Token: 0x0600DC53 RID: 56403 RVA: 0x003D414D File Offset: 0x003D234D
		public int petID { get; set; }

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x003D4156 File Offset: 0x003D2356
		// (set) Token: 0x0600DC55 RID: 56405 RVA: 0x003D415E File Offset: 0x003D235E
		public int recommend { get; set; }

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x0600DC56 RID: 56406 RVA: 0x003D4167 File Offset: 0x003D2367
		// (set) Token: 0x0600DC57 RID: 56407 RVA: 0x003D416F File Offset: 0x003D236F
		public int stage { get; set; }

		// Token: 0x0600DC58 RID: 56408 RVA: 0x003D4178 File Offset: 0x003D2378
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fifthProgress = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.fifthProgress[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.gainday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judge5thmoveByvalue = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.judge5thmoveByvalue[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judgeNewseByvalue = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					this.judgeNewseByvalue[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judgePetByvalue = new string[num4];
				for (int l = 0; l < num4; l++)
				{
					this.judgePetByvalue[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.petProgress = new string[num5];
				for (int m = 0; m < num5; m++)
				{
					this.petProgress[m] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.seProgress = new string[num6];
				for (int n = 0; n < num6; n++)
				{
					this.seProgress[n] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num7 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.strategy = new int[num7];
				for (int num8 = 0; num8 < num7; num8++)
				{
					this.strategy[num8] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
