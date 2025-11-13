using System;

namespace core.config
{
	// Token: 0x02001E88 RID: 7816
	public class IWishFloatingBottleInfo : IConfigItem
	{
		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x003E39A4 File Offset: 0x003E1BA4
		// (set) Token: 0x0600E8AB RID: 59563 RVA: 0x003E39AC File Offset: 0x003E1BAC
		public int[] wishoutput { get; set; }

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600E8AC RID: 59564 RVA: 0x003E39B5 File Offset: 0x003E1BB5
		// (set) Token: 0x0600E8AD RID: 59565 RVA: 0x003E39BD File Offset: 0x003E1BBD
		public int[] wishrealid { get; set; }

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600E8AE RID: 59566 RVA: 0x003E39C6 File Offset: 0x003E1BC6
		// (set) Token: 0x0600E8AF RID: 59567 RVA: 0x003E39CE File Offset: 0x003E1BCE
		public int id { get; set; }

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x003E39D7 File Offset: 0x003E1BD7
		// (set) Token: 0x0600E8B1 RID: 59569 RVA: 0x003E39DF File Offset: 0x003E1BDF
		public int wishtype { get; set; }

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x003E39E8 File Offset: 0x003E1BE8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.wishoutput = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.wishoutput[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.wishrealid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.wishrealid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.wishtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
