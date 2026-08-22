namespace core.config.typesRelation
{
	public class IRelationItem
	{
		public IOpponentItem[] Opponent { get; set; }

		public string type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Opponent = new IOpponentItem[num];
				for (int i = 0; i < num; i++)
				{
					Opponent[i] = new IOpponentItem();
					Opponent[i].Parse(bytes, ref byteIndex);
				}
			}
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
