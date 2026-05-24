using System;

namespace core.config
{
	// Token: 0x020026EA RID: 9962
	public class Story1017 : XlsConfigBase<Story1017, IStory1017Info>
	{
		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x060136FE RID: 79614 RVA: 0x00525CE9 File Offset: 0x00523EE9
		public override string fileName
		{
			get
			{
				return "story_1017";
			}
		}

		// Token: 0x060136FF RID: 79615 RVA: 0x00525CF0 File Offset: 0x00523EF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1017Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1017Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013700 RID: 79616 RVA: 0x00525D44 File Offset: 0x00523F44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
