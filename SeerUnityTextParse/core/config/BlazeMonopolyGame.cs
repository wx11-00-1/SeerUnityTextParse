using System;

namespace core.config
{
	// Token: 0x02001CC9 RID: 7369
	public class BlazeMonopolyGame : XlsConfigBase<BlazeMonopolyGame, IBlazeMonopolyGameInfo>
	{
		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x0600D5E4 RID: 54756 RVA: 0x003CC38A File Offset: 0x003CA58A
		public override string fileName
		{
			get
			{
				return "blazeMonopolyGame";
			}
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x003CC394 File Offset: 0x003CA594
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBlazeMonopolyGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBlazeMonopolyGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x003CC3E8 File Offset: 0x003CA5E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
