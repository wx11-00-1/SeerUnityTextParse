using System;

namespace core.config
{
	// Token: 0x02001CC3 RID: 7363
	public class Battletalk : XlsConfigBase<Battletalk, IBattletalkInfo>
	{
		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600D5B0 RID: 54704 RVA: 0x003CBFC7 File Offset: 0x003CA1C7
		public override string fileName
		{
			get
			{
				return "battletalk";
			}
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x003CBFD0 File Offset: 0x003CA1D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattletalkInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattletalkInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x003CC024 File Offset: 0x003CA224
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
