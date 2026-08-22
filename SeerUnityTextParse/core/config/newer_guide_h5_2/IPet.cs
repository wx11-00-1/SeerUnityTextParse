namespace core.config.newer_guide_h5_2
{
	public class IPet
	{
		public int petId { get; set; }

		public int x { get; set; }

		public int y { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			x = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			y = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
