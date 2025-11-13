using System;

namespace core.config
{
	// Token: 0x02001DAA RID: 7594
	public class INewMonsterLevelInfo : IConfigItem
	{
		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x0600DEF6 RID: 57078 RVA: 0x003D7838 File Offset: 0x003D5A38
		// (set) Token: 0x0600DEF7 RID: 57079 RVA: 0x003D7840 File Offset: 0x003D5A40
		public string image { get; set; }

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x0600DEF8 RID: 57080 RVA: 0x003D7849 File Offset: 0x003D5A49
		// (set) Token: 0x0600DEF9 RID: 57081 RVA: 0x003D7851 File Offset: 0x003D5A51
		public string isnew { get; set; }

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x003D785A File Offset: 0x003D5A5A
		// (set) Token: 0x0600DEFB RID: 57083 RVA: 0x003D7862 File Offset: 0x003D5A62
		public string isrecommend { get; set; }

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x0600DEFC RID: 57084 RVA: 0x003D786B File Offset: 0x003D5A6B
		// (set) Token: 0x0600DEFD RID: 57085 RVA: 0x003D7873 File Offset: 0x003D5A73
		public string monsterid { get; set; }

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x003D787C File Offset: 0x003D5A7C
		// (set) Token: 0x0600DEFF RID: 57087 RVA: 0x003D7884 File Offset: 0x003D5A84
		public string param { get; set; }

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x0600DF00 RID: 57088 RVA: 0x003D788D File Offset: 0x003D5A8D
		// (set) Token: 0x0600DF01 RID: 57089 RVA: 0x003D7895 File Offset: 0x003D5A95
		public string quality { get; set; }

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x003D789E File Offset: 0x003D5A9E
		// (set) Token: 0x0600DF03 RID: 57091 RVA: 0x003D78A6 File Offset: 0x003D5AA6
		public string statlog { get; set; }

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x003D78AF File Offset: 0x003D5AAF
		// (set) Token: 0x0600DF05 RID: 57093 RVA: 0x003D78B7 File Offset: 0x003D5AB7
		public int[] tag { get; set; }

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x0600DF06 RID: 57094 RVA: 0x003D78C0 File Offset: 0x003D5AC0
		// (set) Token: 0x0600DF07 RID: 57095 RVA: 0x003D78C8 File Offset: 0x003D5AC8
		public int[] type { get; set; }

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x0600DF08 RID: 57096 RVA: 0x003D78D1 File Offset: 0x003D5AD1
		// (set) Token: 0x0600DF09 RID: 57097 RVA: 0x003D78D9 File Offset: 0x003D5AD9
		public int difficult { get; set; }

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x0600DF0A RID: 57098 RVA: 0x003D78E2 File Offset: 0x003D5AE2
		// (set) Token: 0x0600DF0B RID: 57099 RVA: 0x003D78EA File Offset: 0x003D5AEA
		public int fightType { get; set; }

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x0600DF0C RID: 57100 RVA: 0x003D78F3 File Offset: 0x003D5AF3
		// (set) Token: 0x0600DF0D RID: 57101 RVA: 0x003D78FB File Offset: 0x003D5AFB
		public int hide { get; set; }

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x0600DF0E RID: 57102 RVA: 0x003D7904 File Offset: 0x003D5B04
		// (set) Token: 0x0600DF0F RID: 57103 RVA: 0x003D790C File Offset: 0x003D5B0C
		public int id { get; set; }

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x0600DF10 RID: 57104 RVA: 0x003D7915 File Offset: 0x003D5B15
		// (set) Token: 0x0600DF11 RID: 57105 RVA: 0x003D791D File Offset: 0x003D5B1D
		public int moduleid { get; set; }

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x003D7926 File Offset: 0x003D5B26
		// (set) Token: 0x0600DF13 RID: 57107 RVA: 0x003D792E File Offset: 0x003D5B2E
		public int sort { get; set; }

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x0600DF14 RID: 57108 RVA: 0x003D7937 File Offset: 0x003D5B37
		// (set) Token: 0x0600DF15 RID: 57109 RVA: 0x003D793F File Offset: 0x003D5B3F
		public int weekly { get; set; }

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x003D7948 File Offset: 0x003D5B48
		// (set) Token: 0x0600DF17 RID: 57111 RVA: 0x003D7950 File Offset: 0x003D5B50
		public int weeklyAdd { get; set; }

		// Token: 0x0600DF18 RID: 57112 RVA: 0x003D795C File Offset: 0x003D5B5C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.difficult = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.fightType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isnew = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isrecommend = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.moduleid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.quality = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.tag = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.tag[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.type = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.type[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.weekly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.weeklyAdd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x0600DF19 RID: 57113 RVA: 0x003D7ACD File Offset: 0x003D5CCD
		// (set) Token: 0x0600DF1A RID: 57114 RVA: 0x003D7AD0 File Offset: 0x003D5CD0
		public bool showTag
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
