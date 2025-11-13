using System;

namespace core.config
{
	// Token: 0x02001CF8 RID: 7416
	public class IChessGameCareerInfo : IConfigItem
	{
		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x0600D7F2 RID: 55282 RVA: 0x003CEC04 File Offset: 0x003CCE04
		// (set) Token: 0x0600D7F3 RID: 55283 RVA: 0x003CEC0C File Offset: 0x003CCE0C
		public string desc { get; set; }

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x003CEC15 File Offset: 0x003CCE15
		// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x003CEC1D File Offset: 0x003CCE1D
		public string initcard { get; set; }

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x003CEC26 File Offset: 0x003CCE26
		// (set) Token: 0x0600D7F7 RID: 55287 RVA: 0x003CEC2E File Offset: 0x003CCE2E
		public string initequip { get; set; }

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x003CEC37 File Offset: 0x003CCE37
		// (set) Token: 0x0600D7F9 RID: 55289 RVA: 0x003CEC3F File Offset: 0x003CCE3F
		public string name { get; set; }

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x003CEC48 File Offset: 0x003CCE48
		// (set) Token: 0x0600D7FB RID: 55291 RVA: 0x003CEC50 File Offset: 0x003CCE50
		public string opentime { get; set; }

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x003CEC59 File Offset: 0x003CCE59
		// (set) Token: 0x0600D7FD RID: 55293 RVA: 0x003CEC61 File Offset: 0x003CCE61
		public string talant { get; set; }

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x003CEC6A File Offset: 0x003CCE6A
		// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x003CEC72 File Offset: 0x003CCE72
		public string talanticon { get; set; }

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x003CEC7B File Offset: 0x003CCE7B
		// (set) Token: 0x0600D801 RID: 55297 RVA: 0x003CEC83 File Offset: 0x003CCE83
		public int id { get; set; }

		// Token: 0x0600D802 RID: 55298 RVA: 0x003CEC8C File Offset: 0x003CCE8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initcard = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.initequip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.opentime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.talant = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.talanticon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
