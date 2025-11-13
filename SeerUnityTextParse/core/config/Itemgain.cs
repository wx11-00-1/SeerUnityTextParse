using System;

namespace core.config
{
	// Token: 0x02001D69 RID: 7529
	public class Itemgain : XlsConfigBase<Itemgain, IItemgainInfo>
	{
		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x0600DC90 RID: 56464 RVA: 0x003D47BF File Offset: 0x003D29BF
		public override string fileName
		{
			get
			{
				return "itemgain";
			}
		}

		// Token: 0x0600DC91 RID: 56465 RVA: 0x003D47C8 File Offset: 0x003D29C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IItemgainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IItemgainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC92 RID: 56466 RVA: 0x003D481C File Offset: 0x003D2A1C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
