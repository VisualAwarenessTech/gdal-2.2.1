/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.GDAL {

using System;
using System.Runtime.InteropServices;

public class XMLNode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public XMLNode(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(XMLNode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(XMLNode obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(XMLNode obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~XMLNode() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        GdalPINVOKE.delete_XMLNode(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public XMLNodeType Type {
    get {
      XMLNodeType ret = (XMLNodeType)GdalPINVOKE.XMLNode_Type_get(swigCPtr);
      if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string Value {
    get {
      string ret = GdalPINVOKE.XMLNode_Value_get(swigCPtr);
      if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public XMLNode Next {
    get {
      IntPtr cPtr = GdalPINVOKE.XMLNode_Next_get(swigCPtr);
      XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, ThisOwn_false());
      if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public XMLNode Child {
    get {
      IntPtr cPtr = GdalPINVOKE.XMLNode_Child_get(swigCPtr);
      XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, ThisOwn_false());
      if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public XMLNode(string pszString) : this(GdalPINVOKE.new_XMLNode__SWIG_0(pszString), true, null) {
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public XMLNode(XMLNodeType eType, string pszText) : this(GdalPINVOKE.new_XMLNode__SWIG_1((int)eType, pszText), true, null) {
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public string SerializeXMLTree() {
    string ret = GdalPINVOKE.XMLNode_SerializeXMLTree(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string toString() {
    string ret = GdalPINVOKE.XMLNode_toString(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XMLNode SearchXMLNode(string pszElement) {
    IntPtr cPtr = GdalPINVOKE.XMLNode_SearchXMLNode(swigCPtr, pszElement);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, ThisOwn_false());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XMLNode GetXMLNode(string pszPath) {
    IntPtr cPtr = GdalPINVOKE.XMLNode_GetXMLNode(swigCPtr, pszPath);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, ThisOwn_false());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetXMLValue(string pszPath, string pszDefault) {
    string ret = GdalPINVOKE.XMLNode_GetXMLValue(swigCPtr, pszPath, pszDefault);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddXMLChild(XMLNode psChild) {
    GdalPINVOKE.XMLNode_AddXMLChild(swigCPtr, XMLNode.getCPtr(psChild));
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public int RemoveXMLChild(XMLNode psChild) {
    int ret = GdalPINVOKE.XMLNode_RemoveXMLChild(swigCPtr, XMLNode.getCPtr(psChild));
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddXMLSibling(XMLNode psNewSibling) {
    GdalPINVOKE.XMLNode_AddXMLSibling(swigCPtr, XMLNode.getCPtr(psNewSibling));
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public XMLNode CreateXMLElementAndValue(string pszName, string pszValue) {
    IntPtr cPtr = GdalPINVOKE.XMLNode_CreateXMLElementAndValue(swigCPtr, pszName, pszValue);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, ThisOwn_false());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XMLNode CloneXMLTree(XMLNode psTree) {
    IntPtr cPtr = GdalPINVOKE.XMLNode_CloneXMLTree(swigCPtr, XMLNode.getCPtr(psTree));
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true, ThisOwn_true());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XMLNode Clone() {
    IntPtr cPtr = GdalPINVOKE.XMLNode_Clone(swigCPtr);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true, ThisOwn_true());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetXMLValue(string pszPath, string pszValue) {
    int ret = GdalPINVOKE.XMLNode_SetXMLValue(swigCPtr, pszPath, pszValue);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void StripXMLNamespace(string pszNamespace, int bRecurse) {
    GdalPINVOKE.XMLNode_StripXMLNamespace(swigCPtr, pszNamespace, bRecurse);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
