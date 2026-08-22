namespace core.config
{
	public class IPuchuStageInfoConfigInfo : IConfigItem
	{
		public string stageName { get; set; }

		public string stageTutorial { get; set; }

		public int[] stageMainMap { get; set; }

		public int id { get; set; }

		public int stageInitialStep { get; set; }

		public int stagePrice { get; set; }

		public int stageType { get; set; }

		public int stageUnlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageInitialStep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				stageMainMap = new int[num];
				for (int i = 0; i < num; i++)
				{
					stageMainMap[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			stageName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stagePrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageTutorial = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stageType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageUnlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
