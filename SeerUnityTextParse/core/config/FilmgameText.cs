using System;

namespace core.config
{
	// Token: 0x020028CA RID: 10442
	public class FilmgameText : XlsConfigBase<FilmgameText, IFilmgameTextInfo>
	{
		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06014EA4 RID: 85668 RVA: 0x005B6924 File Offset: 0x005B4B24
		public override string fileName
		{
			get
			{
				return "filmgameText";
			}
		}

		// Token: 0x06014EA5 RID: 85669 RVA: 0x005B692C File Offset: 0x005B4B2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameTextInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameTextInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014EA6 RID: 85670 RVA: 0x005B6980 File Offset: 0x005B4B80
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
