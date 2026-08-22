namespace core.config
{
	public class SceneNpc : XlsConfigBase<SceneNpc, ISceneNpcInfo>
	{
		public override string fileName
		{
			get
			{
				return "scene_npc";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISceneNpcInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISceneNpcInfo();
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
