namespace core.config.move_stones
{
	public class IMoveStones
	{
		public IMoveStoneItem[] MoveStone { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MoveStone = new IMoveStoneItem[num];
				for (int i = 0; i < num; i++)
				{
					MoveStone[i] = new IMoveStoneItem();
					MoveStone[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
