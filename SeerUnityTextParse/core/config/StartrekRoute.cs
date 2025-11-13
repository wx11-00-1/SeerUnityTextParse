using System;

namespace core.config
{
	// Token: 0x02001E41 RID: 7745
	public class StartrekRoute : XlsConfigBase<StartrekRoute, IStartrekRouteInfo>
	{
		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600E5A8 RID: 58792 RVA: 0x003DFEC4 File Offset: 0x003DE0C4
		public override string fileName
		{
			get
			{
				return "startrek_route";
			}
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x003DFECC File Offset: 0x003DE0CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStartrekRouteInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStartrekRouteInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x003DFF20 File Offset: 0x003DE120
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
