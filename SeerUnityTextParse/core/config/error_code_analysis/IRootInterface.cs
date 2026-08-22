namespace core.config.error_code_analysis
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		private bool b;

		public override string fileName
		{
			get
			{
				return "error_code_analysis";
			}
		}

		public IRoot root { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (b)
			{
				root = new IRoot();
				root.Parse(bytes, ref byteIndex);
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
