using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.manager;

namespace core.model
{
	// Token: 0x02001928 RID: 6440
	public class EmailInfo
	{
		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x0600CAB8 RID: 51896 RVA: 0x003B091A File Offset: 0x003AEB1A
		// (set) Token: 0x0600CAB9 RID: 51897 RVA: 0x003B0922 File Offset: 0x003AEB22
		public int mId
		{
			get
			{
				return this.m_MId;
			}
			set
			{
				this.m_MId = value;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600CABA RID: 51898 RVA: 0x003B092B File Offset: 0x003AEB2B
		public int headType
		{
			get
			{
				return this.m_HeadType;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600CABB RID: 51899 RVA: 0x003B0933 File Offset: 0x003AEB33
		public int headId
		{
			get
			{
				return this.m_HeadId;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600CABC RID: 51900 RVA: 0x003B093B File Offset: 0x003AEB3B
		// (set) Token: 0x0600CABD RID: 51901 RVA: 0x003B0943 File Offset: 0x003AEB43
		public string expire_time
		{
			get
			{
				return this.m_ExpireTime;
			}
			set
			{
				this.m_ExpireTime = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600CABE RID: 51902 RVA: 0x003B094C File Offset: 0x003AEB4C
		// (set) Token: 0x0600CABF RID: 51903 RVA: 0x003B0954 File Offset: 0x003AEB54
		public int remainingday
		{
			get
			{
				return this.m_Remainingday;
			}
			set
			{
				this.m_Remainingday = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x003B095D File Offset: 0x003AEB5D
		// (set) Token: 0x0600CAC1 RID: 51905 RVA: 0x003B0965 File Offset: 0x003AEB65
		public string Isexpire_time
		{
			get
			{
				return this.m_IsexpireTime;
			}
			set
			{
				this.m_IsexpireTime = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x003B096E File Offset: 0x003AEB6E
		// (set) Token: 0x0600CAC3 RID: 51907 RVA: 0x003B0976 File Offset: 0x003AEB76
		public string attachment
		{
			get
			{
				return this.m_Attachment;
			}
			set
			{
				this.m_Attachment = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x003B097F File Offset: 0x003AEB7F
		// (set) Token: 0x0600CAC5 RID: 51909 RVA: 0x003B0987 File Offset: 0x003AEB87
		public string content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600CAC6 RID: 51910 RVA: 0x003B0990 File Offset: 0x003AEB90
		// (set) Token: 0x0600CAC7 RID: 51911 RVA: 0x003B0998 File Offset: 0x003AEB98
		public List<EmailRewardInfo> reward
		{
			get
			{
				return this.m_Reward;
			}
			set
			{
				this.m_Reward = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600CAC8 RID: 51912 RVA: 0x003B09A1 File Offset: 0x003AEBA1
		// (set) Token: 0x0600CAC9 RID: 51913 RVA: 0x003B09A9 File Offset: 0x003AEBA9
		public bool status
		{
			get
			{
				return this.m_Status;
			}
			set
			{
				this.m_Status = value;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600CACA RID: 51914 RVA: 0x003B09B2 File Offset: 0x003AEBB2
		// (set) Token: 0x0600CACB RID: 51915 RVA: 0x003B09BA File Offset: 0x003AEBBA
		public string sender
		{
			get
			{
				return this.m_Sender;
			}
			set
			{
				this.m_Sender = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600CACC RID: 51916 RVA: 0x003B09C3 File Offset: 0x003AEBC3
		// (set) Token: 0x0600CACD RID: 51917 RVA: 0x003B09CB File Offset: 0x003AEBCB
		public string title
		{
			get
			{
				return this.m_Title;
			}
			set
			{
				this.m_Title = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600CACE RID: 51918 RVA: 0x003B09D4 File Offset: 0x003AEBD4
		// (set) Token: 0x0600CACF RID: 51919 RVA: 0x003B09DC File Offset: 0x003AEBDC
		public string date
		{
			get
			{
				return this.m_Date;
			}
			set
			{
				this.m_Date = value;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600CAD0 RID: 51920 RVA: 0x003B09E5 File Offset: 0x003AEBE5
		// (set) Token: 0x0600CAD1 RID: 51921 RVA: 0x003B09ED File Offset: 0x003AEBED
		public string star
		{
			get
			{
				return this.m_Star;
			}
			set
			{
				this.m_Star = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600CAD2 RID: 51922 RVA: 0x003B09F6 File Offset: 0x003AEBF6
		// (set) Token: 0x0600CAD3 RID: 51923 RVA: 0x003B09FE File Offset: 0x003AEBFE
		public bool hasAttachment
		{
			get
			{
				return this.m_HasAttachment;
			}
			set
			{
				this.m_HasAttachment = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x0600CAD4 RID: 51924 RVA: 0x003B0A07 File Offset: 0x003AEC07
		// (set) Token: 0x0600CAD5 RID: 51925 RVA: 0x003B0A0F File Offset: 0x003AEC0F
		public bool attachmentGetFlag
		{
			get
			{
				return this.m_AttachmentGetFlag;
			}
			set
			{
				this.m_AttachmentGetFlag = value;
			}
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x003B0A18 File Offset: 0x003AEC18
		public EmailInfo(ByteArray data = null)
		{
			this.mId = (int)data.ReadUnsignedInt();
			this.status = (data.ReadUnsignedInt() == 0U);
			this.m_SenderTemp = data.ReadUTFByte(64);
			this._parseSenderInfo(this.m_SenderTemp);
			this.title = data.ReadUTFByte(64);
			DateTime dateTime = new DateTime((long)((ulong)(data.ReadUnsignedInt() * 1000U)));
			this.date = string.Concat(new string[]
			{
				dateTime.Year.ToString(),
				"/",
				(dateTime.Month + 1).ToString(),
				"/",
				dateTime.Date.ToString(),
				"/     ",
				dateTime.Hour.ToString(),
				":",
				dateTime.Minute.ToString(),
				":"
			});
			uint num = data.ReadUnsignedInt();
			DateTime dateTime2 = new DateTime((long)((ulong)num));
			this.Isexpire_time = string.Concat(new string[]
			{
				dateTime2.Year.ToString(),
				"-",
				(dateTime2.Month + 1).ToString(),
				"-",
				dateTime2.Date.ToString()
			});
			this.expire_time = string.Concat(new string[]
			{
				dateTime2.Year.ToString(),
				"年",
				(dateTime2.Month + 1).ToString(),
				"月",
				dateTime2.Date.ToString(),
				"日     ",
				dateTime2.Hour.ToString(),
				"时",
				dateTime2.Minute.ToString(),
				"分"
			});
			this.attachment = data.ReadUTFByte(200);
			uint num2 = data.ReadUnsignedInt();
			this.attachmentGetFlag = (num2 > 0U);
			int length = (int)data.ReadUnsignedInt();
			this.content = data.ReadUTFByte(length);
			//this.remainingday = (int)((ulong)num - (ulong)SystemTimerManager.sysDate.getTime());
			this.hasAttachment = !string.IsNullOrEmpty(this.attachment);
			if (!string.IsNullOrEmpty(this.attachment))
			{
				string[] array = this.attachment.Split(";", StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					EmailRewardInfo emailRewardInfo = new EmailRewardInfo();
					string[] array2 = array[i].Split(",", StringSplitOptions.None);
					emailRewardInfo.type = ((array2[0] == null) ? 0 : Convert.ToInt32(array2[0]));
					emailRewardInfo.id = ((array2[1] == null) ? 0 : Convert.ToInt32(array2[1]));
					emailRewardInfo.count = ((array2.Length < 3) ? 1 : Convert.ToInt32(array2[2]));
					this.m_Reward.Add(emailRewardInfo);
				}
			}
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x003B0D44 File Offset: 0x003AEF44
		private void _parseSenderInfo(string str)
		{
			string[] array = str.Split("+", StringSplitOptions.None);
			int headType = 0;
			int headId = 0;
			if (array.Length > 1)
			{
				string[] array2 = array[1].Split("_", StringSplitOptions.None);
				headType = Convert.ToInt32(array2[0]);
				headId = Convert.ToInt32(array2[1]);
			}
			this.m_HeadType = headType;
			this.m_HeadId = headId;
			this.m_SenderArr = array[0].Split("-", StringSplitOptions.None).ToList<string>();
			this.m_Sender = this.m_SenderArr[0];
			this.m_Star = ((this.m_SenderArr.Count > 1) ? this.m_SenderArr[1] : string.Empty);
		}

		// Token: 0x0400DF79 RID: 57209
		private string m_ExpireTime;

		// Token: 0x0400DF7A RID: 57210
		private string m_IsexpireTime;

		// Token: 0x0400DF7B RID: 57211
		private string m_Attachment;

		// Token: 0x0400DF7C RID: 57212
		private string m_Content;

		// Token: 0x0400DF7D RID: 57213
		private List<EmailRewardInfo> m_Reward = new List<EmailRewardInfo>();

		// Token: 0x0400DF7E RID: 57214
		private int m_Remainingday;

		// Token: 0x0400DF7F RID: 57215
		private int m_FixedTimeDay;

		// Token: 0x0400DF80 RID: 57216
		private int m_FixedTimePor;

		// Token: 0x0400DF81 RID: 57217
		private int m_MId;

		// Token: 0x0400DF82 RID: 57218
		private bool m_Status;

		// Token: 0x0400DF83 RID: 57219
		private string m_Sender;

		// Token: 0x0400DF84 RID: 57220
		private string m_Title;

		// Token: 0x0400DF85 RID: 57221
		private bool m_HasAttachment;

		// Token: 0x0400DF86 RID: 57222
		private bool m_AttachmentGetFlag;

		// Token: 0x0400DF87 RID: 57223
		private string m_Date;

		// Token: 0x0400DF88 RID: 57224
		private string m_SenderTemp;

		// Token: 0x0400DF89 RID: 57225
		private List<string> m_SenderArr = new List<string>();

		// Token: 0x0400DF8A RID: 57226
		private string m_Star;

		// Token: 0x0400DF8B RID: 57227
		private int m_HeadType;

		// Token: 0x0400DF8C RID: 57228
		private int m_HeadId;
	}
}
