namespace core.config.achievements
{
	public class IBranchesItem
	{
		public IBranchItem[] Branch { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Branch = new IBranchItem[num];
				for (int i = 0; i < num; i++)
				{
					Branch[i] = new IBranchItem();
					Branch[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
