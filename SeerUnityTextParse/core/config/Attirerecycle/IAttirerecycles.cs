namespace core.config.Attirerecycle
{
	public class IAttirerecycles
	{
		public IAttirerecycleItem[] Attirerecycle { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Attirerecycle = new IAttirerecycleItem[num];
				for (int i = 0; i < num; i++)
				{
					Attirerecycle[i] = new IAttirerecycleItem();
					Attirerecycle[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
