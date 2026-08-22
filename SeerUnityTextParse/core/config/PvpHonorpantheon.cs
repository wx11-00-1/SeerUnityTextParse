namespace core.config
{
	public class PvpHonorpantheon : XlsConfigBase<PvpHonorpantheon, IPvpHonorpantheonInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_honorpantheon";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpHonorpantheonInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpHonorpantheonInfo();
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
