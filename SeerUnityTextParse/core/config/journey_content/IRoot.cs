using System;

namespace core.config.journey_content
{
	// Token: 0x02002586 RID: 9606
	public class IRoot
	{
		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x06012AF7 RID: 76535 RVA: 0x004BE4C4 File Offset: 0x004BC6C4
		// (set) Token: 0x06012AF8 RID: 76536 RVA: 0x004BE4CC File Offset: 0x004BC6CC
		public IItemItem[] item { get; set; }

		// Token: 0x06012AF9 RID: 76537 RVA: 0x004BE4D8 File Offset: 0x004BC6D8
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
