namespace core.config
{
	public class FilmgameBg : XlsConfigBase<FilmgameBg, IFilmgameBgInfo>
	{
		public override string fileName
		{
			get
			{
				return "filmgameBg";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFilmgameBgInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFilmgameBgInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
