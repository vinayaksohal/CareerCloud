// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobEducation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.Grpc.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJobEducation.proto</summary>
  public static partial class CompanyJobEducationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJobEducation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobEducationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm90b3MvQ29tcGFueUpvYkVkdWNhdGlvbi5wcm90bxofZ29vZ2xlL3By",
            "b3RvYnVmL3RpbWVzdGFtcC5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBw",
            "ZXJzLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8iVQoUQ29t",
            "cGFueUpvYkVkdWNhdGlvbnMSPQoaQ29tcGFueUpvYkVkdWNhdGlvblJlcGxp",
            "ZXMYASADKAsyGS5Db21wYW55Sm9iRWR1Y2F0aW9uUmVwbHkiGAoKSWRSZXF1",
            "ZXN0NRIKCgJJZBgBIAEoCSJWChhDb21wYW55Sm9iRWR1Y2F0aW9uUmVwbHkS",
            "CgoCSWQYASABKAkSCwoDSm9iGAIgASgJEg0KBU1ham9yGAMgASgJEhIKCklt",
            "cG9ydGFuY2UYBCABKAUyjgMKE0NvbXBhbnlKb2JFZHVjYXRpb24SQAoWR2V0",
            "Q29tcGFueUpvYkVkdWNhdGlvbhILLklkUmVxdWVzdDUaGS5Db21wYW55Sm9i",
            "RWR1Y2F0aW9uUmVwbHkSSAoXR2V0Q29tcGFueUpvYkVkdWNhdGlvbnMSFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkaFS5Db21wYW55Sm9iRWR1Y2F0aW9ucxJL",
            "ChpBZGRHZXRDb21wYW55Sm9iRWR1Y2F0aW9ucxIVLkNvbXBhbnlKb2JFZHVj",
            "YXRpb25zGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5Ek4KHVVwZGF0ZUdldENv",
            "bXBhbnlKb2JFZHVjYXRpb25zEhUuQ29tcGFueUpvYkVkdWNhdGlvbnMaFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkSTgodRGVsZXRlR2V0Q29tcGFueUpvYkVk",
            "dWNhdGlvbnMSFS5Db21wYW55Sm9iRWR1Y2F0aW9ucxoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuR3JwYy5Qcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.CompanyJobEducations), global::CareerCloud.Grpc.Protos.CompanyJobEducations.Parser, new[]{ "CompanyJobEducationReplies" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.IdRequest5), global::CareerCloud.Grpc.Protos.IdRequest5.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.CompanyJobEducationReply), global::CareerCloud.Grpc.Protos.CompanyJobEducationReply.Parser, new[]{ "Id", "Job", "Major", "Importance" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompanyJobEducations : pb::IMessage<CompanyJobEducations> {
    private static readonly pb::MessageParser<CompanyJobEducations> _parser = new pb::MessageParser<CompanyJobEducations>(() => new CompanyJobEducations());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobEducations> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations(CompanyJobEducations other) : this() {
      companyJobEducationReplies_ = other.companyJobEducationReplies_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations Clone() {
      return new CompanyJobEducations(this);
    }

    /// <summary>Field number for the "CompanyJobEducationReplies" field.</summary>
    public const int CompanyJobEducationRepliesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.Grpc.Protos.CompanyJobEducationReply> _repeated_companyJobEducationReplies_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.Grpc.Protos.CompanyJobEducationReply.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.Grpc.Protos.CompanyJobEducationReply> companyJobEducationReplies_ = new pbc::RepeatedField<global::CareerCloud.Grpc.Protos.CompanyJobEducationReply>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.Grpc.Protos.CompanyJobEducationReply> CompanyJobEducationReplies {
      get { return companyJobEducationReplies_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobEducations);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobEducations other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!companyJobEducationReplies_.Equals(other.companyJobEducationReplies_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= companyJobEducationReplies_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      companyJobEducationReplies_.WriteTo(output, _repeated_companyJobEducationReplies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += companyJobEducationReplies_.CalculateSize(_repeated_companyJobEducationReplies_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobEducations other) {
      if (other == null) {
        return;
      }
      companyJobEducationReplies_.Add(other.companyJobEducationReplies_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            companyJobEducationReplies_.AddEntriesFrom(input, _repeated_companyJobEducationReplies_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class IdRequest5 : pb::IMessage<IdRequest5> {
    private static readonly pb::MessageParser<IdRequest5> _parser = new pb::MessageParser<IdRequest5>(() => new IdRequest5());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequest5> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5(IdRequest5 other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5 Clone() {
      return new IdRequest5(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdRequest5);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequest5 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdRequest5 other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyJobEducationReply : pb::IMessage<CompanyJobEducationReply> {
    private static readonly pb::MessageParser<CompanyJobEducationReply> _parser = new pb::MessageParser<CompanyJobEducationReply>(() => new CompanyJobEducationReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobEducationReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducationReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducationReply(CompanyJobEducationReply other) : this() {
      id_ = other.id_;
      job_ = other.job_;
      major_ = other.major_;
      importance_ = other.importance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducationReply Clone() {
      return new CompanyJobEducationReply(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 2;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Major" field.</summary>
    public const int MajorFieldNumber = 3;
    private string major_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Major {
      get { return major_; }
      set {
        major_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Importance" field.</summary>
    public const int ImportanceFieldNumber = 4;
    private int importance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Importance {
      get { return importance_; }
      set {
        importance_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobEducationReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobEducationReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Job != other.Job) return false;
      if (Major != other.Major) return false;
      if (Importance != other.Importance) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (Major.Length != 0) hash ^= Major.GetHashCode();
      if (Importance != 0) hash ^= Importance.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Job);
      }
      if (Major.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Major);
      }
      if (Importance != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Importance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (Major.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Major);
      }
      if (Importance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Importance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobEducationReply other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.Major.Length != 0) {
        Major = other.Major;
      }
      if (other.Importance != 0) {
        Importance = other.Importance;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Job = input.ReadString();
            break;
          }
          case 26: {
            Major = input.ReadString();
            break;
          }
          case 32: {
            Importance = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
