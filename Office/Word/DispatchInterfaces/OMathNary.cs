﻿using NetOffice.Attributes;
using System;
using System.ComponentModel;
using NetRuntimeSystem = System;

namespace NetOffice.WordApi
{
    /// <summary>
    /// DispatchInterface OMathNary 
    /// SupportByVersion Word, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835484.aspx </remarks>
    [SupportByVersion("Word", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class OMathNary : COMObject
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
                    _type = typeof(OMathNary);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <param name="factory">current used factory core</param>
        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="proxyShare">proxy share instead if com proxy</param>
        public OMathNary(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        public OMathNary(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
        {
        }

        ///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary(ICOMObject replacedObject) : base(replacedObject)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary() : base()
        {
        }

        /// <param name="progId">registered progID</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public OMathNary(string progId) : base(progId)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845304.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public NetOffice.WordApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Application>(this, "Application", NetOffice.WordApi.Application.LateBindingApiWrapperType);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822141.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public Int32 Creator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195357.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191776.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public NetOffice.WordApi.OMath Sub
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.OMath>(this, "Sub", NetOffice.WordApi.OMath.LateBindingApiWrapperType);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195214.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public NetOffice.WordApi.OMath Sup
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.OMath>(this, "Sup", NetOffice.WordApi.OMath.LateBindingApiWrapperType);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822682.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public NetOffice.WordApi.OMath E
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.OMath>(this, "E", NetOffice.WordApi.OMath.LateBindingApiWrapperType);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194831.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public Int16 Char
        {
            get
            {
                return Factory.ExecuteInt16PropertyGet(this, "Char");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Char", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834573.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public bool Grow
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Grow");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Grow", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821855.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public bool SubSupLim
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "SubSupLim");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SubSupLim", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845267.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public bool HideSub
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "HideSub");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "HideSub", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845172.aspx </remarks>
        [SupportByVersion("Word", 12, 14, 15, 16)]
        public bool HideSup
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "HideSup");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "HideSup", value);
            }
        }

        #endregion

        #region Methods

        #endregion

#pragma warning restore
    }
}
