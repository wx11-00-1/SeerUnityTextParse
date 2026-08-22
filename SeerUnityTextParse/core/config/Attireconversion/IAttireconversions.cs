namespace core.config.Attireconversion
{
	public class IAttireconversions
	{
		public IAttireconversionItem[] Attireconversion { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Attireconversion = new IAttireconversionItem[num];
				for (int i = 0; i < num; i++)
				{
					Attireconversion[i] = new IAttireconversionItem();
					Attireconversion[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
