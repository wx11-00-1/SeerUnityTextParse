using System;

namespace core.config
{
	// Token: 0x02001E83 RID: 7811
	public class VenueInformation : XlsConfigBase<VenueInformation, IVenueInformationInfo>
	{
		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600E88A RID: 59530 RVA: 0x003E3708 File Offset: 0x003E1908
		public override string fileName
		{
			get
			{
				return "venueInformation";
			}
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x003E3710 File Offset: 0x003E1910
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IVenueInformationInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IVenueInformationInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x003E3764 File Offset: 0x003E1964
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
