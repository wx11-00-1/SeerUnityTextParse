using System;

namespace core.config
{
	// Token: 0x02001D93 RID: 7571
	public class Medaltask : XlsConfigBase<Medaltask, IMedaltaskInfo>
	{
		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600DE36 RID: 56886 RVA: 0x003D6816 File Offset: 0x003D4A16
		public override string fileName
		{
			get
			{
				return "medaltask";
			}
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x003D6820 File Offset: 0x003D4A20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMedaltaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMedaltaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x003D6874 File Offset: 0x003D4A74
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
