// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DspUnitParameterStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from DspUnitParameterStatus.proto</summary>
public static partial class DspUnitParameterStatusReflection {

  #region Descriptor
  /// <summary>File descriptor for DspUnitParameterStatus.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DspUnitParameterStatusReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxEc3BVbml0UGFyYW1ldGVyU3RhdHVzLnByb3RvIq4BChZEc3BVbml0UGFy",
          "YW1ldGVyU3RhdHVzEg4KBm5vZGVJZBgBIAIoCRITCgtwYXJhbWV0ZXJJZBgC",
          "IAIoCRIYCg5mbG9hdFBhcmFtZXRlchgDIAEoAkgAEhkKD3N0cmluZ1BhcmFt",
          "ZXRlchgEIAEoCUgAEhkKD3NpbnQzMlBhcmFtZXRlchgFIAEoEUgAEhcKDWJv",
          "b2xQYXJhbWV0ZXIYBiABKAhIAEIGCgR0eXBl"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DspUnitParameterStatus), global::DspUnitParameterStatus.Parser, new[]{ "NodeId", "ParameterId", "FloatParameter", "StringParameter", "Sint32Parameter", "BoolParameter" }, new[]{ "Type" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class DspUnitParameterStatus : pb::IMessage<DspUnitParameterStatus>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<DspUnitParameterStatus> _parser = new pb::MessageParser<DspUnitParameterStatus>(() => new DspUnitParameterStatus());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<DspUnitParameterStatus> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DspUnitParameterStatusReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DspUnitParameterStatus() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DspUnitParameterStatus(DspUnitParameterStatus other) : this() {
    nodeId_ = other.nodeId_;
    parameterId_ = other.parameterId_;
    switch (other.TypeCase) {
      case TypeOneofCase.FloatParameter:
        FloatParameter = other.FloatParameter;
        break;
      case TypeOneofCase.StringParameter:
        StringParameter = other.StringParameter;
        break;
      case TypeOneofCase.Sint32Parameter:
        Sint32Parameter = other.Sint32Parameter;
        break;
      case TypeOneofCase.BoolParameter:
        BoolParameter = other.BoolParameter;
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DspUnitParameterStatus Clone() {
    return new DspUnitParameterStatus(this);
  }

  /// <summary>Field number for the "nodeId" field.</summary>
  public const int NodeIdFieldNumber = 1;
  private readonly static string NodeIdDefaultValue = "";

  private string nodeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string NodeId {
    get { return nodeId_ ?? NodeIdDefaultValue; }
    set {
      nodeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  /// <summary>Gets whether the "nodeId" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasNodeId {
    get { return nodeId_ != null; }
  }
  /// <summary>Clears the value of the "nodeId" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearNodeId() {
    nodeId_ = null;
  }

  /// <summary>Field number for the "parameterId" field.</summary>
  public const int ParameterIdFieldNumber = 2;
  private readonly static string ParameterIdDefaultValue = "";

  private string parameterId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ParameterId {
    get { return parameterId_ ?? ParameterIdDefaultValue; }
    set {
      parameterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  /// <summary>Gets whether the "parameterId" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasParameterId {
    get { return parameterId_ != null; }
  }
  /// <summary>Clears the value of the "parameterId" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearParameterId() {
    parameterId_ = null;
  }

  /// <summary>Field number for the "floatParameter" field.</summary>
  public const int FloatParameterFieldNumber = 3;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float FloatParameter {
    get { return HasFloatParameter ? (float) type_ : 0F; }
    set {
      type_ = value;
      typeCase_ = TypeOneofCase.FloatParameter;
    }
  }
  /// <summary>Gets whether the "floatParameter" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasFloatParameter {
    get { return typeCase_ == TypeOneofCase.FloatParameter; }
  }
  /// <summary> Clears the value of the oneof if it's currently set to "floatParameter" </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearFloatParameter() {
    if (HasFloatParameter) {
      ClearType();
    }
  }

  /// <summary>Field number for the "stringParameter" field.</summary>
  public const int StringParameterFieldNumber = 4;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string StringParameter {
    get { return HasStringParameter ? (string) type_ : ""; }
    set {
      type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      typeCase_ = TypeOneofCase.StringParameter;
    }
  }
  /// <summary>Gets whether the "stringParameter" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasStringParameter {
    get { return typeCase_ == TypeOneofCase.StringParameter; }
  }
  /// <summary> Clears the value of the oneof if it's currently set to "stringParameter" </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearStringParameter() {
    if (HasStringParameter) {
      ClearType();
    }
  }

  /// <summary>Field number for the "sint32Parameter" field.</summary>
  public const int Sint32ParameterFieldNumber = 5;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Sint32Parameter {
    get { return HasSint32Parameter ? (int) type_ : 0; }
    set {
      type_ = value;
      typeCase_ = TypeOneofCase.Sint32Parameter;
    }
  }
  /// <summary>Gets whether the "sint32Parameter" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasSint32Parameter {
    get { return typeCase_ == TypeOneofCase.Sint32Parameter; }
  }
  /// <summary> Clears the value of the oneof if it's currently set to "sint32Parameter" </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearSint32Parameter() {
    if (HasSint32Parameter) {
      ClearType();
    }
  }

  /// <summary>Field number for the "boolParameter" field.</summary>
  public const int BoolParameterFieldNumber = 6;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool BoolParameter {
    get { return HasBoolParameter ? (bool) type_ : false; }
    set {
      type_ = value;
      typeCase_ = TypeOneofCase.BoolParameter;
    }
  }
  /// <summary>Gets whether the "boolParameter" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasBoolParameter {
    get { return typeCase_ == TypeOneofCase.BoolParameter; }
  }
  /// <summary> Clears the value of the oneof if it's currently set to "boolParameter" </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearBoolParameter() {
    if (HasBoolParameter) {
      ClearType();
    }
  }

  private object type_;
  /// <summary>Enum of possible cases for the "type" oneof.</summary>
  public enum TypeOneofCase {
    None = 0,
    FloatParameter = 3,
    StringParameter = 4,
    Sint32Parameter = 5,
    BoolParameter = 6,
  }
  private TypeOneofCase typeCase_ = TypeOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TypeOneofCase TypeCase {
    get { return typeCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearType() {
    typeCase_ = TypeOneofCase.None;
    type_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as DspUnitParameterStatus);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(DspUnitParameterStatus other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (NodeId != other.NodeId) return false;
    if (ParameterId != other.ParameterId) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatParameter, other.FloatParameter)) return false;
    if (StringParameter != other.StringParameter) return false;
    if (Sint32Parameter != other.Sint32Parameter) return false;
    if (BoolParameter != other.BoolParameter) return false;
    if (TypeCase != other.TypeCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (HasNodeId) hash ^= NodeId.GetHashCode();
    if (HasParameterId) hash ^= ParameterId.GetHashCode();
    if (HasFloatParameter) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatParameter);
    if (HasStringParameter) hash ^= StringParameter.GetHashCode();
    if (HasSint32Parameter) hash ^= Sint32Parameter.GetHashCode();
    if (HasBoolParameter) hash ^= BoolParameter.GetHashCode();
    hash ^= (int) typeCase_;
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasNodeId) {
      output.WriteRawTag(10);
      output.WriteString(NodeId);
    }
    if (HasParameterId) {
      output.WriteRawTag(18);
      output.WriteString(ParameterId);
    }
    if (HasFloatParameter) {
      output.WriteRawTag(29);
      output.WriteFloat(FloatParameter);
    }
    if (HasStringParameter) {
      output.WriteRawTag(34);
      output.WriteString(StringParameter);
    }
    if (HasSint32Parameter) {
      output.WriteRawTag(40);
      output.WriteSInt32(Sint32Parameter);
    }
    if (HasBoolParameter) {
      output.WriteRawTag(48);
      output.WriteBool(BoolParameter);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasNodeId) {
      output.WriteRawTag(10);
      output.WriteString(NodeId);
    }
    if (HasParameterId) {
      output.WriteRawTag(18);
      output.WriteString(ParameterId);
    }
    if (HasFloatParameter) {
      output.WriteRawTag(29);
      output.WriteFloat(FloatParameter);
    }
    if (HasStringParameter) {
      output.WriteRawTag(34);
      output.WriteString(StringParameter);
    }
    if (HasSint32Parameter) {
      output.WriteRawTag(40);
      output.WriteSInt32(Sint32Parameter);
    }
    if (HasBoolParameter) {
      output.WriteRawTag(48);
      output.WriteBool(BoolParameter);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (HasNodeId) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeId);
    }
    if (HasParameterId) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ParameterId);
    }
    if (HasFloatParameter) {
      size += 1 + 4;
    }
    if (HasStringParameter) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(StringParameter);
    }
    if (HasSint32Parameter) {
      size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Sint32Parameter);
    }
    if (HasBoolParameter) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(DspUnitParameterStatus other) {
    if (other == null) {
      return;
    }
    if (other.HasNodeId) {
      NodeId = other.NodeId;
    }
    if (other.HasParameterId) {
      ParameterId = other.ParameterId;
    }
    switch (other.TypeCase) {
      case TypeOneofCase.FloatParameter:
        FloatParameter = other.FloatParameter;
        break;
      case TypeOneofCase.StringParameter:
        StringParameter = other.StringParameter;
        break;
      case TypeOneofCase.Sint32Parameter:
        Sint32Parameter = other.Sint32Parameter;
        break;
      case TypeOneofCase.BoolParameter:
        BoolParameter = other.BoolParameter;
        break;
    }

    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          NodeId = input.ReadString();
          break;
        }
        case 18: {
          ParameterId = input.ReadString();
          break;
        }
        case 29: {
          FloatParameter = input.ReadFloat();
          break;
        }
        case 34: {
          StringParameter = input.ReadString();
          break;
        }
        case 40: {
          Sint32Parameter = input.ReadSInt32();
          break;
        }
        case 48: {
          BoolParameter = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          NodeId = input.ReadString();
          break;
        }
        case 18: {
          ParameterId = input.ReadString();
          break;
        }
        case 29: {
          FloatParameter = input.ReadFloat();
          break;
        }
        case 34: {
          StringParameter = input.ReadString();
          break;
        }
        case 40: {
          Sint32Parameter = input.ReadSInt32();
          break;
        }
        case 48: {
          BoolParameter = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
