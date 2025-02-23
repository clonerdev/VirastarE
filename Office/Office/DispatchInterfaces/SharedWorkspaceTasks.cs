﻿using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NetRuntimeSystem = System;

namespace NetOffice.OfficeApi
{
    /// <summary>
    /// DispatchInterface SharedWorkspaceTasks 
    /// SupportByVersion Office, 11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864958.aspx </remarks>
    [SupportByVersion("Office", 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "Item")]
    public class SharedWorkspaceTasks : _IMsoDispObj, IEnumerableProvider<NetOffice.OfficeApi.SharedWorkspaceTask>
    {
#pragma warning disable

        #region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SharedWorkspaceTasks);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <param name="factory">current used factory core</param>
        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="proxyShare">proxy share instead if com proxy</param>
        public SharedWorkspaceTasks(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        public SharedWorkspaceTasks(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
        {
        }

        ///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks(ICOMObject replacedObject) : base(replacedObject)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks() : base()
        {
        }

        /// <param name="progId">registered progID</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public SharedWorkspaceTasks(string progId) : base(progId)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="index">Int32 index</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        public NetOffice.OfficeApi.SharedWorkspaceTask this[Int32 index]
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Item", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, index);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862401.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public Int32 Count
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Count");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862065.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861502.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public bool ItemCountExceeded
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "ItemCountExceeded");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        /// <param name="status">optional object status</param>
        /// <param name="priority">optional object priority</param>
        /// <param name="assignee">optional object assignee</param>
        /// <param name="description">optional object description</param>
        /// <param name="dueDate">optional object dueDate</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee, object description, object dueDate)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, new object[] { title, status, priority, assignee, description, dueDate });
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, title);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        /// <param name="status">optional object status</param>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, title, status);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        /// <param name="status">optional object status</param>
        /// <param name="priority">optional object priority</param>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, title, status, priority);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        /// <param name="status">optional object status</param>
        /// <param name="priority">optional object priority</param>
        /// <param name="assignee">optional object assignee</param>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, title, status, priority, assignee);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865453.aspx </remarks>
        /// <param name="title">string title</param>
        /// <param name="status">optional object status</param>
        /// <param name="priority">optional object priority</param>
        /// <param name="assignee">optional object assignee</param>
        /// <param name="description">optional object description</param>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee, object description)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.SharedWorkspaceTask>(this, "Add", NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType, new object[] { title, status, priority, assignee, description });
        }

        #endregion

        #region IEnumerableProvider<NetOffice.OfficeApi.SharedWorkspaceTask>

        ICOMObject IEnumerableProvider<NetOffice.OfficeApi.SharedWorkspaceTask>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.OfficeApi.SharedWorkspaceTask>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceTask>

        /// <summary>
        /// SupportByVersion Office, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceTask> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.SharedWorkspaceTask item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable 

        /// <summary>
        /// SupportByVersion Office, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
        }

        #endregion

#pragma warning restore
    }
}