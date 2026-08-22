using System;

namespace core.config.monsters
{
	public class ILearnableMoves
	{
		public ISpMoveItem[] AdvMove { get; set; }

		public IMoveItem[] Move { get; set; }

		public ISpMoveItem[] SpMove { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num > 0)
				{
					AdvMove = new ISpMoveItem[num];
					for (int i = 0; i < num; i++)
					{
						AdvMove[i] = new ISpMoveItem();
						AdvMove[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num2 = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num2 > 0)
				{
					Move = new IMoveItem[num2];
					for (int j = 0; j < num2; j++)
					{
						Move[j] = new IMoveItem();
						Move[j].Parse(bytes, ref byteIndex2);
					}
				}
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num3 = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num3 > 0)
				{
					SpMove = new ISpMoveItem[num3];
					for (int k = 0; k < num3; k++)
					{
						SpMove[k] = new ISpMoveItem();
						SpMove[k].Parse(bytes, ref byteIndex2);
					}
				}
			}
			byteIndex = byteIndex2;
		}
	}
}
