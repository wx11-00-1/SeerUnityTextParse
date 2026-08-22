namespace core.config
{
	public class BitBuffer : XlsConfigBase<BitBuffer, IBitBufferInfo>
	{
		public override string fileName
		{
			get
			{
				return "bitBuffer";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBitBufferInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBitBufferInfo();
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
