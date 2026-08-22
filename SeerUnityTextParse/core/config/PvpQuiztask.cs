namespace core.config
{
	public class PvpQuiztask : XlsConfigBase<PvpQuiztask, IPvpQuiztaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_quiztask";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpQuiztaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpQuiztaskInfo();
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
