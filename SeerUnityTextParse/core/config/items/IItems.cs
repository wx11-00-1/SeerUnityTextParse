using System;

namespace core.config.items
{
	// Token: 0x0200201F RID: 8223
	public class IItems
	{
		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600FB03 RID: 64259 RVA: 0x004003D9 File Offset: 0x003FE5D9
		// (set) Token: 0x0600FB04 RID: 64260 RVA: 0x004003E1 File Offset: 0x003FE5E1
		public ICatItem[] Cat { get; set; }

		// Token: 0x0600FB05 RID: 64261 RVA: 0x004003EC File Offset: 0x003FE5EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Cat = new ICatItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Cat[i] = new ICatItem();
					this.Cat[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F564 RID: 62820
		private bool b;
	}
}
