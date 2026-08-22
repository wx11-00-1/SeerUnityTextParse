namespace core.config.equip
{
	public class IEquipItem
	{
		public string Desc { get; set; }

		public string Name { get; set; }

		public IRankItem[] Rank { get; set; }

		public int ItemID { get; set; }

		public int Quality { get; set; }

		public int SuitID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Rank = new IRankItem[num];
				for (int i = 0; i < num; i++)
				{
					Rank[i] = new IRankItem();
					Rank[i].Parse(bytes, ref byteIndex);
				}
			}
			SuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
