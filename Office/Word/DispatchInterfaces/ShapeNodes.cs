﻿using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NetRuntimeSystem = System;

namespace NetOffice.WordApi
{
    /// <summary>
    /// DispatchInterface ShapeNodes 
    /// SupportByVersion Word, 9,10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840439.aspx </remarks>
    [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
    public class ShapeNodes : COMObject, IEnumerableProvider<NetOffice.WordApi.ShapeNode>
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
                    _type = typeof(ShapeNodes);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <param name="factory">current used factory core</param>
        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="proxyShare">proxy share instead if com proxy</param>
        public ShapeNodes(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        public ShapeNodes(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
        {
        }

        ///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes(ICOMObject replacedObject) : base(replacedObject)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes() : base()
        {
        }

        /// <param name="progId">registered progID</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ShapeNodes(string progId) : base(progId)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192144.aspx </remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.WordApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Application>(this, "Application", NetOffice.WordApi.Application.LateBindingApiWrapperType);
            }
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191955.aspx </remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 Creator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193861.aspx </remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844838.aspx </remarks>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 Count
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Count");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191962.aspx </remarks>
        /// <param name="index">Int32 index</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Delete(Int32 index)
        {
            Factory.ExecuteMethod(this, "Delete", index);
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        public NetOffice.WordApi.ShapeNode this[object index]
        {
            get
            {
                return Factory.ExecuteKnownReferenceMethodGet<NetOffice.WordApi.ShapeNode>(this, "Item", NetOffice.WordApi.ShapeNode.LateBindingApiWrapperType, index);
            }
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193122.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void SetEditingType(Int32 index, NetOffice.OfficeApi.Enums.MsoEditingType editingType)
        {
            Factory.ExecuteMethod(this, "SetEditingType", index, editingType);
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845116.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void SetPosition(Int32 index, Single x1, Single y1)
        {
            Factory.ExecuteMethod(this, "SetPosition", index, x1, y1);
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822696.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void SetSegmentType(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType)
        {
            Factory.ExecuteMethod(this, "SetSegmentType", index, segmentType);
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        /// <param name="x2">optional Single X2 = 0</param>
        /// <param name="y2">optional Single Y2 = 0</param>
        /// <param name="x3">optional Single X3 = 0</param>
        /// <param name="y3">optional Single Y3 = 0</param>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3, object y3)
        {
            Factory.ExecuteMethod(this, "Insert", new object[] { index, segmentType, editingType, x1, y1, x2, y2, x3, y3 });
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        [CustomMethod]
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
        {
            Factory.ExecuteMethod(this, "Insert", new object[] { index, segmentType, editingType, x1, y1 });
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        /// <param name="x2">optional Single X2 = 0</param>
        [CustomMethod]
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2)
        {
            Factory.ExecuteMethod(this, "Insert", new object[] { index, segmentType, editingType, x1, y1, x2 });
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        /// <param name="x2">optional Single X2 = 0</param>
        /// <param name="y2">optional Single Y2 = 0</param>
        [CustomMethod]
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2)
        {
            Factory.ExecuteMethod(this, "Insert", new object[] { index, segmentType, editingType, x1, y1, x2, y2 });
        }

        /// <summary>
        /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
        /// <param name="index">Int32 index</param>
        /// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType segmentType</param>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        /// <param name="x2">optional Single X2 = 0</param>
        /// <param name="y2">optional Single Y2 = 0</param>
        /// <param name="x3">optional Single X3 = 0</param>
        [CustomMethod]
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3)
        {
            Factory.ExecuteMethod(this, "Insert", new object[] { index, segmentType, editingType, x1, y1, x2, y2, x3 });
        }

        #endregion

        #region IEnumerableProvider<NetOffice.WordApi.ShapeNode>

        ICOMObject IEnumerableProvider<NetOffice.WordApi.ShapeNode>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.WordApi.ShapeNode>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.WordApi.ShapeNode>

        /// <summary>
        /// SupportByVersion Word, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.WordApi.ShapeNode> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.WordApi.ShapeNode item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Word, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
        }

        #endregion

#pragma warning restore
    }
}