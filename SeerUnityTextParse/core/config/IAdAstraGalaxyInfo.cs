using System;

namespace core.config
{
	// Token: 0x02001C96 RID: 7318
	public class IAdAstraGalaxyInfo : IConfigItem
	{
		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600D3BE RID: 54206 RVA: 0x003C9B78 File Offset: 0x003C7D78
		// (set) Token: 0x0600D3BF RID: 54207 RVA: 0x003C9B80 File Offset: 0x003C7D80
		public string galaxyName { get; set; }

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600D3C0 RID: 54208 RVA: 0x003C9B89 File Offset: 0x003C7D89
		// (set) Token: 0x0600D3C1 RID: 54209 RVA: 0x003C9B91 File Offset: 0x003C7D91
		public string galaxyNameEn { get; set; }

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x003C9B9A File Offset: 0x003C7D9A
		// (set) Token: 0x0600D3C3 RID: 54211 RVA: 0x003C9BA2 File Offset: 0x003C7DA2
		public string starLevel { get; set; }

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600D3C4 RID: 54212 RVA: 0x003C9BAB File Offset: 0x003C7DAB
		// (set) Token: 0x0600D3C5 RID: 54213 RVA: 0x003C9BB3 File Offset: 0x003C7DB3
		public string starName { get; set; }

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600D3C6 RID: 54214 RVA: 0x003C9BBC File Offset: 0x003C7DBC
		// (set) Token: 0x0600D3C7 RID: 54215 RVA: 0x003C9BC4 File Offset: 0x003C7DC4
		public string unlockStar { get; set; }

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x0600D3C8 RID: 54216 RVA: 0x003C9BCD File Offset: 0x003C7DCD
		// (set) Token: 0x0600D3C9 RID: 54217 RVA: 0x003C9BD5 File Offset: 0x003C7DD5
		public int endTime { get; set; }

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600D3CA RID: 54218 RVA: 0x003C9BDE File Offset: 0x003C7DDE
		// (set) Token: 0x0600D3CB RID: 54219 RVA: 0x003C9BE6 File Offset: 0x003C7DE6
		public int galaxyId { get; set; }

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600D3CC RID: 54220 RVA: 0x003C9BEF File Offset: 0x003C7DEF
		// (set) Token: 0x0600D3CD RID: 54221 RVA: 0x003C9BF7 File Offset: 0x003C7DF7
		public int galaxyType { get; set; }

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600D3CE RID: 54222 RVA: 0x003C9C00 File Offset: 0x003C7E00
		// (set) Token: 0x0600D3CF RID: 54223 RVA: 0x003C9C08 File Offset: 0x003C7E08
		public int id { get; set; }

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600D3D0 RID: 54224 RVA: 0x003C9C11 File Offset: 0x003C7E11
		// (set) Token: 0x0600D3D1 RID: 54225 RVA: 0x003C9C19 File Offset: 0x003C7E19
		public int starId { get; set; }

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600D3D2 RID: 54226 RVA: 0x003C9C22 File Offset: 0x003C7E22
		// (set) Token: 0x0600D3D3 RID: 54227 RVA: 0x003C9C2A File Offset: 0x003C7E2A
		public int starProgressAll { get; set; }

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600D3D4 RID: 54228 RVA: 0x003C9C33 File Offset: 0x003C7E33
		// (set) Token: 0x0600D3D5 RID: 54229 RVA: 0x003C9C3B File Offset: 0x003C7E3B
		public int unlockTime { get; set; }

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x003C9C44 File Offset: 0x003C7E44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.galaxyId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.galaxyName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.galaxyNameEn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.galaxyType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starLevel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.starName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.starProgressAll = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockStar = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlockTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
