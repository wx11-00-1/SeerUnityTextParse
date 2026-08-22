namespace core.config.itemType
{
	public class IItemItem
	{
		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
