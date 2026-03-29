using System;

namespace core.config.redbutton
{
	// Token: 0x020024B1 RID: 9393
	public class IRoot
	{
		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060122F2 RID: 74482 RVA: 0x004B3BFE File Offset: 0x004B1DFE
		// (set) Token: 0x060122F3 RID: 74483 RVA: 0x004B3C06 File Offset: 0x004B1E06
		public IRedItem[] Red { get; set; }

		// Token: 0x060122F4 RID: 74484 RVA: 0x004B3C10 File Offset: 0x004B1E10
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Red = new IRedItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Red[i] = new IRedItem();
					this.Red[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
