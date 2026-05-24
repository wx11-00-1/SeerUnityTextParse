using System;

namespace core.config
{
	// Token: 0x020026BE RID: 9918
	public class StoryAnniversary2026Items : XlsConfigBase<StoryAnniversary2026Items, IStoryAnniversary2026ItemsInfo>
	{
		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x060134FE RID: 79102 RVA: 0x005236D1 File Offset: 0x005218D1
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026Items";
			}
		}

		// Token: 0x060134FF RID: 79103 RVA: 0x005236D8 File Offset: 0x005218D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026ItemsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026ItemsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013500 RID: 79104 RVA: 0x0052372C File Offset: 0x0052192C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
