namespace core.config.figure_reward
{
	public class IAch
	{
		public int BranchID { get; set; }

		public int RuleID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			BranchID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RuleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
