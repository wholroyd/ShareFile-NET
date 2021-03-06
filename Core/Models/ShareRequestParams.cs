// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class ShareRequestParams : ODataObject 
	{

		public string FolderId { get; set; }

		public string FolderPath { get; set; }

		public IEnumerable<string> Emails { get; set; }

		public string Subject { get; set; }

		public string Body { get; set; }

		public bool CcSender { get; set; }

		public bool RequireLogin { get; set; }

		public int ExpirationDays { get; set; }

		public bool NotifyOnUpload { get; set; }

		public bool IsViewOnly { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ShareRequestParams;
			if(typedSource != null)
			{
				FolderId = typedSource.FolderId;
				FolderPath = typedSource.FolderPath;
				Emails = typedSource.Emails;
				Subject = typedSource.Subject;
				Body = typedSource.Body;
				CcSender = typedSource.CcSender;
				RequireLogin = typedSource.RequireLogin;
				ExpirationDays = typedSource.ExpirationDays;
				NotifyOnUpload = typedSource.NotifyOnUpload;
				IsViewOnly = typedSource.IsViewOnly;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("FolderId", out token) && token.Type != JTokenType.Null)
				{
					FolderId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("FolderPath", out token) && token.Type != JTokenType.Null)
				{
					FolderPath = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Emails", out token) && token.Type != JTokenType.Null)
				{
					Emails = (IEnumerable<string>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<string>));
				}
				if(source.TryGetProperty("Subject", out token) && token.Type != JTokenType.Null)
				{
					Subject = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Body", out token) && token.Type != JTokenType.Null)
				{
					Body = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CcSender", out token) && token.Type != JTokenType.Null)
				{
					CcSender = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("RequireLogin", out token) && token.Type != JTokenType.Null)
				{
					RequireLogin = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("ExpirationDays", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDays = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("NotifyOnUpload", out token) && token.Type != JTokenType.Null)
				{
					NotifyOnUpload = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("IsViewOnly", out token) && token.Type != JTokenType.Null)
				{
					IsViewOnly = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}