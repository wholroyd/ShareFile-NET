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
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{
    public interface ISessionsEntity : IEntityBase
    {
        
        /// <summary>
        /// Get Session
        /// </summary>
        /// <remarks>
        /// Retrieve the current authentication session object. If the client is not authenticated,
        /// this operation will challenge for ShareFile authentication using a 401 response. This method will
        /// not trigger the SAML authentication flow - use /Sessions/Login instead.
        /// </remarks>
        /// <returns>
        /// The current authentication Context, based on the request SFAPI_AuthID Cookie
        /// </returns>
        IQuery<Session> Get();
        
        /// <summary>
        /// Logout
        /// </summary>
        /// <remarks>
        /// Logout the current session - invalidate the current Session ID
        /// </remarks>
        IQuery Delete();
        
        /// <summary>
        /// Login
        /// </summary>
        /// <remarks>
        /// API clients can provide ShareFile Authentication directly to any API operation using OAuth (Bearer).
        /// However, the client must know that the provided authentication type is supported on the API endpoint; and that SAML is not configured.
        /// 
        /// This API provides a generic authentication routine for clients. It will challenge for ShareFile credentials
        /// passing all supported authentication methods; redirect to the SAML IDP if configured to do so; and handle
        /// certain HTTP headers, like device registration.
        /// 
        /// If the client is already authenticated, the Session object is returned. If the client is not authenticated, and
        /// the account is not configured for SAML, then the API will challenge for a local authentication. If the account
        /// is configured for SAML, then the client will be redirected to the SAML IDP using the SAML passive flow - authentication
        /// will be performed at the IDP domain instead. The IDP callback will be on the API Acs, which will return a Session
        /// object if authentication is accepted.
        /// 
        /// The following HTTP Headers are also processed in this request, and stored with the Session object:
        /// X-SFAPI-Tool: Tool string (user-agent equivalent for ShareFile)X-SFAPI-ToolVersion: Tool Version stringX-SFAPI-UserInitiated: true or false, indicates whether this is an interactive login, or re-authentication
        /// initiated by the ToolX-SFAPI-DeviceId: Device Identifier. If set to 'register', a new DeviceID will be generated. This will
        /// either create or associate an existing DeviceID to this session - indicates user is logging in using this DeviceX-SFAPI-DeviceName: Device Name. Only required/used when a registration process occurs.
        /// </remarks>
        /// <param name="authmethod"></param>
        /// <param name="authcomparison"></param>
        /// <returns>
        /// A Session object, if authentication is successful
        /// </returns>
        IQuery<Session> Login(string authmethod = null, string authcomparison = null);
        
        /// <summary>
        /// Get Assertion Consumer Service. This is the IDP callback endpoint in SAML authentication
        /// </summary>
        IQuery<Session> Acs();
    }

    public class SessionsEntity : EntityBase, ISessionsEntity
    {
        public SessionsEntity (IShareFileClient client)
            : base (client, "Sessions")
        { }
        
        
        /// <summary>
        /// Get Session
        /// </summary>
        /// <remarks>
        /// Retrieve the current authentication session object. If the client is not authenticated,
        /// this operation will challenge for ShareFile authentication using a 401 response. This method will
        /// not trigger the SAML authentication flow - use /Sessions/Login instead.
        /// </remarks>
        /// <returns>
        /// The current authentication Context, based on the request SFAPI_AuthID Cookie
        /// </returns>
        public IQuery<Session> Get()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Session>(Client);
		    sfApiQuery.From("Sessions");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Logout
        /// </summary>
        /// <remarks>
        /// Logout the current session - invalidate the current Session ID
        /// </remarks>
        public IQuery Delete()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Sessions");
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Login
        /// </summary>
        /// <remarks>
        /// API clients can provide ShareFile Authentication directly to any API operation using OAuth (Bearer).
        /// However, the client must know that the provided authentication type is supported on the API endpoint; and that SAML is not configured.
        /// 
        /// This API provides a generic authentication routine for clients. It will challenge for ShareFile credentials
        /// passing all supported authentication methods; redirect to the SAML IDP if configured to do so; and handle
        /// certain HTTP headers, like device registration.
        /// 
        /// If the client is already authenticated, the Session object is returned. If the client is not authenticated, and
        /// the account is not configured for SAML, then the API will challenge for a local authentication. If the account
        /// is configured for SAML, then the client will be redirected to the SAML IDP using the SAML passive flow - authentication
        /// will be performed at the IDP domain instead. The IDP callback will be on the API Acs, which will return a Session
        /// object if authentication is accepted.
        /// 
        /// The following HTTP Headers are also processed in this request, and stored with the Session object:
        /// X-SFAPI-Tool: Tool string (user-agent equivalent for ShareFile)X-SFAPI-ToolVersion: Tool Version stringX-SFAPI-UserInitiated: true or false, indicates whether this is an interactive login, or re-authentication
        /// initiated by the ToolX-SFAPI-DeviceId: Device Identifier. If set to 'register', a new DeviceID will be generated. This will
        /// either create or associate an existing DeviceID to this session - indicates user is logging in using this DeviceX-SFAPI-DeviceName: Device Name. Only required/used when a registration process occurs.
        /// </remarks>
        /// <param name="authmethod"></param>
        /// <param name="authcomparison"></param>
        /// <returns>
        /// A Session object, if authentication is successful
        /// </returns>
        public IQuery<Session> Login(string authmethod = null, string authcomparison = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Session>(Client);
		    sfApiQuery.From("Sessions");
		    sfApiQuery.Action("Login");
            sfApiQuery.QueryString("authmethod", authmethod);
            sfApiQuery.QueryString("authcomparison", authcomparison);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Assertion Consumer Service. This is the IDP callback endpoint in SAML authentication
        /// </summary>
        public IQuery<Session> Acs()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Session>(Client);
		    sfApiQuery.From("Sessions");
		    sfApiQuery.Action("Acs");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
    }
}