namespace core.config
{
	public class FilmgameAction : XlsConfigBase<FilmgameAction, IFilmgameActionInfo>
	{
		public override string fileName
		{
			get
			{
				return "filmgameAction";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFilmgameActionInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFilmgameActionInfo();
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
