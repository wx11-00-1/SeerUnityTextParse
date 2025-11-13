using System;

namespace core.config
{
	// Token: 0x02001C80 RID: 7296
	public interface IConfigItem
	{
		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600D295 RID: 53909
		// (set) Token: 0x0600D296 RID: 53910
		int id { get; set; }

		// Token: 0x0600D297 RID: 53911
		void Parse(byte[] bytes, ref int byteIndex);
	}
}
