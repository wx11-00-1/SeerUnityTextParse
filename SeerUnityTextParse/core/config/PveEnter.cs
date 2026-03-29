using System;

namespace core.config
{
	// Token: 0x0200230C RID: 8972
	public class PveEnter : XlsConfigBase<PveEnter, IPveEnterInfo>
	{
		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06011116 RID: 69910 RVA: 0x00495DA7 File Offset: 0x00493FA7
		public override string fileName
		{
			get
			{
				return "pveEnter";
			}
		}

		// Token: 0x06011117 RID: 69911 RVA: 0x00495DB0 File Offset: 0x00493FB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPveEnterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPveEnterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011118 RID: 69912 RVA: 0x00495E04 File Offset: 0x00494004
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
