using System;

namespace core.config
{
	// Token: 0x0200236E RID: 9070
	public class SpiderSolitaireGame : XlsConfigBase<SpiderSolitaireGame, ISpiderSolitaireGameInfo>
	{
		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0601158C RID: 71052 RVA: 0x0049B678 File Offset: 0x00499878
		public override string fileName
		{
			get
			{
				return "spiderSolitaireGame";
			}
		}

		// Token: 0x0601158D RID: 71053 RVA: 0x0049B680 File Offset: 0x00499880
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISpiderSolitaireGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISpiderSolitaireGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601158E RID: 71054 RVA: 0x0049B6D4 File Offset: 0x004998D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
