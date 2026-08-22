namespace core.config.free_monster_list
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		public override string fileName
		{
			get
			{
				return "free_monster_list";
			}
		}

		public IMonsters Monsters { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Monsters = new IMonsters();
				Monsters.Parse(bytes, ref byteIndex);
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
