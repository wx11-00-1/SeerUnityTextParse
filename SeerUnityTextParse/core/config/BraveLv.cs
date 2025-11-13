using System;

namespace core.config
{
	// Token: 0x02001CDB RID: 7387
	public class BraveLv : XlsConfigBase<BraveLv, IBraveLvInfo>
	{
		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x0600D674 RID: 54900 RVA: 0x003CCE96 File Offset: 0x003CB096
		public override string fileName
		{
			get
			{
				return "brave_lv";
			}
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x003CCEA0 File Offset: 0x003CB0A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveLvInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D676 RID: 54902 RVA: 0x003CCEF4 File Offset: 0x003CB0F4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
