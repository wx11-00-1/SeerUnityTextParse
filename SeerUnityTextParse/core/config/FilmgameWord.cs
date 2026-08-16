using System;

namespace core.config
{
	// Token: 0x020028CC RID: 10444
	public class FilmgameWord : XlsConfigBase<FilmgameWord, IFilmgameWordInfo>
	{
		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06014EB0 RID: 85680 RVA: 0x005B6A0B File Offset: 0x005B4C0B
		public override string fileName
		{
			get
			{
				return "filmgameWord";
			}
		}

		// Token: 0x06014EB1 RID: 85681 RVA: 0x005B6A14 File Offset: 0x005B4C14
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameWordInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameWordInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014EB2 RID: 85682 RVA: 0x005B6A68 File Offset: 0x005B4C68
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
