namespace core.config
{
	public class SecurityCheckPerson : XlsConfigBase<SecurityCheckPerson, ISecurityCheckPersonInfo>
	{
		public override string fileName
		{
			get
			{
				return "securityCheck_person";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISecurityCheckPersonInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISecurityCheckPersonInfo();
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
