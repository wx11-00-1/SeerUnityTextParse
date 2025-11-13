using System;

namespace core.config
{
	// Token: 0x02001E8D RID: 7821
	public class Year2025QteMain : XlsConfigBase<Year2025QteMain, IYear2025QteMainInfo>
	{
		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x003E3DB4 File Offset: 0x003E1FB4
		public override string fileName
		{
			get
			{
				return "year2025_qte_main";
			}
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x003E3DBC File Offset: 0x003E1FBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025QteMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025QteMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x003E3E10 File Offset: 0x003E2010
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
