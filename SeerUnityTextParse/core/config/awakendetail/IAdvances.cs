using System;

namespace core.config.awakendetail
{
	// Token: 0x02002068 RID: 8296
	public class IAdvances
	{
		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600FD5B RID: 64859 RVA: 0x00403030 File Offset: 0x00401230
		// (set) Token: 0x0600FD5C RID: 64860 RVA: 0x00403038 File Offset: 0x00401238
		public IAdvEffect AdvEffect { get; set; }

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x0600FD5D RID: 64861 RVA: 0x00403041 File Offset: 0x00401241
		// (set) Token: 0x0600FD5E RID: 64862 RVA: 0x00403049 File Offset: 0x00401249
		public IExMove exMove { get; set; }

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600FD5F RID: 64863 RVA: 0x00403052 File Offset: 0x00401252
		// (set) Token: 0x0600FD60 RID: 64864 RVA: 0x0040305A File Offset: 0x0040125A
		public IRace Race { get; set; }

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600FD61 RID: 64865 RVA: 0x00403063 File Offset: 0x00401263
		// (set) Token: 0x0600FD62 RID: 64866 RVA: 0x0040306B File Offset: 0x0040126B
		public ISpMove spMove { get; set; }

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600FD63 RID: 64867 RVA: 0x00403074 File Offset: 0x00401274
		// (set) Token: 0x0600FD64 RID: 64868 RVA: 0x0040307C File Offset: 0x0040127C
		public int AdvType { get; set; }

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600FD65 RID: 64869 RVA: 0x00403085 File Offset: 0x00401285
		// (set) Token: 0x0600FD66 RID: 64870 RVA: 0x0040308D File Offset: 0x0040128D
		public int MonsterId { get; set; }

		// Token: 0x0600FD67 RID: 64871 RVA: 0x00403098 File Offset: 0x00401298
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AdvEffect = new IAdvEffect();
				this.AdvEffect.Parse(bytes, ref byteIndex);
			}
			this.AdvType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Race = new IRace();
				this.Race.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.exMove = new IExMove();
				this.exMove.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.spMove = new ISpMove();
				this.spMove.Parse(bytes, ref byteIndex);
			}
		}
	}
}
