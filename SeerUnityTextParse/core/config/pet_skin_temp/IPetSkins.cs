using System;

namespace core.config.pet_skin_temp
{
	// Token: 0x020021FE RID: 8702
	public class IPetSkins
	{
		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06010B4F RID: 68431 RVA: 0x0045C3F4 File Offset: 0x0045A5F4
		// (set) Token: 0x06010B50 RID: 68432 RVA: 0x0045C3FC File Offset: 0x0045A5FC
		public ISkinItem[] Skin { get; set; }

		// Token: 0x06010B51 RID: 68433 RVA: 0x0045C408 File Offset: 0x0045A608
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Skin = new ISkinItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Skin[i] = new ISkinItem();
					this.Skin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
