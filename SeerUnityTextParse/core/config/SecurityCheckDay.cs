using System;

namespace core.config
{
	// Token: 0x02001E0B RID: 7691
	public class SecurityCheckDay : XlsConfigBase<SecurityCheckDay, ISecurityCheckDayInfo>
	{
		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600E346 RID: 58182 RVA: 0x003DCE02 File Offset: 0x003DB002
		public override string fileName
		{
			get
			{
				return "securityCheck_day";
			}
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x003DCE0C File Offset: 0x003DB00C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISecurityCheckDayInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISecurityCheckDayInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x003DCE60 File Offset: 0x003DB060
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
