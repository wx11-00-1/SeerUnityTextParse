using System;

namespace core.config
{
	// Token: 0x02001D0B RID: 7435
	public class ConstFields : XlsConfigBase<ConstFields, IConstFieldsInfo>
	{
		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x0600D8F6 RID: 55542 RVA: 0x003CFF17 File Offset: 0x003CE117
		public override string fileName
		{
			get
			{
				return "const_fields";
			}
		}

		// Token: 0x0600D8F7 RID: 55543 RVA: 0x003CFF20 File Offset: 0x003CE120
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IConstFieldsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IConstFieldsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D8F8 RID: 55544 RVA: 0x003CFF74 File Offset: 0x003CE174
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
