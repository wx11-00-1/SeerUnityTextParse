using System;

namespace core.config.activityTimeControl
{
	// Token: 0x02002081 RID: 8321
	public class IConfig
	{
		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600FE0F RID: 65039 RVA: 0x00403DF4 File Offset: 0x00401FF4
		// (set) Token: 0x0600FE10 RID: 65040 RVA: 0x00403DFC File Offset: 0x00401FFC
		public IItemItem[] item { get; set; }

		// Token: 0x0600FE11 RID: 65041 RVA: 0x00403E08 File Offset: 0x00402008
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
