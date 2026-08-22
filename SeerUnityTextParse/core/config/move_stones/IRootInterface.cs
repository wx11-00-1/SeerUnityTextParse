namespace core.config.move_stones
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		public override string fileName
		{
			get
			{
				return "move_stones";
			}
		}

		public IMoveStones MoveStones { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				MoveStones = new IMoveStones();
				MoveStones.Parse(bytes, ref byteIndex);
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
