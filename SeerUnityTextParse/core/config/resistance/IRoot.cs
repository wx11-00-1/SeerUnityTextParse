namespace core.config.resistance
{
	public class IRoot
	{
		public IHurtItem[] hurt { get; set; }

		public IHurtItem[] resistance { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				hurt = new IHurtItem[num];
				for (int i = 0; i < num; i++)
				{
					hurt[i] = new IHurtItem();
					hurt[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				resistance = new IHurtItem[num2];
				for (int j = 0; j < num2; j++)
				{
					resistance[j] = new IHurtItem();
					resistance[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
