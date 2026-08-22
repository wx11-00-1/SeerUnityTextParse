namespace core.config
{
	public class PvpCostModeCost : XlsConfigBase<PvpCostModeCost, IPvpCostModeCostInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvpCostMode_cost";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpCostModeCostInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpCostModeCostInfo();
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
