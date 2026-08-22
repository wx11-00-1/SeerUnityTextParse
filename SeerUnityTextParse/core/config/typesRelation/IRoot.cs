namespace core.config.typesRelation
{
	public class IRoot
	{
		public IRelationItem[] Relation { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Relation = new IRelationItem[num];
				for (int i = 0; i < num; i++)
				{
					Relation[i] = new IRelationItem();
					Relation[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
