using System;

namespace core.config.Attireconversion
{
	// Token: 0x02002072 RID: 8306
	public class IAttireconversionItem
	{
		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600FD9F RID: 64927 RVA: 0x00403540 File Offset: 0x00401740
		// (set) Token: 0x0600FDA0 RID: 64928 RVA: 0x00403548 File Offset: 0x00401748
		public int ExchangeNum { get; set; }

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600FDA1 RID: 64929 RVA: 0x00403551 File Offset: 0x00401751
		// (set) Token: 0x0600FDA2 RID: 64930 RVA: 0x00403559 File Offset: 0x00401759
		public int ID { get; set; }

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600FDA3 RID: 64931 RVA: 0x00403562 File Offset: 0x00401762
		// (set) Token: 0x0600FDA4 RID: 64932 RVA: 0x0040356A File Offset: 0x0040176A
		public int Platform { get; set; }

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600FDA5 RID: 64933 RVA: 0x00403573 File Offset: 0x00401773
		// (set) Token: 0x0600FDA6 RID: 64934 RVA: 0x0040357B File Offset: 0x0040177B
		public int RewardID { get; set; }

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x0600FDA7 RID: 64935 RVA: 0x00403584 File Offset: 0x00401784
		// (set) Token: 0x0600FDA8 RID: 64936 RVA: 0x0040358C File Offset: 0x0040178C
		public int RewardNum { get; set; }

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600FDA9 RID: 64937 RVA: 0x00403595 File Offset: 0x00401795
		// (set) Token: 0x0600FDAA RID: 64938 RVA: 0x0040359D File Offset: 0x0040179D
		public int SubNum { get; set; }

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600FDAB RID: 64939 RVA: 0x004035A6 File Offset: 0x004017A6
		// (set) Token: 0x0600FDAC RID: 64940 RVA: 0x004035AE File Offset: 0x004017AE
		public int UserInfo { get; set; }

		// Token: 0x0600FDAD RID: 64941 RVA: 0x004035B8 File Offset: 0x004017B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExchangeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Platform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SubNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
