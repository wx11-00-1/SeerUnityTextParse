using System;
using common;
using core.config;

namespace core.model
{
	// Token: 0x0200196C RID: 6508
	internal class PictureBookInfo
	{
		// Token: 0x0600CC66 RID: 52326 RVA: 0x003B58C6 File Offset: 0x003B3AC6
		public PictureBookInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.id = (int)data.ReadUnsignedInt();
				this.encont = (int)data.ReadUnsignedInt();
				this.isCacth = (data.ReadUnsignedInt() > 0U);
				data.ReadUnsignedInt();
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x003B5908 File Offset: 0x003B3B08
		public string type
		{
			get
			{
				return ResetableSingleTon<PetXMLInfo>.Ins.getType(this.id).ToString();
			}
		}

		// Token: 0x0400E2B6 RID: 58038
		public int id;

		// Token: 0x0400E2B7 RID: 58039
		public int encont;

		// Token: 0x0400E2B8 RID: 58040
		public bool isCacth;

		// Token: 0x0400E2B9 RID: 58041
		public bool hasPic = true;
	}
}
