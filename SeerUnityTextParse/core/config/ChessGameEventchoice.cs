using System;

namespace core.config
{
	// Token: 0x02001CFB RID: 7419
	public class ChessGameEventchoice : XlsConfigBase<ChessGameEventchoice, IChessGameEventchoiceInfo>
	{
		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600D832 RID: 55346 RVA: 0x003CF05D File Offset: 0x003CD25D
		public override string fileName
		{
			get
			{
				return "chessGame_eventchoice";
			}
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x003CF064 File Offset: 0x003CD264
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameEventchoiceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameEventchoiceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x003CF0B8 File Offset: 0x003CD2B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
