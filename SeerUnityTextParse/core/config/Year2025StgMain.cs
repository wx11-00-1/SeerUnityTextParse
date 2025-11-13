using System;

namespace core.config
{
	// Token: 0x02001E93 RID: 7827
	public class Year2025StgMain : XlsConfigBase<Year2025StgMain, IYear2025StgMainInfo>
	{
		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x003E427B File Offset: 0x003E247B
		public override string fileName
		{
			get
			{
				return "year2025_stg_main";
			}
		}

		// Token: 0x0600E917 RID: 59671 RVA: 0x003E4284 File Offset: 0x003E2484
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025StgMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025StgMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x003E42D8 File Offset: 0x003E24D8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
