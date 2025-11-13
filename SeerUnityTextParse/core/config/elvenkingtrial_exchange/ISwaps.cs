using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x02002052 RID: 8274
	public class ISwaps
	{
		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600FCA9 RID: 64681 RVA: 0x004022BA File Offset: 0x004004BA
		// (set) Token: 0x0600FCAA RID: 64682 RVA: 0x004022C2 File Offset: 0x004004C2
		public ISwapItem[] swap { get; set; }

		// Token: 0x0600FCAB RID: 64683 RVA: 0x004022CC File Offset: 0x004004CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.swap = new ISwapItem[num];
				for (int i = 0; i < num; i++)
				{
					this.swap[i] = new ISwapItem();
					this.swap[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F601 RID: 62977
		private bool b;
	}
}
