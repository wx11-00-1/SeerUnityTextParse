namespace core.config.newer_guide_h5_2
{
	public class IStepsItem : IConfigItem
	{
		public string align { get; set; }

		public string btnName { get; set; }

		public string msg { get; set; }

		public string strokeColor { get; set; }

		public string targetBtn { get; set; }

		public int[] position { get; set; }

		public int autoX { get; set; }

		public int holeType { get; set; }

		public int id { get; set; }

		public int openMenu { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			align = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			autoX = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			btnName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			holeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			openMenu = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				position = new int[num];
				for (int i = 0; i < num; i++)
				{
					position[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			strokeColor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			targetBtn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
