using System;

namespace core.config
{
	// Token: 0x02001CF3 RID: 7411
	public class ChessGameBuff : XlsConfigBase<ChessGameBuff, IChessGameBuffInfo>
	{
		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600D79A RID: 55194 RVA: 0x003CE5C2 File Offset: 0x003CC7C2
		public override string fileName
		{
			get
			{
				return "chessGame_buff";
			}
		}

		// Token: 0x0600D79B RID: 55195 RVA: 0x003CE5CC File Offset: 0x003CC7CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameBuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameBuffInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x003CE620 File Offset: 0x003CC820
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
