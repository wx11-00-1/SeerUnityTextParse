using System;

namespace core.config
{
	// Token: 0x02001F01 RID: 7937
	public class IBagTowerStageFightInfo : IConfigItem
	{
		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x0600EAFE RID: 60158 RVA: 0x0042C8F0 File Offset: 0x0042AAF0
		// (set) Token: 0x0600EAFF RID: 60159 RVA: 0x0042C8F8 File Offset: 0x0042AAF8
		public int[] monster { get; set; }

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600EB00 RID: 60160 RVA: 0x0042C901 File Offset: 0x0042AB01
		// (set) Token: 0x0600EB01 RID: 60161 RVA: 0x0042C909 File Offset: 0x0042AB09
		public int[] position { get; set; }

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600EB02 RID: 60162 RVA: 0x0042C912 File Offset: 0x0042AB12
		// (set) Token: 0x0600EB03 RID: 60163 RVA: 0x0042C91A File Offset: 0x0042AB1A
		public int atkmonsterup { get; set; }

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600EB04 RID: 60164 RVA: 0x0042C923 File Offset: 0x0042AB23
		// (set) Token: 0x0600EB05 RID: 60165 RVA: 0x0042C92B File Offset: 0x0042AB2B
		public int delaytime { get; set; }

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600EB06 RID: 60166 RVA: 0x0042C934 File Offset: 0x0042AB34
		// (set) Token: 0x0600EB07 RID: 60167 RVA: 0x0042C93C File Offset: 0x0042AB3C
		public int exo { get; set; }

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x0042C945 File Offset: 0x0042AB45
		// (set) Token: 0x0600EB09 RID: 60169 RVA: 0x0042C94D File Offset: 0x0042AB4D
		public int hpmonsterup { get; set; }

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600EB0A RID: 60170 RVA: 0x0042C956 File Offset: 0x0042AB56
		// (set) Token: 0x0600EB0B RID: 60171 RVA: 0x0042C95E File Offset: 0x0042AB5E
		public int id { get; set; }

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600EB0C RID: 60172 RVA: 0x0042C967 File Offset: 0x0042AB67
		// (set) Token: 0x0600EB0D RID: 60173 RVA: 0x0042C96F File Offset: 0x0042AB6F
		public int isboss { get; set; }

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600EB0E RID: 60174 RVA: 0x0042C978 File Offset: 0x0042AB78
		// (set) Token: 0x0600EB0F RID: 60175 RVA: 0x0042C980 File Offset: 0x0042AB80
		public int stage { get; set; }

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600EB10 RID: 60176 RVA: 0x0042C989 File Offset: 0x0042AB89
		// (set) Token: 0x0600EB11 RID: 60177 RVA: 0x0042C991 File Offset: 0x0042AB91
		public int wave { get; set; }

		// Token: 0x0600EB12 RID: 60178 RVA: 0x0042C99C File Offset: 0x0042AB9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atkmonsterup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.delaytime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hpmonsterup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monster = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.monster[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.position = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.position[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wave = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
