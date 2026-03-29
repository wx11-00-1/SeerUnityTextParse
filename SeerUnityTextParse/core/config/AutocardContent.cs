using System;

namespace core.config
{
	// Token: 0x0200212E RID: 8494
	public class AutocardContent : XlsConfigBase<AutocardContent, IAutocardContentInfo>
	{
		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x0600FC32 RID: 64562 RVA: 0x0047C98A File Offset: 0x0047AB8A
		public override string fileName
		{
			get
			{
				return "autocardContent";
			}
		}

		// Token: 0x0600FC33 RID: 64563 RVA: 0x0047C994 File Offset: 0x0047AB94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardContentInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardContentInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC34 RID: 64564 RVA: 0x0047C9E8 File Offset: 0x0047ABE8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
