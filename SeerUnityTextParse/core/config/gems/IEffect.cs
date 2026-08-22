namespace core.config.gems
{
	public class IEffect
	{
		public int[] Param { get; set; }

		public int EffectId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			EffectId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Param = new int[num];
				for (int i = 0; i < num; i++)
				{
					Param[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
