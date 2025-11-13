using System;

namespace core.config
{
	// Token: 0x02001D01 RID: 7425
	public class ChessGameSkill : XlsConfigBase<ChessGameSkill, IChessGameSkillInfo>
	{
		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600D874 RID: 55412 RVA: 0x003CF559 File Offset: 0x003CD759
		public override string fileName
		{
			get
			{
				return "chessGame_skill";
			}
		}

		// Token: 0x0600D875 RID: 55413 RVA: 0x003CF560 File Offset: 0x003CD760
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChessGameSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChessGameSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x003CF5B4 File Offset: 0x003CD7B4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
