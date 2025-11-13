using System;

namespace core.config
{
	// Token: 0x02001DB1 RID: 7601
	public class OriginRecallMain : XlsConfigBase<OriginRecallMain, IOriginRecallMainInfo>
	{
		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x0600DF82 RID: 57218 RVA: 0x003D82A9 File Offset: 0x003D64A9
		public override string fileName
		{
			get
			{
				return "OriginRecall_Main";
			}
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x003D82B0 File Offset: 0x003D64B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IOriginRecallMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IOriginRecallMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF84 RID: 57220 RVA: 0x003D8304 File Offset: 0x003D6504
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
