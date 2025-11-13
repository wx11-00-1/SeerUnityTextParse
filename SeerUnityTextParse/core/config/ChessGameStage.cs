using System;

namespace core.config
{
	// Token: 0x02001D03 RID: 7427
	public class ChessGameStage : XlsConfigBase<ChessGameStage, IChessGameStageInfo>
	{
		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600D898 RID: 55448 RVA: 0x003CF7EB File Offset: 0x003CD9EB
		public override string fileName
		{
			get
			{
				return "chessGame_stage";
			}
		}

		// Token: 0x0600D899 RID: 55449 RVA: 0x003CF7F4 File Offset: 0x003CD9F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x003CF848 File Offset: 0x003CDA48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
