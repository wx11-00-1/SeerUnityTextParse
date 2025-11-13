using System;

namespace core.config
{
	// Token: 0x02001CE7 RID: 7399
	public class Channel : XlsConfigBase<Channel, IChannelInfo>
	{
		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x0600D6DE RID: 55006 RVA: 0x003CD892 File Offset: 0x003CBA92
		public override string fileName
		{
			get
			{
				return "channel";
			}
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x003CD89C File Offset: 0x003CBA9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChannelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChannelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x003CD8F0 File Offset: 0x003CBAF0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
