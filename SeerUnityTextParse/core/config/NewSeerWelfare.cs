using System;

namespace core.config
{
	// Token: 0x02001DA7 RID: 7591
	public class NewSeerWelfare : XlsConfigBase<NewSeerWelfare, INewSeerWelfareInfo>
	{
		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0600DEDA RID: 57050 RVA: 0x003D75FC File Offset: 0x003D57FC
		public override string fileName
		{
			get
			{
				return "NewSeerWelfare";
			}
		}

		// Token: 0x0600DEDB RID: 57051 RVA: 0x003D7604 File Offset: 0x003D5804
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewSeerWelfareInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewSeerWelfareInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DEDC RID: 57052 RVA: 0x003D7658 File Offset: 0x003D5858
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
