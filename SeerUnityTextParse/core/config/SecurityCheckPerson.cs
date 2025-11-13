using System;

namespace core.config
{
	// Token: 0x02001E0F RID: 7695
	public class SecurityCheckPerson : XlsConfigBase<SecurityCheckPerson, ISecurityCheckPersonInfo>
	{
		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x0600E360 RID: 58208 RVA: 0x003DD00B File Offset: 0x003DB20B
		public override string fileName
		{
			get
			{
				return "securityCheck_person";
			}
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x003DD014 File Offset: 0x003DB214
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISecurityCheckPersonInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISecurityCheckPersonInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x003DD068 File Offset: 0x003DB268
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
