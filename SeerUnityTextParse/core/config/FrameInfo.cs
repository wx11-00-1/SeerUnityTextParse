using System;

namespace core.config
{
	// Token: 0x0200225A RID: 8794
	public class FrameInfo : XlsConfigBase<FrameInfo, IFrameInfoInfo>
	{
		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06010988 RID: 67976 RVA: 0x0048C779 File Offset: 0x0048A979
		public override string fileName
		{
			get
			{
				return "FrameInfo";
			}
		}

		// Token: 0x06010989 RID: 67977 RVA: 0x0048C780 File Offset: 0x0048A980
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFrameInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFrameInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601098A RID: 67978 RVA: 0x0048C7D4 File Offset: 0x0048A9D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
