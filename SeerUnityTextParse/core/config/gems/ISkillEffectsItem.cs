namespace core.config.gems
{
	public class ISkillEffectsItem
	{
		public IEffect Effect { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Effect = new IEffect();
				Effect.Parse(bytes, ref byteIndex);
			}
		}
	}
}
