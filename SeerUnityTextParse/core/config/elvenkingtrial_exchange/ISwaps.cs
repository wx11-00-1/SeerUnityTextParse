namespace core.config.elvenkingtrial_exchange
{
	public class ISwaps
	{
		public ISwapItem[] swap { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				swap = new ISwapItem[num];
				for (int i = 0; i < num; i++)
				{
					swap[i] = new ISwapItem();
					swap[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
