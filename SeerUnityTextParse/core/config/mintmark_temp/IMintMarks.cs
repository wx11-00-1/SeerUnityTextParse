namespace core.config.mintmark_temp
{
	public class IMintMarks
	{
		public IMintMarkItem[] MintMark { get; set; }

		public IMintmarkClassItem[] MintmarkClass { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
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
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MintmarkClass = new IMintmarkClassItem[num2];
				for (int j = 0; j < num2; j++)
				{
					MintmarkClass[j] = new IMintmarkClassItem();
					MintmarkClass[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
