using System;

namespace core.config
{
	// Token: 0x02001CFD RID: 7421
	public class ChessGameEventtype : XlsConfigBase<ChessGameEventtype, IChessGameEventtypeInfo>
	{
		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600D842 RID: 55362 RVA: 0x003CF1A2 File Offset: 0x003CD3A2
		public override string fileName
		{
			get
			{
				return "chessGame_eventtype";
			}
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x003CF1AC File Offset: 0x003CD3AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameEventtypeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameEventtypeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x003CF200 File Offset: 0x003CD400
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
