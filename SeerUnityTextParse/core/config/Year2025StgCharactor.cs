using System;

namespace core.config
{
	// Token: 0x02001E91 RID: 7825
	public class Year2025StgCharactor : XlsConfigBase<Year2025StgCharactor, IYear2025StgCharactorInfo>
	{
		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x0600E900 RID: 59648 RVA: 0x003E40C7 File Offset: 0x003E22C7
		public override string fileName
		{
			get
			{
				return "year2025_stg_charactor";
			}
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x003E40D0 File Offset: 0x003E22D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025StgCharactorInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025StgCharactorInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x003E4124 File Offset: 0x003E2324
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
