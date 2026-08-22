namespace core.config
{
	public class Emoji : XlsConfigBase<Emoji, IEmojiInfo>
	{
		public override string fileName
		{
			get
			{
				return "emoji";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IEmojiInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IEmojiInfo();
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
