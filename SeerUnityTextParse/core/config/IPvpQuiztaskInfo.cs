namespace core.config
{
	public class IPvpQuiztaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public int[] rewardinfo { get; set; }

		public int id { get; set; }

		public int jumptarget { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
