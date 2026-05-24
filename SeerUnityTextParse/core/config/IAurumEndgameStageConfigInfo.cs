using System;

namespace core.config
{
	// Token: 0x02002431 RID: 9265
	public class IAurumEndgameStageConfigInfo : IConfigItem
	{
		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06011868 RID: 71784 RVA: 0x00500A60 File Offset: 0x004FEC60
		// (set) Token: 0x06011869 RID: 71785 RVA: 0x00500A68 File Offset: 0x004FEC68
		public string name { get; set; }

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0601186A RID: 71786 RVA: 0x00500A71 File Offset: 0x004FEC71
		// (set) Token: 0x0601186B RID: 71787 RVA: 0x00500A79 File Offset: 0x004FEC79
		public int[] elite1 { get; set; }

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0601186C RID: 71788 RVA: 0x00500A82 File Offset: 0x004FEC82
		// (set) Token: 0x0601186D RID: 71789 RVA: 0x00500A8A File Offset: 0x004FEC8A
		public int[] elite2 { get; set; }

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x0601186E RID: 71790 RVA: 0x00500A93 File Offset: 0x004FEC93
		// (set) Token: 0x0601186F RID: 71791 RVA: 0x00500A9B File Offset: 0x004FEC9B
		public int[] enemy1 { get; set; }

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06011870 RID: 71792 RVA: 0x00500AA4 File Offset: 0x004FECA4
		// (set) Token: 0x06011871 RID: 71793 RVA: 0x00500AAC File Offset: 0x004FECAC
		public int[] enemy2 { get; set; }

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06011872 RID: 71794 RVA: 0x00500AB5 File Offset: 0x004FECB5
		// (set) Token: 0x06011873 RID: 71795 RVA: 0x00500ABD File Offset: 0x004FECBD
		public int[] enemy3 { get; set; }

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06011874 RID: 71796 RVA: 0x00500AC6 File Offset: 0x004FECC6
		// (set) Token: 0x06011875 RID: 71797 RVA: 0x00500ACE File Offset: 0x004FECCE
		public int atkRatio { get; set; }

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06011876 RID: 71798 RVA: 0x00500AD7 File Offset: 0x004FECD7
		// (set) Token: 0x06011877 RID: 71799 RVA: 0x00500ADF File Offset: 0x004FECDF
		public int boss { get; set; }

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06011878 RID: 71800 RVA: 0x00500AE8 File Offset: 0x004FECE8
		// (set) Token: 0x06011879 RID: 71801 RVA: 0x00500AF0 File Offset: 0x004FECF0
		public int bossCoef { get; set; }

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x0601187A RID: 71802 RVA: 0x00500AF9 File Offset: 0x004FECF9
		// (set) Token: 0x0601187B RID: 71803 RVA: 0x00500B01 File Offset: 0x004FED01
		public int elite1Coef { get; set; }

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x0601187C RID: 71804 RVA: 0x00500B0A File Offset: 0x004FED0A
		// (set) Token: 0x0601187D RID: 71805 RVA: 0x00500B12 File Offset: 0x004FED12
		public int elite2Coef { get; set; }

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x0601187E RID: 71806 RVA: 0x00500B1B File Offset: 0x004FED1B
		// (set) Token: 0x0601187F RID: 71807 RVA: 0x00500B23 File Offset: 0x004FED23
		public int hpIncr { get; set; }

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06011880 RID: 71808 RVA: 0x00500B2C File Offset: 0x004FED2C
		// (set) Token: 0x06011881 RID: 71809 RVA: 0x00500B34 File Offset: 0x004FED34
		public int hpRatio { get; set; }

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06011882 RID: 71810 RVA: 0x00500B3D File Offset: 0x004FED3D
		// (set) Token: 0x06011883 RID: 71811 RVA: 0x00500B45 File Offset: 0x004FED45
		public int id { get; set; }

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06011884 RID: 71812 RVA: 0x00500B4E File Offset: 0x004FED4E
		// (set) Token: 0x06011885 RID: 71813 RVA: 0x00500B56 File Offset: 0x004FED56
		public int modId { get; set; }

		// Token: 0x06011886 RID: 71814 RVA: 0x00500B60 File Offset: 0x004FED60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atkRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossCoef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.elite1 = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.elite1[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.elite1Coef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.elite2 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.elite2[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.elite2Coef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.enemy1 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.enemy1[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.enemy2 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.enemy2[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.enemy3 = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.enemy3[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.hpIncr = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hpRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.modId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
