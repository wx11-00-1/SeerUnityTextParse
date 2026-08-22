namespace core.config.move_change
{
	public class IMove
	{
		public IMovesItem[] Moves { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Moves = new IMovesItem[num];
				for (int i = 0; i < num; i++)
				{
					Moves[i] = new IMovesItem();
					Moves[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
