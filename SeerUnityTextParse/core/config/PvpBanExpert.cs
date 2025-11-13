using System;

namespace core.config
{
	// Token: 0x02001DDB RID: 7643
	public class PvpBanExpert : XlsConfigBase<PvpBanExpert, IPvpBanExpertInfo>
	{
		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600E132 RID: 57650 RVA: 0x003DA415 File Offset: 0x003D8615
		public override string fileName
		{
			get
			{
				return "pvp_ban_expert";
			}
		}

		// Token: 0x0600E133 RID: 57651 RVA: 0x003DA41C File Offset: 0x003D861C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpBanExpertInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpBanExpertInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E134 RID: 57652 RVA: 0x003DA470 File Offset: 0x003D8670
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
