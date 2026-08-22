namespace core.config.equip
{
	public class IEquips
	{
		public IEquipItem[] Equip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Equip = new IEquipItem[num];
				for (int i = 0; i < num; i++)
				{
					Equip[i] = new IEquipItem();
					Equip[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
