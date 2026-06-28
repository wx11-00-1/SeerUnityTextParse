using System;

namespace core.config
{
	// Token: 0x020027BA RID: 10170
	public class SeerShipChooseGame : XlsConfigBase<SeerShipChooseGame, ISeerShipChooseGameInfo>
	{
		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x060142FF RID: 82687 RVA: 0x005653A9 File Offset: 0x005635A9
		public override string fileName
		{
			get
			{
				return "seerShipChooseGame";
			}
		}

		// Token: 0x06014300 RID: 82688 RVA: 0x005653B0 File Offset: 0x005635B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISeerShipChooseGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISeerShipChooseGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014301 RID: 82689 RVA: 0x00565404 File Offset: 0x00563604
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
