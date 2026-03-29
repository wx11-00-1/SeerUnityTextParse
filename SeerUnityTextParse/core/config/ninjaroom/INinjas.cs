using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002514 RID: 9492
	public class INinjas
	{
		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x06012620 RID: 75296 RVA: 0x004B7DCD File Offset: 0x004B5FCD
		// (set) Token: 0x06012621 RID: 75297 RVA: 0x004B7DD5 File Offset: 0x004B5FD5
		public INinjaItem[] ninja { get; set; }

		// Token: 0x06012622 RID: 75298 RVA: 0x004B7DE0 File Offset: 0x004B5FE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ninja = new INinjaItem[num];
				for (int i = 0; i < num; i++)
				{
					this.ninja[i] = new INinjaItem();
					this.ninja[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
