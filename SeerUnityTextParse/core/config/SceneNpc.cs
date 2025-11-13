using System;

namespace core.config
{
	// Token: 0x02001E09 RID: 7689
	public class SceneNpc : XlsConfigBase<SceneNpc, ISceneNpcInfo>
	{
		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600E326 RID: 58150 RVA: 0x003DCBA6 File Offset: 0x003DADA6
		public override string fileName
		{
			get
			{
				return "scene_npc";
			}
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x003DCBB0 File Offset: 0x003DADB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISceneNpcInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISceneNpcInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x003DCC04 File Offset: 0x003DAE04
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
