﻿using NetOffice.Attributes;
using System;
using System.ComponentModel;
using NetRuntimeSystem = System;

namespace NetOffice.OutlookApi
{
    #region Delegates

#pragma warning disable
    public delegate void NavigationGroups_SelectedChangeEventHandler(NetOffice.OutlookApi.NavigationFolder navigationFolder);
    public delegate void NavigationGroups_NavigationFolderAddEventHandler(NetOffice.OutlookApi.NavigationFolder navigationFolder);
    public delegate void NavigationGroups_NavigationFolderRemoveEventHandler();
#pragma warning restore

    #endregion

    /// <summary>
    /// CoClass NavigationGroups 
    /// SupportByVersion Outlook, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860649.aspx </remarks>
    [SupportByVersion("Outlook", 12, 14, 15, 16)]
    [EntityType(EntityType.IsCoClass)]
    [EventSink(typeof(Events.NavigationGroupsEvents_12_SinkHelper))]
    [ComEventInterface(typeof(Events.NavigationGroupsEvents_12))]
    public class NavigationGroups : _NavigationGroups, IEventBinding
    {
#pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;
        private Events.NavigationGroupsEvents_12_SinkHelper _navigationGroupsEvents_12_SinkHelper;

        #endregion

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

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(NavigationGroups);
                return _type;
            }
        }

        #endregion

        #region Construction

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        public NavigationGroups(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public NavigationGroups(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
        {

        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public NavigationGroups(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public NavigationGroups(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public NavigationGroups(ICOMObject replacedObject) : base(replacedObject)
        {

        }

        /// <summary>
        /// Creates a new instance of NavigationGroups 
        /// </summary>		
        public NavigationGroups() : base("Outlook.NavigationGroups")
        {

        }

        /// <summary>
        /// Creates a new instance of NavigationGroups
        /// </summary>
        ///<param name="progId">registered ProgID</param>
        public NavigationGroups(string progId) : base(progId)
        {

        }

        #endregion

        #region Static CoClass Methods
        #endregion

        #region Events

        /// <summary>
        /// SupportByVersion Outlook, 12,14,15,16
        /// </summary>
        private event NavigationGroups_SelectedChangeEventHandler _SelectedChangeEvent;

        /// <summary>
        /// SupportByVersion Outlook 12 14 15,16
        /// </summary>
        ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869729.aspx </remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        public event NavigationGroups_SelectedChangeEventHandler SelectedChangeEvent
        {
            add
            {
                CreateEventBridge();
                _SelectedChangeEvent += value;
            }
            remove
            {
                _SelectedChangeEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion Outlook, 12,14,15,16
        /// </summary>
        private event NavigationGroups_NavigationFolderAddEventHandler _NavigationFolderAddEvent;

        /// <summary>
        /// SupportByVersion Outlook 12 14 15,16
        /// </summary>
        ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868621.aspx </remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        public event NavigationGroups_NavigationFolderAddEventHandler NavigationFolderAddEvent
        {
            add
            {
                CreateEventBridge();
                _NavigationFolderAddEvent += value;
            }
            remove
            {
                _NavigationFolderAddEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion Outlook, 12,14,15,16
        /// </summary>
        private event NavigationGroups_NavigationFolderRemoveEventHandler _NavigationFolderRemoveEvent;

        /// <summary>
        /// SupportByVersion Outlook 12 14 15,16
        /// </summary>
        ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862126.aspx </remarks>
        [SupportByVersion("Outlook", 12, 14, 15, 16)]
        public event NavigationGroups_NavigationFolderRemoveEventHandler NavigationFolderRemoveEvent
        {
            add
            {
                CreateEventBridge();
                _NavigationFolderRemoveEvent += value;
            }
            remove
            {
                _NavigationFolderRemoveEvent -= value;
            }
        }

        #endregion

        #region IEventBinding

        /// <summary>
        /// Creates active sink helper
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void CreateEventBridge()
        {
            if (false == Factory.Settings.EnableEvents)
                return;

            if (null != _connectPoint)
                return;

            if (null == _activeSinkId)
                _activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, Events.NavigationGroupsEvents_12_SinkHelper.Id);


            if (Events.NavigationGroupsEvents_12_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
            {
                _navigationGroupsEvents_12_SinkHelper = new Events.NavigationGroupsEvents_12_SinkHelper(this, _connectPoint);
                return;
            }
        }

        /// <summary>
        /// The instance use currently an event listener 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
        {
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
        }
        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
            if (null != _navigationGroupsEvents_12_SinkHelper)
            {
                _navigationGroupsEvents_12_SinkHelper.Dispose();
                _navigationGroupsEvents_12_SinkHelper = null;
            }

            _connectPoint = null;
        }

        #endregion

#pragma warning restore
    }
}

