namespace core.config
{
	public class ISeerShipChooseGameInfo : IConfigItem
	{
		public string @event { get; set; }

		public string eventA { get; set; }

		public string eventAAnswer { get; set; }

		public string eventB { get; set; }

		public string eventBAnswer { get; set; }

		public string eventC { get; set; }

		public string eventCAnswer { get; set; }

		public string eventDes { get; set; }

		public string eventHelp { get; set; }

		public string score1 { get; set; }

		public string score2 { get; set; }

		public string score3 { get; set; }

		public int id { get; set; }

		public int specialAnswer { get; set; }

		public int trueAnswer { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			@event = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventA = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventAAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventB = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventBAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventC = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventCAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventHelp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			score1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			score2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			score3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			specialAnswer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			trueAnswer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
