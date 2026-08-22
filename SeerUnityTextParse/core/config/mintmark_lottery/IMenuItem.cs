namespace core.config.mintmark_lottery
{
	public class IMenuItem
	{
		public IMintMarkItem[] MintMark { get; set; }

		public int Level { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MintMark = new IMintMarkItem[num];
				for (int i = 0; i < num; i++)
				{
					MintMark[i] = new IMintMarkItem();
					MintMark[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
