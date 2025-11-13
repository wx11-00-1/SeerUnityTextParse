using System;

namespace core.config
{
	// Token: 0x02001CF6 RID: 7414
	public class IChessGameCardInfo : IConfigItem
	{
		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600D7BC RID: 55228 RVA: 0x003CE86C File Offset: 0x003CCA6C
		// (set) Token: 0x0600D7BD RID: 55229 RVA: 0x003CE874 File Offset: 0x003CCA74
		public string buff { get; set; }

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x003CE87D File Offset: 0x003CCA7D
		// (set) Token: 0x0600D7BF RID: 55231 RVA: 0x003CE885 File Offset: 0x003CCA85
		public string buynum { get; set; }

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600D7C0 RID: 55232 RVA: 0x003CE88E File Offset: 0x003CCA8E
		// (set) Token: 0x0600D7C1 RID: 55233 RVA: 0x003CE896 File Offset: 0x003CCA96
		public string cardeffect { get; set; }

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600D7C2 RID: 55234 RVA: 0x003CE89F File Offset: 0x003CCA9F
		// (set) Token: 0x0600D7C3 RID: 55235 RVA: 0x003CE8A7 File Offset: 0x003CCAA7
		public string desc { get; set; }

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x003CE8B0 File Offset: 0x003CCAB0
		// (set) Token: 0x0600D7C5 RID: 55237 RVA: 0x003CE8B8 File Offset: 0x003CCAB8
		public string icon { get; set; }

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x003CE8C1 File Offset: 0x003CCAC1
		// (set) Token: 0x0600D7C7 RID: 55239 RVA: 0x003CE8C9 File Offset: 0x003CCAC9
		public string move { get; set; }

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x0600D7C8 RID: 55240 RVA: 0x003CE8D2 File Offset: 0x003CCAD2
		// (set) Token: 0x0600D7C9 RID: 55241 RVA: 0x003CE8DA File Offset: 0x003CCADA
		public string name { get; set; }

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x0600D7CA RID: 55242 RVA: 0x003CE8E3 File Offset: 0x003CCAE3
		// (set) Token: 0x0600D7CB RID: 55243 RVA: 0x003CE8EB File Offset: 0x003CCAEB
		public string opentime { get; set; }

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x0600D7CC RID: 55244 RVA: 0x003CE8F4 File Offset: 0x003CCAF4
		// (set) Token: 0x0600D7CD RID: 55245 RVA: 0x003CE8FC File Offset: 0x003CCAFC
		public int acttype { get; set; }

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x0600D7CE RID: 55246 RVA: 0x003CE905 File Offset: 0x003CCB05
		// (set) Token: 0x0600D7CF RID: 55247 RVA: 0x003CE90D File Offset: 0x003CCB0D
		public int atk { get; set; }

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600D7D0 RID: 55248 RVA: 0x003CE916 File Offset: 0x003CCB16
		// (set) Token: 0x0600D7D1 RID: 55249 RVA: 0x003CE91E File Offset: 0x003CCB1E
		public int def { get; set; }

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x003CE927 File Offset: 0x003CCB27
		// (set) Token: 0x0600D7D3 RID: 55251 RVA: 0x003CE92F File Offset: 0x003CCB2F
		public int energy { get; set; }

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600D7D4 RID: 55252 RVA: 0x003CE938 File Offset: 0x003CCB38
		// (set) Token: 0x0600D7D5 RID: 55253 RVA: 0x003CE940 File Offset: 0x003CCB40
		public int id { get; set; }

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x003CE949 File Offset: 0x003CCB49
		// (set) Token: 0x0600D7D7 RID: 55255 RVA: 0x003CE951 File Offset: 0x003CCB51
		public int isequip { get; set; }

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x0600D7D8 RID: 55256 RVA: 0x003CE95A File Offset: 0x003CCB5A
		// (set) Token: 0x0600D7D9 RID: 55257 RVA: 0x003CE962 File Offset: 0x003CCB62
		public int ishand { get; set; }

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x003CE96B File Offset: 0x003CCB6B
		// (set) Token: 0x0600D7DB RID: 55259 RVA: 0x003CE973 File Offset: 0x003CCB73
		public int occupation { get; set; }

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x003CE97C File Offset: 0x003CCB7C
		// (set) Token: 0x0600D7DD RID: 55261 RVA: 0x003CE984 File Offset: 0x003CCB84
		public int quality { get; set; }

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x003CE98D File Offset: 0x003CCB8D
		// (set) Token: 0x0600D7DF RID: 55263 RVA: 0x003CE995 File Offset: 0x003CCB95
		public int takerange { get; set; }

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x003CE99E File Offset: 0x003CCB9E
		// (set) Token: 0x0600D7E1 RID: 55265 RVA: 0x003CE9A6 File Offset: 0x003CCBA6
		public int takerangetype { get; set; }

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x003CE9AF File Offset: 0x003CCBAF
		// (set) Token: 0x0600D7E3 RID: 55267 RVA: 0x003CE9B7 File Offset: 0x003CCBB7
		public int type { get; set; }

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x003CE9C0 File Offset: 0x003CCBC0
		// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x003CE9C8 File Offset: 0x003CCBC8
		public int upgradeid { get; set; }

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600D7E6 RID: 55270 RVA: 0x003CE9D1 File Offset: 0x003CCBD1
		// (set) Token: 0x0600D7E7 RID: 55271 RVA: 0x003CE9D9 File Offset: 0x003CCBD9
		public int useobject { get; set; }

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x003CE9E2 File Offset: 0x003CCBE2
		// (set) Token: 0x0600D7E9 RID: 55273 RVA: 0x003CE9EA File Offset: 0x003CCBEA
		public int userangelength { get; set; }

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x003CE9F3 File Offset: 0x003CCBF3
		// (set) Token: 0x0600D7EB RID: 55275 RVA: 0x003CE9FB File Offset: 0x003CCBFB
		public int userangetype { get; set; }

		// Token: 0x0600D7EC RID: 55276 RVA: 0x003CEA04 File Offset: 0x003CCC04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.acttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.buynum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.cardeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.energy = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ishand = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.move = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.occupation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opentime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.takerange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.takerangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.upgradeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.useobject = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userangelength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
