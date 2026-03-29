using System;

namespace core.config
{
	// Token: 0x020023BC RID: 9148
	public class Story1022 : XlsConfigBase<Story1022, IStory1022Info>
	{
		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06011906 RID: 71942 RVA: 0x0049FA29 File Offset: 0x0049DC29
		public override string fileName
		{
			get
			{
				return "story_1022";
			}
		}

		// Token: 0x06011907 RID: 71943 RVA: 0x0049FA30 File Offset: 0x0049DC30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1022Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1022Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011908 RID: 71944 RVA: 0x0049FA84 File Offset: 0x0049DC84
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
