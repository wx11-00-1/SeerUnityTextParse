using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x0200204C RID: 8268
	public class IItems
	{
		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600FC85 RID: 64645 RVA: 0x00401FE4 File Offset: 0x004001E4
		// (set) Token: 0x0600FC86 RID: 64646 RVA: 0x00401FEC File Offset: 0x004001EC
		public IItemItem[] item { get; set; }

		// Token: 0x0600FC87 RID: 64647 RVA: 0x00401FF8 File Offset: 0x004001F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
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

		// Token: 0x0400F5F2 RID: 62962
		private bool b;
	}
}
