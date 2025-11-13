using System;

namespace core.config.aimat
{
	// Token: 0x02002076 RID: 8310
	public class IRoot
	{
		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600FDC3 RID: 64963 RVA: 0x00403776 File Offset: 0x00401976
		// (set) Token: 0x0600FDC4 RID: 64964 RVA: 0x0040377E File Offset: 0x0040197E
		public IItemItem[] item { get; set; }

		// Token: 0x0600FDC5 RID: 64965 RVA: 0x00403788 File Offset: 0x00401988
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
