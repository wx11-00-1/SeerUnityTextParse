using System;

namespace core.config
{
	// Token: 0x02001CF7 RID: 7415
	public class ChessGameCareer : XlsConfigBase<ChessGameCareer, IChessGameCareerInfo>
	{
		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x003CEB89 File Offset: 0x003CCD89
		public override string fileName
		{
			get
			{
				return "chessGame_career";
			}
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x003CEB90 File Offset: 0x003CCD90
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameCareerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameCareerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x003CEBE4 File Offset: 0x003CCDE4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
