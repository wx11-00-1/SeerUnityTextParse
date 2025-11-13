using System;

namespace core.config
{
	// Token: 0x02001CAB RID: 7339
	public class Awakenbosslevel : XlsConfigBase<Awakenbosslevel, IAwakenbosslevelInfo>
	{
		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600D4AE RID: 54446 RVA: 0x003CAD22 File Offset: 0x003C8F22
		public override string fileName
		{
			get
			{
				return "awakenbosslevel";
			}
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x003CAD2C File Offset: 0x003C8F2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenbosslevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenbosslevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x003CAD80 File Offset: 0x003C8F80
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
