namespace core.config
{
	public class StartrekRoute : XlsConfigBase<StartrekRoute, IStartrekRouteInfo>
	{
		public override string fileName
		{
			get
			{
				return "startrek_route";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStartrekRouteInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStartrekRouteInfo();
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
