using System;

namespace core.config
{
	// Token: 0x0200211C RID: 8476
	public class Announcement : XlsConfigBase<Announcement, IAnnouncementInfo>
	{
		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x0600FB92 RID: 64402 RVA: 0x0047BCEC File Offset: 0x00479EEC
		public override string fileName
		{
			get
			{
				return "announcement";
			}
		}

		// Token: 0x0600FB93 RID: 64403 RVA: 0x0047BCF4 File Offset: 0x00479EF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAnnouncementInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAnnouncementInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FB94 RID: 64404 RVA: 0x0047BD48 File Offset: 0x00479F48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
