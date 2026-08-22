namespace core.config
{
	public class InsectFormation : XlsConfigBase<InsectFormation, IInsectFormationInfo>
	{
		public override string fileName
		{
			get
			{
				return "insectFormation";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IInsectFormationInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IInsectFormationInfo();
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
