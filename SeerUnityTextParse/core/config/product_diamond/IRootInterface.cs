namespace core.config.product_diamond
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		public override string fileName
		{
			get
			{
				return "product_diamond";
			}
		}

		public IRoot root { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 < bytes.Length)
			{
				if (bytes[byteIndex2++] != 0)
				{
					root = new IRoot();
					root.Parse(bytes, ref byteIndex2);
				}
				byteIndex = byteIndex2;
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
