using System;

namespace core.config
{
	// Token: 0x02001C9B RID: 7323
	public class AdAstraLevel : XlsConfigBase<AdAstraLevel, IAdAstraLevelInfo>
	{
		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x0600D414 RID: 54292 RVA: 0x003CA150 File Offset: 0x003C8350
		public override string fileName
		{
			get
			{
				return "AdAstraLevel";
			}
		}

		// Token: 0x0600D415 RID: 54293 RVA: 0x003CA158 File Offset: 0x003C8358
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x003CA1AC File Offset: 0x003C83AC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
