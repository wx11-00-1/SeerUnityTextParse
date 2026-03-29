using System;

namespace core.config
{
	// Token: 0x02002124 RID: 8484
	public class AutoCardbook : XlsConfigBase<AutoCardbook, IAutoCardbookInfo>
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600FBEC RID: 64492 RVA: 0x0047C422 File Offset: 0x0047A622
		public override string fileName
		{
			get
			{
				return "autoCardbook";
			}
		}

		// Token: 0x0600FBED RID: 64493 RVA: 0x0047C42C File Offset: 0x0047A62C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutoCardbookInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutoCardbookInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FBEE RID: 64494 RVA: 0x0047C480 File Offset: 0x0047A680
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
