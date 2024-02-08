// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShiftPresetStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LtAmpDotNet.Lib.Models.Protobuf {

  /// <summary>Holder for reflection information generated from ShiftPresetStatus.proto</summary>
  public static partial class ShiftPresetStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for ShiftPresetStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShiftPresetStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTaGlmdFByZXNldFN0YXR1cy5wcm90byJFChFTaGlmdFByZXNldFN0YXR1",
            "cxIYChBpbmRleFRvU2hpZnRGcm9tGAEgAigFEhYKDmluZGV4VG9TaGlmdFRv",
            "GAIgAigFQiKqAh9MdEFtcERvdE5ldC5MaWIuTW9kZWxzLlByb3RvYnVm"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LtAmpDotNet.Lib.Models.Protobuf.ShiftPresetStatus), global::LtAmpDotNet.Lib.Models.Protobuf.ShiftPresetStatus.Parser, new[]{ "IndexToShiftFrom", "IndexToShiftTo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// Response to a ShiftPreset message with the status of the command
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ShiftPresetStatus : pb::IMessage<ShiftPresetStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShiftPresetStatus> _parser = new pb::MessageParser<ShiftPresetStatus>(() => new ShiftPresetStatus());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShiftPresetStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LtAmpDotNet.Lib.Models.Protobuf.ShiftPresetStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShiftPresetStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShiftPresetStatus(ShiftPresetStatus other) : this() {
      _hasBits0 = other._hasBits0;
      indexToShiftFrom_ = other.indexToShiftFrom_;
      indexToShiftTo_ = other.indexToShiftTo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShiftPresetStatus Clone() {
      return new ShiftPresetStatus(this);
    }

    /// <summary>Field number for the "indexToShiftFrom" field.</summary>
    public const int IndexToShiftFromFieldNumber = 1;
    private readonly static int IndexToShiftFromDefaultValue = 0;

    private int indexToShiftFrom_;
    /// <summary>
    /// Preset shifted
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IndexToShiftFrom {
      get { if ((_hasBits0 & 1) != 0) { return indexToShiftFrom_; } else { return IndexToShiftFromDefaultValue; } }
      set {
        _hasBits0 |= 1;
        indexToShiftFrom_ = value;
      }
    }
    /// <summary>Gets whether the "indexToShiftFrom" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasIndexToShiftFrom {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "indexToShiftFrom" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIndexToShiftFrom() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "indexToShiftTo" field.</summary>
    public const int IndexToShiftToFieldNumber = 2;
    private readonly static int IndexToShiftToDefaultValue = 0;

    private int indexToShiftTo_;
    /// <summary>
    /// Destination
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IndexToShiftTo {
      get { if ((_hasBits0 & 2) != 0) { return indexToShiftTo_; } else { return IndexToShiftToDefaultValue; } }
      set {
        _hasBits0 |= 2;
        indexToShiftTo_ = value;
      }
    }
    /// <summary>Gets whether the "indexToShiftTo" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasIndexToShiftTo {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "indexToShiftTo" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIndexToShiftTo() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ShiftPresetStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShiftPresetStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IndexToShiftFrom != other.IndexToShiftFrom) return false;
      if (IndexToShiftTo != other.IndexToShiftTo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasIndexToShiftFrom) hash ^= IndexToShiftFrom.GetHashCode();
      if (HasIndexToShiftTo) hash ^= IndexToShiftTo.GetHashCode();
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
      if (HasIndexToShiftFrom) {
        output.WriteRawTag(8);
        output.WriteInt32(IndexToShiftFrom);
      }
      if (HasIndexToShiftTo) {
        output.WriteRawTag(16);
        output.WriteInt32(IndexToShiftTo);
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
      if (HasIndexToShiftFrom) {
        output.WriteRawTag(8);
        output.WriteInt32(IndexToShiftFrom);
      }
      if (HasIndexToShiftTo) {
        output.WriteRawTag(16);
        output.WriteInt32(IndexToShiftTo);
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
      if (HasIndexToShiftFrom) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IndexToShiftFrom);
      }
      if (HasIndexToShiftTo) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IndexToShiftTo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ShiftPresetStatus other) {
      if (other == null) {
        return;
      }
      if (other.HasIndexToShiftFrom) {
        IndexToShiftFrom = other.IndexToShiftFrom;
      }
      if (other.HasIndexToShiftTo) {
        IndexToShiftTo = other.IndexToShiftTo;
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
          case 8: {
            IndexToShiftFrom = input.ReadInt32();
            break;
          }
          case 16: {
            IndexToShiftTo = input.ReadInt32();
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
          case 8: {
            IndexToShiftFrom = input.ReadInt32();
            break;
          }
          case 16: {
            IndexToShiftTo = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
