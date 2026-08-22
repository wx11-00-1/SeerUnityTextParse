namespace core.config.advancedPetPanelConfig
{
	public class IFreeTime
	{
		public int Id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
