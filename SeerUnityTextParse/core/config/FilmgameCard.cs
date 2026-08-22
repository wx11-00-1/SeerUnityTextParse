namespace core.config
{
	public class FilmgameCard : XlsConfigBase<FilmgameCard, IFilmgameCardInfo>
	{
		public override string fileName
		{
			get
			{
				return "filmgameCard";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFilmgameCardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFilmgameCardInfo();
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
