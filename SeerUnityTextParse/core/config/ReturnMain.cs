using System;

namespace core.config
{
	// Token: 0x02001DF9 RID: 7673
	public class ReturnMain : XlsConfigBase<ReturnMain, IReturnMainInfo>
	{
		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600E28A RID: 57994 RVA: 0x003DBCBF File Offset: 0x003D9EBF
		public override string fileName
		{
			get
			{
				return "return_main";
			}
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x003DBCC8 File Offset: 0x003D9EC8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IReturnMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IReturnMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x003DBD1C File Offset: 0x003D9F1C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
