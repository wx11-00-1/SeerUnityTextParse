namespace core.config.open_bonus
{
	public class IOutItem
	{
		public IMintmark Mintmark { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Mintmark = new IMintmark();
				Mintmark.Parse(bytes, ref byteIndex);
			}
		}
	}
}
