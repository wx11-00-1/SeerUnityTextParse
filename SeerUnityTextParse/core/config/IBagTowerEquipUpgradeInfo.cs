using System;

namespace core.config
{
	// Token: 0x02001EF9 RID: 7929
	public class IBagTowerEquipUpgradeInfo : IConfigItem
	{
		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x0600EA94 RID: 60052 RVA: 0x0042C170 File Offset: 0x0042A370
		// (set) Token: 0x0600EA95 RID: 60053 RVA: 0x0042C178 File Offset: 0x0042A378
		public string icon { get; set; }

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x0600EA96 RID: 60054 RVA: 0x0042C181 File Offset: 0x0042A381
		// (set) Token: 0x0600EA97 RID: 60055 RVA: 0x0042C189 File Offset: 0x0042A389
		public string name { get; set; }

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x0600EA98 RID: 60056 RVA: 0x0042C192 File Offset: 0x0042A392
		// (set) Token: 0x0600EA99 RID: 60057 RVA: 0x0042C19A File Offset: 0x0042A39A
		public int[] cost { get; set; }

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600EA9A RID: 60058 RVA: 0x0042C1A3 File Offset: 0x0042A3A3
		// (set) Token: 0x0600EA9B RID: 60059 RVA: 0x0042C1AB File Offset: 0x0042A3AB
		public int atk { get; set; }

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600EA9C RID: 60060 RVA: 0x0042C1B4 File Offset: 0x0042A3B4
		// (set) Token: 0x0600EA9D RID: 60061 RVA: 0x0042C1BC File Offset: 0x0042A3BC
		public int defadd { get; set; }

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600EA9E RID: 60062 RVA: 0x0042C1C5 File Offset: 0x0042A3C5
		// (set) Token: 0x0600EA9F RID: 60063 RVA: 0x0042C1CD File Offset: 0x0042A3CD
		public int flyspeed { get; set; }

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600EAA0 RID: 60064 RVA: 0x0042C1D6 File Offset: 0x0042A3D6
		// (set) Token: 0x0600EAA1 RID: 60065 RVA: 0x0042C1DE File Offset: 0x0042A3DE
		public int goldadd { get; set; }

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600EAA2 RID: 60066 RVA: 0x0042C1E7 File Offset: 0x0042A3E7
		// (set) Token: 0x0600EAA3 RID: 60067 RVA: 0x0042C1EF File Offset: 0x0042A3EF
		public int hpaddlimit { get; set; }

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x0600EAA4 RID: 60068 RVA: 0x0042C1F8 File Offset: 0x0042A3F8
		// (set) Token: 0x0600EAA5 RID: 60069 RVA: 0x0042C200 File Offset: 0x0042A400
		public int hprecover { get; set; }

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600EAA6 RID: 60070 RVA: 0x0042C209 File Offset: 0x0042A409
		// (set) Token: 0x0600EAA7 RID: 60071 RVA: 0x0042C211 File Offset: 0x0042A411
		public int id { get; set; }

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600EAA8 RID: 60072 RVA: 0x0042C21A File Offset: 0x0042A41A
		// (set) Token: 0x0600EAA9 RID: 60073 RVA: 0x0042C222 File Offset: 0x0042A422
		public int isshow { get; set; }

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x0600EAAA RID: 60074 RVA: 0x0042C22B File Offset: 0x0042A42B
		// (set) Token: 0x0600EAAB RID: 60075 RVA: 0x0042C233 File Offset: 0x0042A433
		public int lv { get; set; }

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600EAAC RID: 60076 RVA: 0x0042C23C File Offset: 0x0042A43C
		// (set) Token: 0x0600EAAD RID: 60077 RVA: 0x0042C244 File Offset: 0x0042A444
		public int opensynthesis { get; set; }

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600EAAE RID: 60078 RVA: 0x0042C24D File Offset: 0x0042A44D
		// (set) Token: 0x0600EAAF RID: 60079 RVA: 0x0042C255 File Offset: 0x0042A455
		public int range { get; set; }

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x0600EAB0 RID: 60080 RVA: 0x0042C25E File Offset: 0x0042A45E
		// (set) Token: 0x0600EAB1 RID: 60081 RVA: 0x0042C266 File Offset: 0x0042A466
		public int size { get; set; }

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x0600EAB2 RID: 60082 RVA: 0x0042C26F File Offset: 0x0042A46F
		// (set) Token: 0x0600EAB3 RID: 60083 RVA: 0x0042C277 File Offset: 0x0042A477
		public int subtype { get; set; }

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x0600EAB4 RID: 60084 RVA: 0x0042C280 File Offset: 0x0042A480
		// (set) Token: 0x0600EAB5 RID: 60085 RVA: 0x0042C288 File Offset: 0x0042A488
		public int target { get; set; }

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600EAB6 RID: 60086 RVA: 0x0042C291 File Offset: 0x0042A491
		// (set) Token: 0x0600EAB7 RID: 60087 RVA: 0x0042C299 File Offset: 0x0042A499
		public int type { get; set; }

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x0042C2A2 File Offset: 0x0042A4A2
		// (set) Token: 0x0600EAB9 RID: 60089 RVA: 0x0042C2AA File Offset: 0x0042A4AA
		public int unlockeffect { get; set; }

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600EABA RID: 60090 RVA: 0x0042C2B3 File Offset: 0x0042A4B3
		// (set) Token: 0x0600EABB RID: 60091 RVA: 0x0042C2BB File Offset: 0x0042A4BB
		public int usespeed { get; set; }

		// Token: 0x0600EABC RID: 60092 RVA: 0x0042C2C4 File Offset: 0x0042A4C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.cost = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.cost[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.defadd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.flyspeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.goldadd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hpaddlimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hprecover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.opensynthesis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.range = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.size = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockeffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.usespeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
