using System;

namespace core.config
{
	// Token: 0x02001E3D RID: 7741
	public class Startrekbuffinfo : XlsConfigBase<Startrekbuffinfo, IStartrekbuffinfoInfo>
	{
		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x0600E570 RID: 58736 RVA: 0x003DFA69 File Offset: 0x003DDC69
		public override string fileName
		{
			get
			{
				return "Startrekbuffinfo";
			}
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x003DFA70 File Offset: 0x003DDC70
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStartrekbuffinfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStartrekbuffinfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x003DFAC4 File Offset: 0x003DDCC4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
