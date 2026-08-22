namespace core.config.achievements_temp
{
	public class ITypeItem
	{
		public IBranchesItem[] Branches { get; set; }

		public string Desc { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Branches = new IBranchesItem[num];
				for (int i = 0; i < num; i++)
				{
					Branches[i] = new IBranchesItem();
					Branches[i].Parse(bytes, ref byteIndex);
				}
			}
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
