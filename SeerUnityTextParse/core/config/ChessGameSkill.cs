namespace core.config
{
	public class ChessGameSkill : XlsConfigBase<ChessGameSkill, IChessGameSkillInfo>
	{
		public override string fileName
		{
			get
			{
				return "chessGame_skill";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IChessGameSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IChessGameSkillInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
