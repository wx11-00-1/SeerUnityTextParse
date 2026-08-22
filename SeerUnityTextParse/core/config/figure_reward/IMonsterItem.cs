namespace core.config.figure_reward
{
	public class IMonsterItem
	{
		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
