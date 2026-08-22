namespace core.config.Unbindmintinfo
{
	public class IUnbindmintinfoItem
	{
		public int MintmarkID { get; set; }

		public int NeedConsumeNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NeedConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
