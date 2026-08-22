namespace core.config.newer_guide_h5
{
	public class ISubstepItem
	{
		public string align { get; set; }

		public string btnfrom { get; set; }

		public string btnname { get; set; }

		public string cmd { get; set; }

		public string condition { get; set; }

		public string endEvent { get; set; }

		public string @event { get; set; }

		public string eventArgs { get; set; }

		public string eventType { get; set; }

		public string startEvent { get; set; }

		public string stat { get; set; }

		public string targetBtn { get; set; }

		public string targetBtn1 { get; set; }

		public string targetBtn2 { get; set; }

		public string targetBtn3 { get; set; }

		public string tip { get; set; }

		public string tipTitle { get; set; }

		public int[] handOffSet { get; set; }

		public int[] param { get; set; }

		public int[] rect { get; set; }

		public int[] tipPos { get; set; }

		public int autoX { get; set; }

		public int await { get; set; }

		public float handScaleX { get; set; }

		public float handScaleY { get; set; }

		public int handType { get; set; }

		public int ignoreMask { get; set; }

		public int mustWin { get; set; }

		public int outputPanel { get; set; }

		public int talkGroupId { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			align = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			autoX = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			await = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			btnfrom = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			btnname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			cmd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			condition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endEvent = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			@event = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventArgs = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				handOffSet = new int[num];
				for (int i = 0; i < num; i++)
				{
					handOffSet[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			handScaleX = ByteUtil.ReadFloat(bytes, ref byteIndex);
			handScaleY = ByteUtil.ReadFloat(bytes, ref byteIndex);
			handType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ignoreMask = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mustWin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			outputPanel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				param = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					param[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rect = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					rect[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			startEvent = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			talkGroupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			targetBtn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			targetBtn1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			targetBtn2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			targetBtn3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				tipPos = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					tipPos[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			tipTitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
