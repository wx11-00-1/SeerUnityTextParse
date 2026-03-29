using System;

namespace core.config
{
	// Token: 0x0200226A RID: 8810
	public class H512thBox : XlsConfigBase<H512thBox, IH512thBoxInfo>
	{
		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06010A48 RID: 68168 RVA: 0x0048D6EB File Offset: 0x0048B8EB
		public override string fileName
		{
			get
			{
				return "h5_12th_box";
			}
		}

		// Token: 0x06010A49 RID: 68169 RVA: 0x0048D6F4 File Offset: 0x0048B8F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IH512thBoxInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IH512thBoxInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010A4A RID: 68170 RVA: 0x0048D748 File Offset: 0x0048B948
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
