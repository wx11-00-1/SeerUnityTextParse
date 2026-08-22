namespace core.config.monsters_bisaifu
{
	public class ILearnableMoves
	{
		public ISpMoveItem[] AdvMove { get; set; }

		public IMoveItem[] Move { get; set; }

		public ISpMoveItem[] SpMove { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				AdvMove = new ISpMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					AdvMove[i] = new ISpMoveItem();
					AdvMove[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Move = new IMoveItem[num2];
				for (int j = 0; j < num2; j++)
				{
					Move[j] = new IMoveItem();
					Move[j].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SpMove = new ISpMoveItem[num3];
				for (int k = 0; k < num3; k++)
				{
					SpMove[k] = new ISpMoveItem();
					SpMove[k].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
