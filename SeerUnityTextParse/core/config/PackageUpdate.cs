using System;

namespace core.config
{
	// Token: 0x020022DC RID: 8924
	public class PackageUpdate : XlsConfigBase<PackageUpdate, IPackageUpdateInfo>
	{
		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06010F2C RID: 69420 RVA: 0x00493827 File Offset: 0x00491A27
		public override string fileName
		{
			get
			{
				return "package_update";
			}
		}

		// Token: 0x06010F2D RID: 69421 RVA: 0x00493830 File Offset: 0x00491A30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPackageUpdateInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPackageUpdateInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010F2E RID: 69422 RVA: 0x00493884 File Offset: 0x00491A84
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
