namespace core.config.newer_guide_h5_2
{
	public class IRoot
	{
		public INewer autocard { get; set; }

		public INewer brave { get; set; }

		public INewer newer { get; set; }

		public INewer newerpay { get; set; }

		public INewer normal { get; set; }

		public string timelimit { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				autocard = new INewer();
				autocard.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				brave = new INewer();
				brave.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				newer = new INewer();
				newer.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				newerpay = new INewer();
				newerpay.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				normal = new INewer();
				normal.Parse(bytes, ref byteIndex);
			}
			timelimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
