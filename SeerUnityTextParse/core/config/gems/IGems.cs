namespace core.config.gems
{
	public class IGems
	{
		public IGemItem[] Gem { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Gem = new IGemItem[num];
				for (int i = 0; i < num; i++)
				{
					Gem[i] = new IGemItem();
					Gem[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
