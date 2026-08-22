namespace core.config
{
	public class FilmgameLv : XlsConfigBase<FilmgameLv, IFilmgameLvInfo>
	{
		public override string fileName
		{
			get
			{
				return "filmgameLv";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFilmgameLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFilmgameLvInfo();
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
