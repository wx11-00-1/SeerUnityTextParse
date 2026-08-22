namespace core.config.move_stones
{
	public class IMoveEffectItem
	{
		public int[] SideEffect { get; set; }

		public int[] SideEffectArg { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SideEffect = new int[num];
				for (int i = 0; i < num; i++)
				{
					SideEffect[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SideEffectArg = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					SideEffectArg[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
