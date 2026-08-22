namespace core.config
{
	public class IBuildingWarBuildingInfo : IConfigItem
	{
		public int[] bornpoint { get; set; }

		public int[] linkbuilding { get; set; }

		public int[] startaction { get; set; }

		public int buildingid { get; set; }

		public int camp { get; set; }

		public int id { get; set; }

		public int initialhp { get; set; }

		public int stageid { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				bornpoint = new int[num];
				for (int i = 0; i < num; i++)
				{
					bornpoint[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			buildingid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			camp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				linkbuilding = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					linkbuilding[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				startaction = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					startaction[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
