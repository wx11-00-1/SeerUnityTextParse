namespace core.config.achievement_rule
{
	public class IBranchItem
	{
		public int ID { get; set; }

		public int IsSingle { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsSingle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
