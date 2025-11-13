using System;

namespace core.config
{
	// Token: 0x02001E39 RID: 7737
	public class Starmaplist : XlsConfigBase<Starmaplist, IStarmaplistInfo>
	{
		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600E54E RID: 58702 RVA: 0x003DF766 File Offset: 0x003DD966
		public override string fileName
		{
			get
			{
				return "starmaplist";
			}
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x003DF770 File Offset: 0x003DD970
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStarmaplistInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStarmaplistInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x003DF7C4 File Offset: 0x003DD9C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
