namespace core.config
{
	public class IPetCompositioInfo : IConfigItem
	{
		public string activatestat { get; set; }

		public string changestat { get; set; }

		public string desc { get; set; }

		public int[] allpet { get; set; }

		public int id { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			activatestat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				allpet = new int[num];
				for (int i = 0; i < num; i++)
				{
					allpet[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			changestat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
