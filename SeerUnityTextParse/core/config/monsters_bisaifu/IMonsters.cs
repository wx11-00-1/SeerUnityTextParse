namespace core.config.monsters_bisaifu
{
	public class IMonsters
	{
		public IMonsterItem[] Monster { get; set; }

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
		}
	}
}
