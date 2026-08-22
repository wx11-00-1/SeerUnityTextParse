namespace core.config.advancedPetPanelConfig
{
	public class IMainPanel
	{
		public IFreeTime FreeTime { get; set; }

		public IFreeTime PayTime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				FreeTime = new IFreeTime();
				FreeTime.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				PayTime = new IFreeTime();
				PayTime.Parse(bytes, ref byteIndex);
			}
		}
	}
}
