namespace core.config
{
	public class SceneDevice : XlsConfigBase<SceneDevice, ISceneDeviceInfo>
	{
		public override string fileName
		{
			get
			{
				return "scene_device";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISceneDeviceInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISceneDeviceInfo();
					data[i].Parse(bytes, ref byteIndex);
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
