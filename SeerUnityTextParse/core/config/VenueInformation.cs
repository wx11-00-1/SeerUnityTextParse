namespace core.config
{
	public class VenueInformation : XlsConfigBase<VenueInformation, IVenueInformationInfo>
	{
		public override string fileName
		{
			get
			{
				return "venueInformation";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IVenueInformationInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IVenueInformationInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
