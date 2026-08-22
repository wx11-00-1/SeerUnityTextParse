namespace core.config.free_monster_list
{
	public class IMonsters
	{
		public IMonsterItem[] Monster { get; set; }

		public string SumDes { get; set; }

		public string UpdateDes { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					Monster[i] = new IMonsterItem();
					Monster[i].Parse(bytes, ref byteIndex);
				}
			}
			SumDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			UpdateDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
