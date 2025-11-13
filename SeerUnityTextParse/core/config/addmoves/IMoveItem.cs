using System;

namespace core.config.addmoves
{
	// Token: 0x0200207E RID: 8318
	public class IMoveItem
	{
		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600FDF1 RID: 65009 RVA: 0x00403AF8 File Offset: 0x00401CF8
		// (set) Token: 0x0600FDF2 RID: 65010 RVA: 0x00403B00 File Offset: 0x00401D00
		public string[] anm { get; set; }

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600FDF3 RID: 65011 RVA: 0x00403B09 File Offset: 0x00401D09
		// (set) Token: 0x0600FDF4 RID: 65012 RVA: 0x00403B11 File Offset: 0x00401D11
		public string[] reportname { get; set; }

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600FDF5 RID: 65013 RVA: 0x00403B1A File Offset: 0x00401D1A
		// (set) Token: 0x0600FDF6 RID: 65014 RVA: 0x00403B22 File Offset: 0x00401D22
		public string[] reportskill { get; set; }

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600FDF7 RID: 65015 RVA: 0x00403B2B File Offset: 0x00401D2B
		// (set) Token: 0x0600FDF8 RID: 65016 RVA: 0x00403B33 File Offset: 0x00401D33
		public string[] reporttxt { get; set; }

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600FDF9 RID: 65017 RVA: 0x00403B3C File Offset: 0x00401D3C
		// (set) Token: 0x0600FDFA RID: 65018 RVA: 0x00403B44 File Offset: 0x00401D44
		public int[] skin { get; set; }

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600FDFB RID: 65019 RVA: 0x00403B4D File Offset: 0x00401D4D
		// (set) Token: 0x0600FDFC RID: 65020 RVA: 0x00403B55 File Offset: 0x00401D55
		public int cover { get; set; }

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600FDFD RID: 65021 RVA: 0x00403B5E File Offset: 0x00401D5E
		// (set) Token: 0x0600FDFE RID: 65022 RVA: 0x00403B66 File Offset: 0x00401D66
		public int damage { get; set; }

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x00403B6F File Offset: 0x00401D6F
		// (set) Token: 0x0600FE00 RID: 65024 RVA: 0x00403B77 File Offset: 0x00401D77
		public int ID { get; set; }

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600FE01 RID: 65025 RVA: 0x00403B80 File Offset: 0x00401D80
		// (set) Token: 0x0600FE02 RID: 65026 RVA: 0x00403B88 File Offset: 0x00401D88
		public int monster { get; set; }

		// Token: 0x0600FE03 RID: 65027 RVA: 0x00403B94 File Offset: 0x00401D94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.anm = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.anm[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.cover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.damage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reportname = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.reportname[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reportskill = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					this.reportskill[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reporttxt = new string[num4];
				for (int l = 0; l < num4; l++)
				{
					this.reporttxt[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.skin = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.skin[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
