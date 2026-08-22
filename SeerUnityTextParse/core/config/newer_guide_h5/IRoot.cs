namespace core.config.newer_guide_h5
{
	public class IRoot
	{
		public IStepsItem[] steps { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				steps = new IStepsItem[num];
				for (int i = 0; i < num; i++)
				{
					steps[i] = new IStepsItem();
					steps[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
