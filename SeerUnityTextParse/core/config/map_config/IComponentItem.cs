namespace core.config.map_config
{
	public class IComponentItem
	{
		public int targetID { get; set; }

		public float x { get; set; }

		public float y { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			targetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			x = ByteUtil.ReadFloat(bytes, ref byteIndex);
			y = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
