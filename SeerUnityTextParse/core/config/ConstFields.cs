namespace core.config
{
	public class ConstFields : XlsConfigBase<ConstFields, IConstFieldsInfo>
	{
		public override string fileName
		{
			get
			{
				return "const_fields";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IConstFieldsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IConstFieldsInfo();
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
