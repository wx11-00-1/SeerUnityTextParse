namespace core.config.achievements_temp
{
	public class IAchievementRules
	{
		public ITypeItem[] type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				type = new ITypeItem[num];
				for (int i = 0; i < num; i++)
				{
					type[i] = new ITypeItem();
					type[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
