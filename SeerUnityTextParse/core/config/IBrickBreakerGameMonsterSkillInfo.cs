namespace core.config
{
	public class IBrickBreakerGameMonsterSkillInfo : IConfigItem
	{
		public int[] args { get; set; }

		public int accumulate { get; set; }

		public int cd { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			accumulate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				args = new int[num];
				for (int i = 0; i < num; i++)
				{
					args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			cd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
