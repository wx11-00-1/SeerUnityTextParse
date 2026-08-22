namespace core.config.open_bonus
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		public override string fileName
		{
			get
			{
				return "open_bonus";
			}
		}

		public IRoot Root { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Root = new IRoot();
				Root.Parse(bytes, ref byteIndex);
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
