using System;

namespace core.config
{
	// Token: 0x0200268E RID: 9870
	public class SkinStoreTicket : XlsConfigBase<SkinStoreTicket, ISkinStoreTicketInfo>
	{
		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x060132F4 RID: 78580 RVA: 0x00520E76 File Offset: 0x0051F076
		public override string fileName
		{
			get
			{
				return "skinStoreTicket";
			}
		}

		// Token: 0x060132F5 RID: 78581 RVA: 0x00520E80 File Offset: 0x0051F080
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISkinStoreTicketInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISkinStoreTicketInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060132F6 RID: 78582 RVA: 0x00520ED4 File Offset: 0x0051F0D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
