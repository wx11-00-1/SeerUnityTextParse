using System;

namespace core.config
{
	// Token: 0x0200234C RID: 9036
	public class SceneWildboss : XlsConfigBase<SceneWildboss, ISceneWildbossInfo>
	{
		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x060113E2 RID: 70626 RVA: 0x00499566 File Offset: 0x00497766
		public override string fileName
		{
			get
			{
				return "scene_wildboss";
			}
		}

		// Token: 0x060113E3 RID: 70627 RVA: 0x00499570 File Offset: 0x00497770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISceneWildbossInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISceneWildbossInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060113E4 RID: 70628 RVA: 0x004995C4 File Offset: 0x004977C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
