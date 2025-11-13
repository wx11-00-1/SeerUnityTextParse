using System;

namespace core.config
{
	// Token: 0x02001D23 RID: 7459
	public class DailytaskGift : XlsConfigBase<DailytaskGift, IDailytaskGiftInfo>
	{
		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600D9D4 RID: 55764 RVA: 0x003D0FD4 File Offset: 0x003CF1D4
		public override string fileName
		{
			get
			{
				return "dailytask_gift";
			}
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x003D0FDC File Offset: 0x003CF1DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDailytaskGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDailytaskGiftInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x003D1030 File Offset: 0x003CF230
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
