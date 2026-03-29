using System;

namespace core.config.new_starmap
{
	// Token: 0x02002527 RID: 9511
	public class IRoot
	{
		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x060126E6 RID: 75494 RVA: 0x004B9065 File Offset: 0x004B7265
		// (set) Token: 0x060126E7 RID: 75495 RVA: 0x004B906D File Offset: 0x004B726D
		public IItemItem[] item { get; set; }

		// Token: 0x060126E8 RID: 75496 RVA: 0x004B9078 File Offset: 0x004B7278
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
