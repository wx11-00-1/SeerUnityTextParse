namespace core.config
{
	public class CarrygameStage : XlsConfigBase<CarrygameStage, ICarrygameStageInfo>
	{
		public override string fileName
		{
			get
			{
				return "carrygame_stage";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ICarrygameStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ICarrygameStageInfo();
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
