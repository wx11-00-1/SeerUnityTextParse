namespace core.config.peak_battle_mons
{
	public class IVirtualBattle
	{
		public IPeakBtGlobalRule PeakBtGlobalRule { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				PeakBtGlobalRule = new IPeakBtGlobalRule();
				PeakBtGlobalRule.Parse(bytes, ref byteIndex);
			}
		}
	}
}
