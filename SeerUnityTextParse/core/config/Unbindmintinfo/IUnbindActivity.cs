namespace core.config.Unbindmintinfo
{
	public class IUnbindActivity
	{
		public IUnbindmintinfoItem[] Unbindmintinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Unbindmintinfo = new IUnbindmintinfoItem[num];
				for (int i = 0; i < num; i++)
				{
					Unbindmintinfo[i] = new IUnbindmintinfoItem();
					Unbindmintinfo[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
