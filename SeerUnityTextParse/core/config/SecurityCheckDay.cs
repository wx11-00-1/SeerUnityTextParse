namespace core.config
{
	public class SecurityCheckDay : XlsConfigBase<SecurityCheckDay, ISecurityCheckDayInfo>
	{
		public override string fileName
		{
			get
			{
				return "securityCheck_day";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISecurityCheckDayInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISecurityCheckDayInfo();
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
