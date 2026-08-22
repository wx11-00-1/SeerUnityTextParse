namespace core.config
{
	public class ChessGameEventtype : XlsConfigBase<ChessGameEventtype, IChessGameEventtypeInfo>
	{
		public override string fileName
		{
			get
			{
				return "chessGame_eventtype";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IChessGameEventtypeInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IChessGameEventtypeInfo();
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
