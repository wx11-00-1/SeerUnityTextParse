namespace core.config
{
	public class LlrestaurantLvl : XlsConfigBase<LlrestaurantLvl, ILlrestaurantLvlInfo>
	{
		public override string fileName
		{
			get
			{
				return "llrestaurant_lvl";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILlrestaurantLvlInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILlrestaurantLvlInfo();
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
