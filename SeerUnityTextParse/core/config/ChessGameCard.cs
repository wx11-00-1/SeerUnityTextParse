namespace core.config
{
	public class ChessGameCard : XlsConfigBase<ChessGameCard, IChessGameCardInfo>
	{
		public override string fileName
		{
			get
			{
				return "chessGame_card";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IChessGameCardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IChessGameCardInfo();
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
