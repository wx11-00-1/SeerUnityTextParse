namespace core.config
{
	public class IYear2025StgCharactorInfo : IConfigItem
	{
		public string prefabPath { get; set; }

		public int[] skills { get; set; }

		public int atk { get; set; }

		public int def { get; set; }

		public int hp { get; set; }

		public int id { get; set; }

		public int speed { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			prefabPath = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				skills = new int[num];
				for (int i = 0; i < num; i++)
				{
					skills[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
