using System;

namespace core.config
{
	// Token: 0x02001E23 RID: 7715
	public class Sixteenyearsactpanel : XlsConfigBase<Sixteenyearsactpanel, ISixteenyearsactpanelInfo>
	{
		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600E462 RID: 58466 RVA: 0x003DE4F7 File Offset: 0x003DC6F7
		public override string fileName
		{
			get
			{
				return "sixteenyearsactpanel";
			}
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x003DE500 File Offset: 0x003DC700
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISixteenyearsactpanelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISixteenyearsactpanelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x003DE554 File Offset: 0x003DC754
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
