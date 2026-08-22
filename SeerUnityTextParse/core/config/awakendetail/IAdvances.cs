namespace core.config.awakendetail
{
	public class IAdvances
	{
		public IAdvEffect AdvEffect { get; set; }

		public IExMove exMove { get; set; }

		public IRace Race { get; set; }

		public ISpMove spMove { get; set; }

		public int AdvType { get; set; }

		public int MonsterId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				AdvEffect = new IAdvEffect();
				AdvEffect.Parse(bytes, ref byteIndex);
			}
			AdvType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Race = new IRace();
				Race.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				exMove = new IExMove();
				exMove.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				spMove = new ISpMove();
				spMove.Parse(bytes, ref byteIndex);
			}
		}
	}
}
