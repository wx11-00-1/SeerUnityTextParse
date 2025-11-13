using System;

namespace core.config
{
	// Token: 0x02001E04 RID: 7684
	public class IRoleInformationInfo : IConfigItem
	{
		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x0600E2EC RID: 58092 RVA: 0x003DC6E8 File Offset: 0x003DA8E8
		// (set) Token: 0x0600E2ED RID: 58093 RVA: 0x003DC6F0 File Offset: 0x003DA8F0
		public string activeSkills { get; set; }

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x0600E2EE RID: 58094 RVA: 0x003DC6F9 File Offset: 0x003DA8F9
		// (set) Token: 0x0600E2EF RID: 58095 RVA: 0x003DC701 File Offset: 0x003DA901
		public string name { get; set; }

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x003DC70A File Offset: 0x003DA90A
		// (set) Token: 0x0600E2F1 RID: 58097 RVA: 0x003DC712 File Offset: 0x003DA912
		public string passiveSkills { get; set; }

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600E2F2 RID: 58098 RVA: 0x003DC71B File Offset: 0x003DA91B
		// (set) Token: 0x0600E2F3 RID: 58099 RVA: 0x003DC723 File Offset: 0x003DA923
		public string resources { get; set; }

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x003DC72C File Offset: 0x003DA92C
		// (set) Token: 0x0600E2F5 RID: 58101 RVA: 0x003DC734 File Offset: 0x003DA934
		public int attack { get; set; }

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600E2F6 RID: 58102 RVA: 0x003DC73D File Offset: 0x003DA93D
		// (set) Token: 0x0600E2F7 RID: 58103 RVA: 0x003DC745 File Offset: 0x003DA945
		public int combatEffectiveness { get; set; }

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x003DC74E File Offset: 0x003DA94E
		// (set) Token: 0x0600E2F9 RID: 58105 RVA: 0x003DC756 File Offset: 0x003DA956
		public int defense { get; set; }

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600E2FA RID: 58106 RVA: 0x003DC75F File Offset: 0x003DA95F
		// (set) Token: 0x0600E2FB RID: 58107 RVA: 0x003DC767 File Offset: 0x003DA967
		public int healthPoints { get; set; }

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x003DC770 File Offset: 0x003DA970
		// (set) Token: 0x0600E2FD RID: 58109 RVA: 0x003DC778 File Offset: 0x003DA978
		public int id { get; set; }

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x003DC781 File Offset: 0x003DA981
		// (set) Token: 0x0600E2FF RID: 58111 RVA: 0x003DC789 File Offset: 0x003DA989
		public int petid { get; set; }

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x0600E300 RID: 58112 RVA: 0x003DC792 File Offset: 0x003DA992
		// (set) Token: 0x0600E301 RID: 58113 RVA: 0x003DC79A File Offset: 0x003DA99A
		public int speed { get; set; }

		// Token: 0x0600E302 RID: 58114 RVA: 0x003DC7A4 File Offset: 0x003DA9A4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activeSkills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.combatEffectiveness = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.defense = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.healthPoints = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.passiveSkills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.resources = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
