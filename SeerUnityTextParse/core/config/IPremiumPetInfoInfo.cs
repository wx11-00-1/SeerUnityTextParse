using System;

namespace core.config
{
	// Token: 0x020022F7 RID: 8951
	public class IPremiumPetInfoInfo : IConfigItem
	{
		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06011034 RID: 69684 RVA: 0x00494BB8 File Offset: 0x00492DB8
		// (set) Token: 0x06011035 RID: 69685 RVA: 0x00494BC0 File Offset: 0x00492DC0
		public string CouponsInfo { get; set; }

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06011036 RID: 69686 RVA: 0x00494BC9 File Offset: 0x00492DC9
		// (set) Token: 0x06011037 RID: 69687 RVA: 0x00494BD1 File Offset: 0x00492DD1
		public int id { get; set; }

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06011038 RID: 69688 RVA: 0x00494BDA File Offset: 0x00492DDA
		// (set) Token: 0x06011039 RID: 69689 RVA: 0x00494BE2 File Offset: 0x00492DE2
		public int UpDvConsumeNum { get; set; }

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x0601103A RID: 69690 RVA: 0x00494BEB File Offset: 0x00492DEB
		// (set) Token: 0x0601103B RID: 69691 RVA: 0x00494BF3 File Offset: 0x00492DF3
		public int UpEvsConsumeNum { get; set; }

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x0601103C RID: 69692 RVA: 0x00494BFC File Offset: 0x00492DFC
		// (set) Token: 0x0601103D RID: 69693 RVA: 0x00494C04 File Offset: 0x00492E04
		public int UpLevelConsumeNum { get; set; }

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x0601103E RID: 69694 RVA: 0x00494C0D File Offset: 0x00492E0D
		// (set) Token: 0x0601103F RID: 69695 RVA: 0x00494C15 File Offset: 0x00492E15
		public int UpMaxhpadjConsumeNum { get; set; }

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06011040 RID: 69696 RVA: 0x00494C1E File Offset: 0x00492E1E
		// (set) Token: 0x06011041 RID: 69697 RVA: 0x00494C26 File Offset: 0x00492E26
		public int UpNatureConsumeNum { get; set; }

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06011042 RID: 69698 RVA: 0x00494C2F File Offset: 0x00492E2F
		// (set) Token: 0x06011043 RID: 69699 RVA: 0x00494C37 File Offset: 0x00492E37
		public int UpNewseConsumeNum { get; set; }

		// Token: 0x06011044 RID: 69700 RVA: 0x00494C40 File Offset: 0x00492E40
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.CouponsInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UpDvConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UpEvsConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UpLevelConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UpMaxhpadjConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UpNatureConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UpNewseConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
