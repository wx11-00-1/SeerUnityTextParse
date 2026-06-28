using System;

namespace core.config
{
	// Token: 0x0200257A RID: 9594
	public class Autocardhelptips : XlsConfigBase<Autocardhelptips, IAutocardhelptipsInfo>
	{
		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06012993 RID: 76179 RVA: 0x00546796 File Offset: 0x00544996
		public override string fileName
		{
			get
			{
				return "autocardhelptips";
			}
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x005467A0 File Offset: 0x005449A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardhelptipsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardhelptipsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x005467F4 File Offset: 0x005449F4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
