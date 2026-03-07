using System;

namespace core.config
{
	// Token: 0x02001F36 RID: 7990
	public class CardDuelGame : XlsConfigBase<CardDuelGame, ICardDuelGameInfo>
	{
		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600ECF8 RID: 60664 RVA: 0x0042F04A File Offset: 0x0042D24A
		public override string fileName
		{
			get
			{
				return "cardDuelGame";
			}
		}

		// Token: 0x0600ECF9 RID: 60665 RVA: 0x0042F054 File Offset: 0x0042D254
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICardDuelGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICardDuelGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600ECFA RID: 60666 RVA: 0x0042F0A8 File Offset: 0x0042D2A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
