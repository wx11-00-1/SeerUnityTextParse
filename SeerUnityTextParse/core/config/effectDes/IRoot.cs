using System;

namespace core.config.effectDes
{
	// Token: 0x0200205B RID: 8283
	public class IRoot
	{
		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600FD07 RID: 64775 RVA: 0x00402A51 File Offset: 0x00400C51
		// (set) Token: 0x0600FD08 RID: 64776 RVA: 0x00402A59 File Offset: 0x00400C59
		public IItemItem[] item { get; set; }

		// Token: 0x0600FD09 RID: 64777 RVA: 0x00402A64 File Offset: 0x00400C64
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
