using System;

namespace core.config
{
	// Token: 0x02001DC3 RID: 7619
	public class Popup : XlsConfigBase<Popup, IPopupInfo>
	{
		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x0600E044 RID: 57412 RVA: 0x003D90D5 File Offset: 0x003D72D5
		public override string fileName
		{
			get
			{
				return "Popup";
			}
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x003D90DC File Offset: 0x003D72DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPopupInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPopupInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x003D9130 File Offset: 0x003D7330
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
