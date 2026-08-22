namespace core.config.map_config
{
	public class IMapItem : IConfigItem
	{
		public IChangeMapComp changeMapComp { get; set; }

		public IEntries Entries { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Entries = new IEntries();
				Entries.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				changeMapComp = new IChangeMapComp();
				changeMapComp.Parse(bytes, ref byteIndex);
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
