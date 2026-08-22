namespace core.config.Wishpart
{
	public class IWishparts
	{
		public IWishpartItem[] Wishpart { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Wishpart = new IWishpartItem[num];
				for (int i = 0; i < num; i++)
				{
					Wishpart[i] = new IWishpartItem();
					Wishpart[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
