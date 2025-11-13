using System;

namespace core.config.activityTimeControl
{
	// Token: 0x02002082 RID: 8322
	public class IItemItem : IConfigItem
	{
		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600FE13 RID: 65043 RVA: 0x00403E62 File Offset: 0x00402062
		// (set) Token: 0x0600FE14 RID: 65044 RVA: 0x00403E6A File Offset: 0x0040206A
		public string endTime { get; set; }

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600FE15 RID: 65045 RVA: 0x00403E73 File Offset: 0x00402073
		// (set) Token: 0x0600FE16 RID: 65046 RVA: 0x00403E7B File Offset: 0x0040207B
		public string startTime { get; set; }

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600FE17 RID: 65047 RVA: 0x00403E84 File Offset: 0x00402084
		// (set) Token: 0x0600FE18 RID: 65048 RVA: 0x00403E8C File Offset: 0x0040208C
		public int id { get; set; }

		// Token: 0x0600FE19 RID: 65049 RVA: 0x00403E95 File Offset: 0x00402095
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
