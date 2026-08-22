namespace core.config.advancedPetPanelConfig
{
	public class ITaskItem
	{
		public ICompone Compone { get; set; }

		public string Jump { get; set; }

		public string JumpH5 { get; set; }

		public IMainPanel MainPanel { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Compone = new ICompone();
				Compone.Parse(bytes, ref byteIndex);
			}
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			JumpH5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				MainPanel = new IMainPanel();
				MainPanel.Parse(bytes, ref byteIndex);
			}
		}
	}
}
