namespace core.config.pet_skin
{
	public class ISkinItem
	{
		public string Go { get; set; }

		public string GoType { get; set; }

		public string Name { get; set; }

		public ISkinKindItem[] SkinKind { get; set; }

		public int ID { get; set; }

		public int Jumptarget { get; set; }

		public int MonID { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GoType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SkinKind = new ISkinKindItem[num];
				for (int i = 0; i < num; i++)
				{
					SkinKind[i] = new ISkinKindItem();
					SkinKind[i].Parse(bytes, ref byteIndex);
				}
			}
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
