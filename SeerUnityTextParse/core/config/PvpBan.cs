using System;

namespace core.config
{
	// Token: 0x02001DD9 RID: 7641
	public class PvpBan : XlsConfigBase<PvpBan, IPvpBanInfo>
	{
		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x0600E122 RID: 57634 RVA: 0x003DA2C0 File Offset: 0x003D84C0
		public override string fileName
		{
			get
			{
				return "pvp_ban";
			}
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x003DA2C8 File Offset: 0x003D84C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpBanInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpBanInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x003DA31C File Offset: 0x003D851C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
