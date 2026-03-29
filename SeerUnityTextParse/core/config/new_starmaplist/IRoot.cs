using System;

namespace core.config.new_starmaplist
{
	// Token: 0x02002524 RID: 9508
	public class IRoot
	{
		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x060126C0 RID: 75456 RVA: 0x004B8DDB File Offset: 0x004B6FDB
		// (set) Token: 0x060126C1 RID: 75457 RVA: 0x004B8DE3 File Offset: 0x004B6FE3
		public IItemItem[] item { get; set; }

		// Token: 0x060126C2 RID: 75458 RVA: 0x004B8DEC File Offset: 0x004B6FEC
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
