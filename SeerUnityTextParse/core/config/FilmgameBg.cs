using System;

namespace core.config
{
	// Token: 0x020028C2 RID: 10434
	public class FilmgameBg : XlsConfigBase<FilmgameBg, IFilmgameBgInfo>
	{
		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06014E62 RID: 85602 RVA: 0x005B6423 File Offset: 0x005B4623
		public override string fileName
		{
			get
			{
				return "filmgameBg";
			}
		}

		// Token: 0x06014E63 RID: 85603 RVA: 0x005B642C File Offset: 0x005B462C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameBgInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameBgInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E64 RID: 85604 RVA: 0x005B6480 File Offset: 0x005B4680
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
