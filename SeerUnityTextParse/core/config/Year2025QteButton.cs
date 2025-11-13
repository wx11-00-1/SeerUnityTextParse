using System;

namespace core.config
{
	// Token: 0x02001E8B RID: 7819
	public class Year2025QteButton : XlsConfigBase<Year2025QteButton, IYear2025QteButtonInfo>
	{
		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x0600E8C8 RID: 59592 RVA: 0x003E3C50 File Offset: 0x003E1E50
		public override string fileName
		{
			get
			{
				return "year2025_qte_button";
			}
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x003E3C58 File Offset: 0x003E1E58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025QteButtonInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025QteButtonInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x003E3CAC File Offset: 0x003E1EAC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
