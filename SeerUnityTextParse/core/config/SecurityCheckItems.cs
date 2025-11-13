using System;

namespace core.config
{
	// Token: 0x02001E0D RID: 7693
	public class SecurityCheckItems : XlsConfigBase<SecurityCheckItems, ISecurityCheckItemsInfo>
	{
		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600E352 RID: 58194 RVA: 0x003DCEF2 File Offset: 0x003DB0F2
		public override string fileName
		{
			get
			{
				return "securityCheck_items";
			}
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x003DCEFC File Offset: 0x003DB0FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISecurityCheckItemsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISecurityCheckItemsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x003DCF50 File Offset: 0x003DB150
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
