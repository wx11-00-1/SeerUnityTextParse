namespace core.config.sp_hide_moves_bisaifu
{
	public class IConfig
	{
		public ISpMovesItem[] ShowMoves { get; set; }

		public ISpMovesItem[] SpMoves { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				ShowMoves = new ISpMovesItem[num];
				for (int i = 0; i < num; i++)
				{
					ShowMoves[i] = new ISpMovesItem();
					ShowMoves[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SpMoves = new ISpMovesItem[num2];
				for (int j = 0; j < num2; j++)
				{
					SpMoves[j] = new ISpMovesItem();
					SpMoves[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
