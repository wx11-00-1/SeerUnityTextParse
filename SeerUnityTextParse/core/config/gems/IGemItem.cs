namespace core.config.gems
{
	public class IGemItem
	{
		public string Des { get; set; }

		public string Name { get; set; }

		public ISkillEffectsItem[] SkillEffects { get; set; }

		public int Category { get; set; }

		public int DecomposeProb { get; set; }

		public int EquitLv1Cnt1 { get; set; }

		public int ID { get; set; }

		public int Lv { get; set; }

		public int UpgradeGemId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Category = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			DecomposeProb = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			EquitLv1Cnt1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				SkillEffects = new ISkillEffectsItem[num];
				for (int i = 0; i < num; i++)
				{
					SkillEffects[i] = new ISkillEffectsItem();
					SkillEffects[i].Parse(bytes, ref byteIndex);
				}
			}
			UpgradeGemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
