using System;

namespace core.config
{
	// Token: 0x020028C8 RID: 10440
	public class FilmgameStory : XlsConfigBase<FilmgameStory, IFilmgameStoryInfo>
	{
		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06014E8A RID: 85642 RVA: 0x005B6735 File Offset: 0x005B4935
		public override string fileName
		{
			get
			{
				return "filmgameStory";
			}
		}

		// Token: 0x06014E8B RID: 85643 RVA: 0x005B673C File Offset: 0x005B493C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameStoryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameStoryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E8C RID: 85644 RVA: 0x005B6790 File Offset: 0x005B4990
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
