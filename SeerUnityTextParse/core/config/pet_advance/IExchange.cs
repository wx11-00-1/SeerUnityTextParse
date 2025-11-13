using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F47 RID: 8007
	public class IExchange
	{
		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x0600F034 RID: 61492 RVA: 0x003F480B File Offset: 0x003F2A0B
		// (set) Token: 0x0600F035 RID: 61493 RVA: 0x003F4813 File Offset: 0x003F2A13
		public int[] ItemID { get; set; }

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600F036 RID: 61494 RVA: 0x003F481C File Offset: 0x003F2A1C
		// (set) Token: 0x0600F037 RID: 61495 RVA: 0x003F4824 File Offset: 0x003F2A24
		public int[] ProductID { get; set; }

		// Token: 0x0600F038 RID: 61496 RVA: 0x003F4830 File Offset: 0x003F2A30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ItemID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.ItemID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ProductID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.ProductID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
