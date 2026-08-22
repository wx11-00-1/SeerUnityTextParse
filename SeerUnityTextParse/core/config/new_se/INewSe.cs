namespace core.config.new_se
{
	public class INewSe
	{
		public INewSeIdxItem[] NewSeIdx { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				NewSeIdx = new INewSeIdxItem[num];
				for (int i = 0; i < num; i++)
				{
					NewSeIdx[i] = new INewSeIdxItem();
					NewSeIdx[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
