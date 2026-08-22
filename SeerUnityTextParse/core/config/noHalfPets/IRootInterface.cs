namespace core.config.noHalfPets
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		private bool b;

		public override string fileName
		{
			get
			{
				return "noHalfPets";
			}
		}

		public int[] pets { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				pets = new int[num];
				for (int i = 0; i < num; i++)
				{
					pets[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
