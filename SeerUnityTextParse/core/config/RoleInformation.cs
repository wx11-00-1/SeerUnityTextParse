using System;

namespace core.config
{
	// Token: 0x02001E03 RID: 7683
	public class RoleInformation : XlsConfigBase<RoleInformation, IRoleInformationInfo>
	{
		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600E2E8 RID: 58088 RVA: 0x003DC66B File Offset: 0x003DA86B
		public override string fileName
		{
			get
			{
				return "roleInformation";
			}
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x003DC674 File Offset: 0x003DA874
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRoleInformationInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRoleInformationInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x003DC6C8 File Offset: 0x003DA8C8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
