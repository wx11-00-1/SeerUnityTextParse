namespace core.config.effectbuff
{
	public class IRoot
	{
		public IBuffItem[] Buff { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Buff = new IBuffItem[num];
				for (int i = 0; i < num; i++)
				{
					Buff[i] = new IBuffItem();
					Buff[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
