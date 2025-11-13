using System;

namespace core.config
{
	// Token: 0x02001E97 RID: 7831
	public class YearPetTrain2025 : XlsConfigBase<YearPetTrain2025, IYearPetTrain2025Info>
	{
		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x0600E942 RID: 59714 RVA: 0x003E4645 File Offset: 0x003E2845
		public override string fileName
		{
			get
			{
				return "YearPetTrain2025";
			}
		}

		// Token: 0x0600E943 RID: 59715 RVA: 0x003E464C File Offset: 0x003E284C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYearPetTrain2025Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYearPetTrain2025Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x003E46A0 File Offset: 0x003E28A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
