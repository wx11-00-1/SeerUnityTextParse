using System;

namespace core.config
{
	// Token: 0x020027F8 RID: 10232
	public class StarrySkyStoryConfig : XlsConfigBase<StarrySkyStoryConfig, IStarrySkyStoryConfigInfo>
	{
		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x060145F5 RID: 83445 RVA: 0x00568E30 File Offset: 0x00567030
		public override string fileName
		{
			get
			{
				return "starrySkyStoryConfig";
			}
		}

		// Token: 0x060145F6 RID: 83446 RVA: 0x00568E38 File Offset: 0x00567038
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStarrySkyStoryConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStarrySkyStoryConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060145F7 RID: 83447 RVA: 0x00568E8C File Offset: 0x0056708C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
