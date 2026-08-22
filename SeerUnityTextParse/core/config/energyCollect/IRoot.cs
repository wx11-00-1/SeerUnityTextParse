namespace core.config.energyCollect
{
	public class IRoot
	{
		public IEnergyItem[] energy { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				energy = new IEnergyItem[num];
				for (int i = 0; i < num; i++)
				{
					energy[i] = new IEnergyItem();
					energy[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
