using System;

namespace core.config
{
	// Token: 0x02001CF5 RID: 7413
	public class ChessGameCard : XlsConfigBase<ChessGameCard, IChessGameCardInfo>
	{
		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600D7B8 RID: 55224 RVA: 0x003CE7EE File Offset: 0x003CC9EE
		public override string fileName
		{
			get
			{
				return "chessGame_card";
			}
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x003CE7F8 File Offset: 0x003CC9F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameCardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameCardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D7BA RID: 55226 RVA: 0x003CE84C File Offset: 0x003CCA4C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
