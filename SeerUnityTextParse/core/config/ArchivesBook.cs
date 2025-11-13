using System;

namespace core.config
{
	// Token: 0x02001CA1 RID: 7329
	public class ArchivesBook : XlsConfigBase<ArchivesBook, IArchivesBookInfo>
	{
		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x0600D452 RID: 54354 RVA: 0x003CA5C6 File Offset: 0x003C87C6
		public override string fileName
		{
			get
			{
				return "archivesBook";
			}
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x003CA5D0 File Offset: 0x003C87D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArchivesBookInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArchivesBookInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x003CA624 File Offset: 0x003C8824
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
