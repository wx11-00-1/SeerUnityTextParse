using System;

namespace core.config
{
	// Token: 0x02001CF9 RID: 7417
	public class ChessGameEquip : XlsConfigBase<ChessGameEquip, IChessGameEquipInfo>
	{
		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600D804 RID: 55300 RVA: 0x003CED3A File Offset: 0x003CCF3A
		public override string fileName
		{
			get
			{
				return "chessGame_equip";
			}
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x003CED44 File Offset: 0x003CCF44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameEquipInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameEquipInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x003CED98 File Offset: 0x003CCF98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
