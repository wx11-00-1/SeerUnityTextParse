using System;

namespace core.config
{
	// Token: 0x0200271D RID: 10013
	public class IMysteryBoxGameLevelInfo : IConfigItem
	{
		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06013C03 RID: 80899 RVA: 0x0055C9F0 File Offset: 0x0055ABF0
		// (set) Token: 0x06013C04 RID: 80900 RVA: 0x0055C9F8 File Offset: 0x0055ABF8
		public string des { get; set; }

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06013C05 RID: 80901 RVA: 0x0055CA01 File Offset: 0x0055AC01
		// (set) Token: 0x06013C06 RID: 80902 RVA: 0x0055CA09 File Offset: 0x0055AC09
		public string name { get; set; }

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06013C07 RID: 80903 RVA: 0x0055CA12 File Offset: 0x0055AC12
		// (set) Token: 0x06013C08 RID: 80904 RVA: 0x0055CA1A File Offset: 0x0055AC1A
		public int[] rare { get; set; }

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06013C09 RID: 80905 RVA: 0x0055CA23 File Offset: 0x0055AC23
		// (set) Token: 0x06013C0A RID: 80906 RVA: 0x0055CA2B File Offset: 0x0055AC2B
		public int Amax { get; set; }

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06013C0B RID: 80907 RVA: 0x0055CA34 File Offset: 0x0055AC34
		// (set) Token: 0x06013C0C RID: 80908 RVA: 0x0055CA3C File Offset: 0x0055AC3C
		public int Amin { get; set; }

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06013C0D RID: 80909 RVA: 0x0055CA45 File Offset: 0x0055AC45
		// (set) Token: 0x06013C0E RID: 80910 RVA: 0x0055CA4D File Offset: 0x0055AC4D
		public int Bmax { get; set; }

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06013C0F RID: 80911 RVA: 0x0055CA56 File Offset: 0x0055AC56
		// (set) Token: 0x06013C10 RID: 80912 RVA: 0x0055CA5E File Offset: 0x0055AC5E
		public int Bmin { get; set; }

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06013C11 RID: 80913 RVA: 0x0055CA67 File Offset: 0x0055AC67
		// (set) Token: 0x06013C12 RID: 80914 RVA: 0x0055CA6F File Offset: 0x0055AC6F
		public int Cmax { get; set; }

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06013C13 RID: 80915 RVA: 0x0055CA78 File Offset: 0x0055AC78
		// (set) Token: 0x06013C14 RID: 80916 RVA: 0x0055CA80 File Offset: 0x0055AC80
		public int Cmin { get; set; }

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06013C15 RID: 80917 RVA: 0x0055CA89 File Offset: 0x0055AC89
		// (set) Token: 0x06013C16 RID: 80918 RVA: 0x0055CA91 File Offset: 0x0055AC91
		public int Emax { get; set; }

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06013C17 RID: 80919 RVA: 0x0055CA9A File Offset: 0x0055AC9A
		// (set) Token: 0x06013C18 RID: 80920 RVA: 0x0055CAA2 File Offset: 0x0055ACA2
		public int Emin { get; set; }

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06013C19 RID: 80921 RVA: 0x0055CAAB File Offset: 0x0055ACAB
		// (set) Token: 0x06013C1A RID: 80922 RVA: 0x0055CAB3 File Offset: 0x0055ACB3
		public int id { get; set; }

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06013C1B RID: 80923 RVA: 0x0055CABC File Offset: 0x0055ACBC
		// (set) Token: 0x06013C1C RID: 80924 RVA: 0x0055CAC4 File Offset: 0x0055ACC4
		public int value { get; set; }

		// Token: 0x06013C1D RID: 80925 RVA: 0x0055CAD0 File Offset: 0x0055ACD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Amax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Amin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bmin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Cmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Cmin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Emax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Emin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rare = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rare[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
