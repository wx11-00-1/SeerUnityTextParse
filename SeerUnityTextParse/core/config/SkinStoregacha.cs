using System;

namespace core.config
{
	// Token: 0x020027D8 RID: 10200
	public class SkinStoregacha : XlsConfigBase<SkinStoregacha, ISkinStoregachaInfo>
	{
		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06014491 RID: 83089 RVA: 0x0056732D File Offset: 0x0056552D
		public override string fileName
		{
			get
			{
				return "skinStoregacha";
			}
		}

		// Token: 0x06014492 RID: 83090 RVA: 0x00567334 File Offset: 0x00565534
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISkinStoregachaInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISkinStoregachaInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014493 RID: 83091 RVA: 0x00567388 File Offset: 0x00565588
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
