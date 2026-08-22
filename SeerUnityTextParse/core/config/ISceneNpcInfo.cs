namespace core.config
{
	public class ISceneNpcInfo : IConfigItem
	{
		public string name { get; set; }

		public string pic { get; set; }

		public string triggerinfo { get; set; }

		public int[] FuncParam { get; set; }

		public int bit { get; set; }

		public int FuncParamSpecial { get; set; }

		public int FuncType { get; set; }

		public int id { get; set; }

		public int modelType { get; set; }

		public float offsetX { get; set; }

		public float offsetY { get; set; }

		public float scaleX { get; set; }

		public float scaleY { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				FuncParam = new int[num];
				for (int i = 0; i < num; i++)
				{
					FuncParam[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			FuncParamSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			FuncType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			modelType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			offsetX = ByteUtil.ReadFloat(bytes, ref byteIndex);
			offsetY = ByteUtil.ReadFloat(bytes, ref byteIndex);
			pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			scaleX = ByteUtil.ReadFloat(bytes, ref byteIndex);
			scaleY = ByteUtil.ReadFloat(bytes, ref byteIndex);
			triggerinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
