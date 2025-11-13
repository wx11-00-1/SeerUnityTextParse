using System;

namespace core.config
{
	// Token: 0x02001E67 RID: 7783
	public class Story2005 : XlsConfigBase<Story2005, IStory2005Info>
	{
		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600E762 RID: 59234 RVA: 0x003E1FE1 File Offset: 0x003E01E1
		public override string fileName
		{
			get
			{
				return "story_2005";
			}
		}

		// Token: 0x0600E763 RID: 59235 RVA: 0x003E1FE8 File Offset: 0x003E01E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2005Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2005Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x003E203C File Offset: 0x003E023C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
