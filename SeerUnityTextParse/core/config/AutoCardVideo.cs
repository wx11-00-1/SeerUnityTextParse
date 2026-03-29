using System;

namespace core.config
{
	// Token: 0x02002144 RID: 8516
	public class AutoCardVideo : XlsConfigBase<AutoCardVideo, IAutoCardVideoInfo>
	{
		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600FD36 RID: 64822 RVA: 0x0047DC1D File Offset: 0x0047BE1D
		public override string fileName
		{
			get
			{
				return "autoCardVideo";
			}
		}

		// Token: 0x0600FD37 RID: 64823 RVA: 0x0047DC24 File Offset: 0x0047BE24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutoCardVideoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutoCardVideoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FD38 RID: 64824 RVA: 0x0047DC78 File Offset: 0x0047BE78
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
