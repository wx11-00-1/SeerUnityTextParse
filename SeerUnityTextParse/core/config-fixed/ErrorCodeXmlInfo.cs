using System;
using System.Collections.Generic;
using common;
using core.config.error_code_analysis;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;

namespace core.config
{
	// Token: 0x02001E9E RID: 7838
	public class ErrorCodeXmlInfo : ConfigManagerSingleton<ErrorCodeXmlInfo>
	{
		// Token: 0x0600EA0C RID: 59916 RVA: 0x003E6535 File Offset: 0x003E4735
		//
		//}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x003E6553 File Offset: 0x003E4753
		//

		// Token: 0x0600EA0E RID: 59918 RVA: 0x003E6564 File Offset: 0x003E4764
		//

		// Token: 0x0600EA0F RID: 59919 RVA: 0x003E65A7 File Offset: 0x003E47A7
		public bool hasConfig(int id)
		{
			return this.s_XmlInfoDict.ContainsKey(id);
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x003E65B8 File Offset: 0x003E47B8
		public string getErrorText(int id)
		{
			IErrorpostItem errorpostItem;
			if (this.s_XmlInfoDict.TryGetValue(id, out errorpostItem))
			{
				return errorpostItem.tx;
			}
			return null;
		}

		// Token: 0x0400ED34 RID: 60724
		private Dictionary<int, IErrorpostItem> s_XmlInfoDict;
	}
}
