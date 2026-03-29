using System;

namespace core.config
{
	// Token: 0x0200213C RID: 8508
	public class AutocardRole : XlsConfigBase<AutocardRole, IAutocardRoleInfo>
	{
		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600FCCA RID: 64714 RVA: 0x0047D498 File Offset: 0x0047B698
		public override string fileName
		{
			get
			{
				return "autocardRole";
			}
		}

		// Token: 0x0600FCCB RID: 64715 RVA: 0x0047D4A0 File Offset: 0x0047B6A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardRoleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardRoleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FCCC RID: 64716 RVA: 0x0047D4F4 File Offset: 0x0047B6F4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
