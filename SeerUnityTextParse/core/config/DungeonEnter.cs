namespace core.config
{
	public class DungeonEnter : XlsConfigBase<DungeonEnter, IDungeonEnterInfo>
	{
		public override string fileName
		{
			get
			{
				return "dungeon_enter";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDungeonEnterInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDungeonEnterInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
