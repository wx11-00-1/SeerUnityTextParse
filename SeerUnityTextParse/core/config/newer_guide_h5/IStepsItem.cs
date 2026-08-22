namespace core.config.newer_guide_h5
{
	public class IStepsItem
	{
		public string dependStepParam { get; set; }

		public string param { get; set; }

		public ISubstepItem[] substep { get; set; }

		public int conditionid { get; set; }

		public int dependStep { get; set; }

		public int step { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			conditionid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dependStep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dependStepParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				substep = new ISubstepItem[num];
				for (int i = 0; i < num; i++)
				{
					substep[i] = new ISubstepItem();
					substep[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
