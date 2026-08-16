using System;

namespace core.config
{
	// Token: 0x020028C6 RID: 10438
	public class FilmgameLv : XlsConfigBase<FilmgameLv, IFilmgameLvInfo>
	{
		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06014E7A RID: 85626 RVA: 0x005B6602 File Offset: 0x005B4802
		public override string fileName
		{
			get
			{
				return "filmgameLv";
			}
		}

		// Token: 0x06014E7B RID: 85627 RVA: 0x005B660C File Offset: 0x005B480C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameLvInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x005B6660 File Offset: 0x005B4860
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
