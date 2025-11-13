using System;

namespace core.config
{
	// Token: 0x02001E45 RID: 7749
	public class Storymodel : XlsConfigBase<Storymodel, IStorymodelInfo>
	{
		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x003E01CA File Offset: 0x003DE3CA
		public override string fileName
		{
			get
			{
				return "storymodel";
			}
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x003E01D4 File Offset: 0x003DE3D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStorymodelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStorymodelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x003E0228 File Offset: 0x003DE428
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
