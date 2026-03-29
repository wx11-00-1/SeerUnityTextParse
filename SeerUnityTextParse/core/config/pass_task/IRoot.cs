using System;

namespace core.config.pass_task
{
	// Token: 0x02002505 RID: 9477
	public class IRoot
	{
		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x060125AC RID: 75180 RVA: 0x004B758D File Offset: 0x004B578D
		// (set) Token: 0x060125AD RID: 75181 RVA: 0x004B7595 File Offset: 0x004B5795
		public IItemItem[] item { get; set; }

		// Token: 0x060125AE RID: 75182 RVA: 0x004B75A0 File Offset: 0x004B57A0
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
