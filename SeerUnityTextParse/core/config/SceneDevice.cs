using System;

namespace core.config
{
	// Token: 0x02001E07 RID: 7687
	public class SceneDevice : XlsConfigBase<SceneDevice, ISceneDeviceInfo>
	{
		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600E316 RID: 58134 RVA: 0x003DCA3B File Offset: 0x003DAC3B
		public override string fileName
		{
			get
			{
				return "scene_device";
			}
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x003DCA44 File Offset: 0x003DAC44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISceneDeviceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISceneDeviceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x003DCA98 File Offset: 0x003DAC98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
