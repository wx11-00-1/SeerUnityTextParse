using System;

namespace core.config
{
	// Token: 0x02001D31 RID: 7473
	public class DeepSpaceLevel : XlsConfigBase<DeepSpaceLevel, IDeepSpaceLevelInfo>
	{
		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x003D19BF File Offset: 0x003CFBBF
		public override string fileName
		{
			get
			{
				return "deepSpaceLevel";
			}
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x003D19C8 File Offset: 0x003CFBC8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSpaceLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSpaceLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x003D1A1C File Offset: 0x003CFC1C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
