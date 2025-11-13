using System;

namespace core.config
{
	// Token: 0x02001DC9 RID: 7625
	public class PrivateSign : XlsConfigBase<PrivateSign, IPrivateSignInfo>
	{
		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600E082 RID: 57474 RVA: 0x003D953B File Offset: 0x003D773B
		public override string fileName
		{
			get
			{
				return "privateSign";
			}
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x003D9544 File Offset: 0x003D7744
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPrivateSignInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPrivateSignInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x003D9598 File Offset: 0x003D7798
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
