namespace core.config.effectInfo
{
	public class IEffectItem : IConfigItem
	{
		public string analyze { get; set; }

		public string info { get; set; }

		public string key { get; set; }

		public int[] param { get; set; }

		public int argsNum { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			analyze = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			argsNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			key = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				param = new int[num];
				for (int i = 0; i < num; i++)
				{
					param[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
