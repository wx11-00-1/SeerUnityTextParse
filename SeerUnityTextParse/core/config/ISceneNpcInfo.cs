using System;

namespace core.config
{
	// Token: 0x02001E0A RID: 7690
	public class ISceneNpcInfo : IConfigItem
	{
		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600E32A RID: 58154 RVA: 0x003DCC24 File Offset: 0x003DAE24
		// (set) Token: 0x0600E32B RID: 58155 RVA: 0x003DCC2C File Offset: 0x003DAE2C
		public string name { get; set; }

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x0600E32C RID: 58156 RVA: 0x003DCC35 File Offset: 0x003DAE35
		// (set) Token: 0x0600E32D RID: 58157 RVA: 0x003DCC3D File Offset: 0x003DAE3D
		public string pic { get; set; }

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x003DCC46 File Offset: 0x003DAE46
		// (set) Token: 0x0600E32F RID: 58159 RVA: 0x003DCC4E File Offset: 0x003DAE4E
		public string triggerinfo { get; set; }

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x0600E330 RID: 58160 RVA: 0x003DCC57 File Offset: 0x003DAE57
		// (set) Token: 0x0600E331 RID: 58161 RVA: 0x003DCC5F File Offset: 0x003DAE5F
		public int[] FuncParam { get; set; }

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600E332 RID: 58162 RVA: 0x003DCC68 File Offset: 0x003DAE68
		// (set) Token: 0x0600E333 RID: 58163 RVA: 0x003DCC70 File Offset: 0x003DAE70
		public int bit { get; set; }

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600E334 RID: 58164 RVA: 0x003DCC79 File Offset: 0x003DAE79
		// (set) Token: 0x0600E335 RID: 58165 RVA: 0x003DCC81 File Offset: 0x003DAE81
		public int FuncParamSpecial { get; set; }

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600E336 RID: 58166 RVA: 0x003DCC8A File Offset: 0x003DAE8A
		// (set) Token: 0x0600E337 RID: 58167 RVA: 0x003DCC92 File Offset: 0x003DAE92
		public int FuncType { get; set; }

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600E338 RID: 58168 RVA: 0x003DCC9B File Offset: 0x003DAE9B
		// (set) Token: 0x0600E339 RID: 58169 RVA: 0x003DCCA3 File Offset: 0x003DAEA3
		public int id { get; set; }

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600E33A RID: 58170 RVA: 0x003DCCAC File Offset: 0x003DAEAC
		// (set) Token: 0x0600E33B RID: 58171 RVA: 0x003DCCB4 File Offset: 0x003DAEB4
		public int modelType { get; set; }

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600E33C RID: 58172 RVA: 0x003DCCBD File Offset: 0x003DAEBD
		// (set) Token: 0x0600E33D RID: 58173 RVA: 0x003DCCC5 File Offset: 0x003DAEC5
		public float offsetX { get; set; }

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600E33E RID: 58174 RVA: 0x003DCCCE File Offset: 0x003DAECE
		// (set) Token: 0x0600E33F RID: 58175 RVA: 0x003DCCD6 File Offset: 0x003DAED6
		public float offsetY { get; set; }

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x0600E340 RID: 58176 RVA: 0x003DCCDF File Offset: 0x003DAEDF
		// (set) Token: 0x0600E341 RID: 58177 RVA: 0x003DCCE7 File Offset: 0x003DAEE7
		public float scaleX { get; set; }

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600E342 RID: 58178 RVA: 0x003DCCF0 File Offset: 0x003DAEF0
		// (set) Token: 0x0600E343 RID: 58179 RVA: 0x003DCCF8 File Offset: 0x003DAEF8
		public float scaleY { get; set; }

		// Token: 0x0600E344 RID: 58180 RVA: 0x003DCD04 File Offset: 0x003DAF04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.FuncParam = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.FuncParam[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.FuncParamSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FuncType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.modelType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.offsetX = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.offsetY = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.scaleX = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.scaleY = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.triggerinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
