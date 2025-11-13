using System;

namespace core.config
{
	// Token: 0x02001CFF RID: 7423
	public class ChessGameMonster : XlsConfigBase<ChessGameMonster, IChessGameMonsterInfo>
	{
		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x0600D854 RID: 55380 RVA: 0x003CF300 File Offset: 0x003CD500
		public override string fileName
		{
			get
			{
				return "chessGame_monster";
			}
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x003CF308 File Offset: 0x003CD508
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D856 RID: 55382 RVA: 0x003CF35C File Offset: 0x003CD55C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
