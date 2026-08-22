namespace core.config.bossEffectIcon
{
	public class IRoot
	{
		public IBossEffectItem[] bossEffect { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				bossEffect = new IBossEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					bossEffect[i] = new IBossEffectItem();
					bossEffect[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
