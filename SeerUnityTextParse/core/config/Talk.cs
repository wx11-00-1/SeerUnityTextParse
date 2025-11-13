using System;

namespace core.config
{
	// Token: 0x02001E73 RID: 7795
	public class Talk : XlsConfigBase<Talk, ITalkInfo>
	{
		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x003E29B2 File Offset: 0x003E0BB2
		public override string fileName
		{
			get
			{
				return "talk";
			}
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x003E29BC File Offset: 0x003E0BBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITalkInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITalkInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x003E2A10 File Offset: 0x003E0C10
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
