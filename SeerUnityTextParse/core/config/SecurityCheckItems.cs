namespace core.config
{
	public class SecurityCheckItems : XlsConfigBase<SecurityCheckItems, ISecurityCheckItemsInfo>
	{
		public override string fileName
		{
			get
			{
				return "securityCheck_items";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISecurityCheckItemsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISecurityCheckItemsInfo();
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
