using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002512 RID: 9490
	public class INinbous
	{
		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x06012608 RID: 75272 RVA: 0x004B7C1A File Offset: 0x004B5E1A
		// (set) Token: 0x06012609 RID: 75273 RVA: 0x004B7C22 File Offset: 0x004B5E22
		public INinbouItem[] ninbou { get; set; }

		// Token: 0x0601260A RID: 75274 RVA: 0x004B7C2C File Offset: 0x004B5E2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ninbou = new INinbouItem[num];
				for (int i = 0; i < num; i++)
				{
					this.ninbou[i] = new INinbouItem();
					this.ninbou[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
