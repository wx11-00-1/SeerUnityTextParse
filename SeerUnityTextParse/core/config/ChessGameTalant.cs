using System;

namespace core.config
{
	// Token: 0x02001D05 RID: 7429
	public class ChessGameTalant : XlsConfigBase<ChessGameTalant, IChessGameTalantInfo>
	{
		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x0600D8B4 RID: 55476 RVA: 0x003CF9EB File Offset: 0x003CDBEB
		public override string fileName
		{
			get
			{
				return "chessGame_talant";
			}
		}

		// Token: 0x0600D8B5 RID: 55477 RVA: 0x003CF9F4 File Offset: 0x003CDBF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameTalantInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameTalantInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D8B6 RID: 55478 RVA: 0x003CFA48 File Offset: 0x003CDC48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
