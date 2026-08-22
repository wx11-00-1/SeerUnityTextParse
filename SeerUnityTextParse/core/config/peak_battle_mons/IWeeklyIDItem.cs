namespace core.config.peak_battle_mons
{
	public class IWeeklyIDItem
	{
		public string NewSeIcon { get; set; }

		public int HomeAdditionMon { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			HomeAdditionMon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSeIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
