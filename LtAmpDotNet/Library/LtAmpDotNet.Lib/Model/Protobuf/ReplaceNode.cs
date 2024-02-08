// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReplaceNode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LtAmpDotNet.Lib.Models.Protobuf {

  /// <summary>Holder for reflection information generated from ReplaceNode.proto</summary>
  public static partial class ReplaceNodeReflection {

    #region Descriptor
    /// <summary>File descriptor for ReplaceNode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReplaceNodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSZXBsYWNlTm9kZS5wcm90byJFCgtSZXBsYWNlTm9kZRIXCg9ub2RlSWRU",
            "b1JlcGxhY2UYASACKAkSHQoVZmVuZGVySWRUb1JlcGxhY2VXaXRoGAIgAigJ",
            "QiKqAh9MdEFtcERvdE5ldC5MaWIuTW9kZWxzLlByb3RvYnVm"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LtAmpDotNet.Lib.Models.Protobuf.ReplaceNode), global::LtAmpDotNet.Lib.Models.Protobuf.ReplaceNode.Parser, new[]{ "NodeIdToReplace", "FenderIdToReplaceWith" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// Swaps out a node (amp, stomp, mod, delay, or reverb)
  ///
  /// response: ReplaceNodeStatus message
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ReplaceNode : pb::IMessage<ReplaceNode>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReplaceNode> _parser = new pb::MessageParser<ReplaceNode>(() => new ReplaceNode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReplaceNode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LtAmpDotNet.Lib.Models.Protobuf.ReplaceNodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceNode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceNode(ReplaceNode other) : this() {
      nodeIdToReplace_ = other.nodeIdToReplace_;
      fenderIdToReplaceWith_ = other.fenderIdToReplaceWith_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceNode Clone() {
      return new ReplaceNode(this);
    }

    /// <summary>Field number for the "nodeIdToReplace" field.</summary>
    public const int NodeIdToReplaceFieldNumber = 1;
    private readonly static string NodeIdToReplaceDefaultValue = "";

    private string nodeIdToReplace_;
    /// <summary>
    /// node to replace (amp, stomp, mod, delay, or reverb)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NodeIdToReplace {
      get { return nodeIdToReplace_ ?? NodeIdToReplaceDefaultValue; }
      set {
        nodeIdToReplace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "nodeIdToReplace" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNodeIdToReplace {
      get { return nodeIdToReplace_ != null; }
    }
    /// <summary>Clears the value of the "nodeIdToReplace" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNodeIdToReplace() {
      nodeIdToReplace_ = null;
    }

    /// <summary>Field number for the "fenderIdToReplaceWith" field.</summary>
    public const int FenderIdToReplaceWithFieldNumber = 2;
    private readonly static string FenderIdToReplaceWithDefaultValue = "";

    private string fenderIdToReplaceWith_;
    /// <summary>
    /// FenderId of node to set
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FenderIdToReplaceWith {
      get { return fenderIdToReplaceWith_ ?? FenderIdToReplaceWithDefaultValue; }
      set {
        fenderIdToReplaceWith_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "fenderIdToReplaceWith" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFenderIdToReplaceWith {
      get { return fenderIdToReplaceWith_ != null; }
    }
    /// <summary>Clears the value of the "fenderIdToReplaceWith" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFenderIdToReplaceWith() {
      fenderIdToReplaceWith_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReplaceNode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReplaceNode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NodeIdToReplace != other.NodeIdToReplace) return false;
      if (FenderIdToReplaceWith != other.FenderIdToReplaceWith) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasNodeIdToReplace) hash ^= NodeIdToReplace.GetHashCode();
      if (HasFenderIdToReplaceWith) hash ^= FenderIdToReplaceWith.GetHashCode();
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
      if (HasNodeIdToReplace) {
        output.WriteRawTag(10);
        output.WriteString(NodeIdToReplace);
      }
      if (HasFenderIdToReplaceWith) {
        output.WriteRawTag(18);
        output.WriteString(FenderIdToReplaceWith);
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
      if (HasNodeIdToReplace) {
        output.WriteRawTag(10);
        output.WriteString(NodeIdToReplace);
      }
      if (HasFenderIdToReplaceWith) {
        output.WriteRawTag(18);
        output.WriteString(FenderIdToReplaceWith);
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
      if (HasNodeIdToReplace) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeIdToReplace);
      }
      if (HasFenderIdToReplaceWith) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FenderIdToReplaceWith);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReplaceNode other) {
      if (other == null) {
        return;
      }
      if (other.HasNodeIdToReplace) {
        NodeIdToReplace = other.NodeIdToReplace;
      }
      if (other.HasFenderIdToReplaceWith) {
        FenderIdToReplaceWith = other.FenderIdToReplaceWith;
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
            NodeIdToReplace = input.ReadString();
            break;
          }
          case 18: {
            FenderIdToReplaceWith = input.ReadString();
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
            NodeIdToReplace = input.ReadString();
            break;
          }
          case 18: {
            FenderIdToReplaceWith = input.ReadString();
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
