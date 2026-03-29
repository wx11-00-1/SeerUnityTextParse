using System;

namespace core.config
{
	// Token: 0x020022F4 RID: 8948
	public class PreferentialBest : XlsConfigBase<PreferentialBest, IPreferentialBestInfo>
	{
		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x0601101A RID: 69658 RVA: 0x004949A1 File Offset: 0x00492BA1
		public override string fileName
		{
			get
			{
				return "PreferentialBest";
			}
		}

		// Token: 0x0601101B RID: 69659 RVA: 0x004949A8 File Offset: 0x00492BA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPreferentialBestInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPreferentialBestInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601101C RID: 69660 RVA: 0x004949FC File Offset: 0x00492BFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
