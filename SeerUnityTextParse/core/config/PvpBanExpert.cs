namespace core.config
{
	public class PvpBanExpert : XlsConfigBase<PvpBanExpert, IPvpBanExpertInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_ban_expert";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpBanExpertInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpBanExpertInfo();
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
