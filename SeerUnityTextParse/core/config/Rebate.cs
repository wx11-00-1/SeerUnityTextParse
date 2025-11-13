using System;

namespace core.config
{
	// Token: 0x02001DEF RID: 7663
	public class Rebate : XlsConfigBase<Rebate, IRebateInfo>
	{
		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x0600E230 RID: 57904 RVA: 0x003DB5E1 File Offset: 0x003D97E1
		public override string fileName
		{
			get
			{
				return "rebate";
			}
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x003DB5E8 File Offset: 0x003D97E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRebateInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRebateInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E232 RID: 57906 RVA: 0x003DB63C File Offset: 0x003D983C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
