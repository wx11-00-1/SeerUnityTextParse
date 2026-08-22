namespace core.config.effectInfo
{
	public class IRoot
	{
		public IEffectItem[] Effect { get; set; }

		public IParamTypeItem[] ParamType { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Effect = new IEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					Effect[i] = new IEffectItem();
					Effect[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				ParamType = new IParamTypeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					ParamType[j] = new IParamTypeItem();
					ParamType[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
