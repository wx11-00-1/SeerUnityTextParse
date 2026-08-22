namespace core.config.addmoves
{
	public class IMoves
	{
		public IMoveItem[] Move { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Move = new IMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					Move[i] = new IMoveItem();
					Move[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
