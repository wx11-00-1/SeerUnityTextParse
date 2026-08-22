namespace core.config.pet_advance
{
	public class ISpMove
	{
		public int[] SpMoves { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SpMoves = new int[num];
				for (int i = 0; i < num; i++)
				{
					SpMoves[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
