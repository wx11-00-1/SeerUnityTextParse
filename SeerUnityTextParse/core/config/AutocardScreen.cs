using System;

namespace core.config
{
	// Token: 0x0200213E RID: 8510
	public class AutocardScreen : XlsConfigBase<AutocardScreen, IAutocardScreenInfo>
	{
		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600FCF2 RID: 64754 RVA: 0x0047D75B File Offset: 0x0047B95B
		public override string fileName
		{
			get
			{
				return "autocardScreen";
			}
		}

		// Token: 0x0600FCF3 RID: 64755 RVA: 0x0047D764 File Offset: 0x0047B964
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardScreenInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardScreenInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FCF4 RID: 64756 RVA: 0x0047D7B8 File Offset: 0x0047B9B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
