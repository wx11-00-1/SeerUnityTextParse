namespace core.config.petbook_bisaifu
{
	public class ITypeItem
	{
		public IBranchItem[] Branch { get; set; }

		public int ID { get; set; }

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
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
