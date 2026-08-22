namespace core.config
{
	public class MapTemp : XlsConfigBase<MapTemp, IMapTempInfo>
	{
		public override string fileName
		{
			get
			{
				return "map_temp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IMapTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IMapTempInfo();
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
