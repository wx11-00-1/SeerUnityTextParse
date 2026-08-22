namespace core.config
{
	public class Furniture : XlsConfigBase<Furniture, IFurnitureInfo>
	{
		public override string fileName
		{
			get
			{
				return "furniture";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFurnitureInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFurnitureInfo();
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
