using System;

namespace core.config
{
	// Token: 0x02001D8F RID: 7567
	public class Mallrefresh : XlsConfigBase<Mallrefresh, IMallrefreshInfo>
	{
		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600DE06 RID: 56838 RVA: 0x003D633F File Offset: 0x003D453F
		public override string fileName
		{
			get
			{
				return "mallrefresh";
			}
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x003D6348 File Offset: 0x003D4548
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMallrefreshInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMallrefreshInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE08 RID: 56840 RVA: 0x003D639C File Offset: 0x003D459C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
