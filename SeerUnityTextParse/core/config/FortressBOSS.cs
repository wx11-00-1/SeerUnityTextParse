using System;

namespace core.config
{
	// Token: 0x02001D55 RID: 7509
	public class FortressBOSS : XlsConfigBase<FortressBOSS, IFortressBOSSInfo>
	{
		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x0600DBDC RID: 56284 RVA: 0x003D38BB File Offset: 0x003D1ABB
		public override string fileName
		{
			get
			{
				return "fortressBOSS";
			}
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x003D38C4 File Offset: 0x003D1AC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFortressBOSSInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFortressBOSSInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DBDE RID: 56286 RVA: 0x003D3918 File Offset: 0x003D1B18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
