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
    public interface IGroupsEntity : IEntityBase
    {
        
        /// <summary>
        /// Get Group List
        /// </summary>
        /// <remarks>
        /// Retrieves all Distribution Groups this user has permissions to View in this account
        /// </remarks>
        /// <returns>
        /// a list of Groups this user has access to
        /// </returns>
        IQuery<ODataFeed<Group>> Get();
        
        /// <summary>
        /// Get Group By ID
        /// </summary>
        /// <remarks>
        /// Retrives a single Group by id
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A single Group object
        /// </returns>
        IQuery<Group> Get(Uri url);
        
        /// <summary>
        /// Delete Group
        /// </summary>
        /// <remarks>
        /// Removes a single Group by id
        /// </remarks>
        /// <param name="url"></param>
        IQuery Delete(Uri url);
        
        /// <summary>
        /// Create Group
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "IsShared":true,
        /// "Contacts":[{"Email":"user.one@domain.com"},{"Email":"user.two@domain.com"}]
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new group. The Post body must include the specification of the group.
        /// </remarks>
        /// <param name="group"></param>
        /// <returns>
        /// the new group instance
        /// </returns>
        IQuery<Group> Create(Group group);
        
        /// <summary>
        /// Update Group
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "IsShared":true,
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing group.
        /// This operation will ignore the provided clients list. Use the \Contacts navigation link to
        /// add/remove elements from a group
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="group"></param>
        /// <returns>
        /// the modified group object
        /// </returns>
        IQuery<Group> Update(Uri url, Group group);
        
        /// <summary>
        /// Get Group Contacts
        /// </summary>
        /// <remarks>
        /// Retrieves the Contacts navigation property of a Group
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A feed of Contacts representing the members of the Group
        /// </returns>
        IQuery<ODataFeed<Contact>> GetContacts(Uri url);
        
        /// <summary>
        /// Add Contacts to Group
        /// </summary>
        /// <example>
        /// [{"Email":"user.one@domain.com"},{"Id":"abcd"}]
        /// </example>
        /// <remarks>
        /// Adds a list of contacts to a group
        /// The contact list may contain either contact ID (same as User ID) or Email.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="contacts"></param>
        /// <returns>
        /// The updated list of contacts for this group
        /// </returns>
        IQuery<ODataFeed<Contact>> CreateContacts(Uri url, IEnumerable<Contact> contacts);
        
        /// <summary>
        /// Remove Contacts from Group
        /// </summary>
        /// <example>
        /// [{"Email":"user.one@domain.com"},{"Id":"abcd"}]
        /// </example>
        /// <remarks>
        /// Removes contacts from a group
        /// The contact list may contain either contact ID (same as User ID) or Email.
        /// This method will ignore missing references in the provided list - i.e., if an email in the contacts
        /// list is not present in the group, it will be ignored.
        /// The method will not enforce that ID and Email match inside a single Contact instance: Id will be
        /// looked up first, then Email.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="contacts"></param>
        /// <returns>
        /// The updated list of contacts for this group
        /// </returns>
        IQuery<ODataFeed<Contact>> DeleteContacts(Uri url, IEnumerable<Contact> contacts);
    }

    public class GroupsEntity : EntityBase, IGroupsEntity
    {
        public GroupsEntity (IShareFileClient client)
            : base (client, "Groups")
        { }
        
        
        /// <summary>
        /// Get Group List
        /// </summary>
        /// <remarks>
        /// Retrieves all Distribution Groups this user has permissions to View in this account
        /// </remarks>
        /// <returns>
        /// a list of Groups this user has access to
        /// </returns>
        public IQuery<ODataFeed<Group>> Get()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Group>>(Client);
		    sfApiQuery.From("Groups");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Group By ID
        /// </summary>
        /// <remarks>
        /// Retrives a single Group by id
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A single Group object
        /// </returns>
        public IQuery<Group> Get(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Group>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete Group
        /// </summary>
        /// <remarks>
        /// Removes a single Group by id
        /// </remarks>
        /// <param name="url"></param>
        public IQuery Delete(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create Group
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "IsShared":true,
        /// "Contacts":[{"Email":"user.one@domain.com"},{"Email":"user.two@domain.com"}]
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new group. The Post body must include the specification of the group.
        /// </remarks>
        /// <param name="group"></param>
        /// <returns>
        /// the new group instance
        /// </returns>
        public IQuery<Group> Create(Group group)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Group>(Client);
		    sfApiQuery.From("Groups");
            sfApiQuery.Body = group;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update Group
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "IsShared":true,
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing group.
        /// This operation will ignore the provided clients list. Use the \Contacts navigation link to
        /// add/remove elements from a group
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="group"></param>
        /// <returns>
        /// the modified group object
        /// </returns>
        public IQuery<Group> Update(Uri url, Group group)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Group>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.Body = group;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Group Contacts
        /// </summary>
        /// <remarks>
        /// Retrieves the Contacts navigation property of a Group
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A feed of Contacts representing the members of the Group
        /// </returns>
        public IQuery<ODataFeed<Contact>> GetContacts(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.Action("Contacts");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Add Contacts to Group
        /// </summary>
        /// <example>
        /// [{"Email":"user.one@domain.com"},{"Id":"abcd"}]
        /// </example>
        /// <remarks>
        /// Adds a list of contacts to a group
        /// The contact list may contain either contact ID (same as User ID) or Email.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="contacts"></param>
        /// <returns>
        /// The updated list of contacts for this group
        /// </returns>
        public IQuery<ODataFeed<Contact>> CreateContacts(Uri url, IEnumerable<Contact> contacts)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.Action("Contacts");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = contacts;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Remove Contacts from Group
        /// </summary>
        /// <example>
        /// [{"Email":"user.one@domain.com"},{"Id":"abcd"}]
        /// </example>
        /// <remarks>
        /// Removes contacts from a group
        /// The contact list may contain either contact ID (same as User ID) or Email.
        /// This method will ignore missing references in the provided list - i.e., if an email in the contacts
        /// list is not present in the group, it will be ignored.
        /// The method will not enforce that ID and Email match inside a single Contact instance: Id will be
        /// looked up first, then Email.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="contacts"></param>
        /// <returns>
        /// The updated list of contacts for this group
        /// </returns>
        public IQuery<ODataFeed<Contact>> DeleteContacts(Uri url, IEnumerable<Contact> contacts)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.Action("Contacts");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = contacts;
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
    }
}