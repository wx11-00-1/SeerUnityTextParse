namespace core.config
{
	public class Storymodel : XlsConfigBase<Storymodel, IStorymodelInfo>
	{
		public override string fileName
		{
			get
			{
				return "storymodel";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStorymodelInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStorymodelInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
