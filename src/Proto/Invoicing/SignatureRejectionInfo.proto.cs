//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Invoicing/SignatureRejectionInfo.proto
// Note: requires additional types generated from: Invoicing/Signer.proto
namespace Diadoc.Api.Proto.Invoicing
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SignatureRejectionInfo")]
  public partial class SignatureRejectionInfo : global::ProtoBuf.IExtensible
  {
    public SignatureRejectionInfo() {}
    

    private string _ErrorMessage = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ErrorMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ErrorMessage
    {
      get { return _ErrorMessage; }
      set { _ErrorMessage = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Signer _Signer;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Signer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Signer Signer
    {
      get { return _Signer; }
      set { _Signer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}