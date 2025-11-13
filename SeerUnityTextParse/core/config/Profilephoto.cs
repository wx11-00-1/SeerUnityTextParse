using System;

namespace core.config
{
	// Token: 0x02001DCF RID: 7631
	public class Profilephoto : XlsConfigBase<Profilephoto, IProfilephotoInfo>
	{
		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x0600E0B4 RID: 57524 RVA: 0x003D9941 File Offset: 0x003D7B41
		public override string fileName
		{
			get
			{
				return "profilephoto";
			}
		}

		// Token: 0x0600E0B5 RID: 57525 RVA: 0x003D9948 File Offset: 0x003D7B48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IProfilephotoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IProfilephotoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x003D999C File Offset: 0x003D7B9C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
