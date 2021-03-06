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
	public class DownloadSpecification : ODataObject 
	{

		public string DownloadToken { get; set; }

		public string PrepareXmlInfo { get; set; }

		public Uri DownloadUrl { get; set; }

		public Uri DownloadPrepStartURL { get; set; }

		public Uri DownloadPrepStatusURL { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as DownloadSpecification;
			if(typedSource != null)
			{
				DownloadToken = typedSource.DownloadToken;
				PrepareXmlInfo = typedSource.PrepareXmlInfo;
				DownloadUrl = typedSource.DownloadUrl;
				DownloadPrepStartURL = typedSource.DownloadPrepStartURL;
				DownloadPrepStatusURL = typedSource.DownloadPrepStatusURL;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("DownloadToken", out token) && token.Type != JTokenType.Null)
				{
					DownloadToken = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PrepareXmlInfo", out token) && token.Type != JTokenType.Null)
				{
					PrepareXmlInfo = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DownloadUrl", out token) && token.Type != JTokenType.Null)
				{
					DownloadUrl = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
				if(source.TryGetProperty("DownloadPrepStartURL", out token) && token.Type != JTokenType.Null)
				{
					DownloadPrepStartURL = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
				if(source.TryGetProperty("DownloadPrepStatusURL", out token) && token.Type != JTokenType.Null)
				{
					DownloadPrepStatusURL = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
			}
		}
	}
}