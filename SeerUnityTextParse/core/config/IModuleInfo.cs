namespace core.config
{
	public class IModuleInfo : IConfigItem
	{
		public string moduleName { get; set; }

		public string[] resConfig { get; set; }

		public int currAppDo { get; set; }

		public int id { get; set; }

		public int isFullScreen { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			currAppDo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isFullScreen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moduleName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				resConfig = new string[num];
				for (int i = 0; i < num; i++)
				{
					resConfig[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
