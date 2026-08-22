namespace core.config.medals
{
	public class IMedals
	{
		public IMedalItem[] medal { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				medal = new IMedalItem[num];
				for (int i = 0; i < num; i++)
				{
					medal[i] = new IMedalItem();
					medal[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
