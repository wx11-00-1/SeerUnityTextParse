namespace core.config.Wishpart
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		public override string fileName
		{
			get
			{
				return "Wishpart";
			}
		}

		public IWishparts Wishparts { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Wishparts = new IWishparts();
				Wishparts.Parse(bytes, ref byteIndex);
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
