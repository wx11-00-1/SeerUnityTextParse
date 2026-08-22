namespace core.config
{
	public class LlsCookingLvl : XlsConfigBase<LlsCookingLvl, ILlsCookingLvlInfo>
	{
		public override string fileName
		{
			get
			{
				return "lls_cooking_lvl";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILlsCookingLvlInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILlsCookingLvlInfo();
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
