using System;

namespace core.config
{
	// Token: 0x02001E2B RID: 7723
	public class SportsMeetingItems : XlsConfigBase<SportsMeetingItems, ISportsMeetingItemsInfo>
	{
		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x0600E4C2 RID: 58562 RVA: 0x003DEBFC File Offset: 0x003DCDFC
		public override string fileName
		{
			get
			{
				return "sportsMeetingItems";
			}
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x003DEC04 File Offset: 0x003DCE04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISportsMeetingItemsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISportsMeetingItemsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x003DEC58 File Offset: 0x003DCE58
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
