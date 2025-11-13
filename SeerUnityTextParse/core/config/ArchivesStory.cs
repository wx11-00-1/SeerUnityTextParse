using System;

namespace core.config
{
	// Token: 0x02001CA3 RID: 7331
	public class ArchivesStory : XlsConfigBase<ArchivesStory, IArchivesStoryInfo>
	{
		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600D464 RID: 54372 RVA: 0x003CA773 File Offset: 0x003C8973
		public override string fileName
		{
			get
			{
				return "archivesStory";
			}
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x003CA77C File Offset: 0x003C897C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArchivesStoryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArchivesStoryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x003CA7D0 File Offset: 0x003C89D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
