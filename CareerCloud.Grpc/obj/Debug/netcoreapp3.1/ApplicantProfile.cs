// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantProfile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.Grpc.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantProfile.proto</summary>
  public static partial class ApplicantProfileReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantProfile.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantProfileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90b3MvQXBwbGljYW50UHJvZmlsZS5wcm90bxILY3VzdG9tVHlwZXMa",
            "H2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aHmdvb2dsZS9wcm90",
            "b2J1Zi93cmFwcGVycy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
            "b3RvGhRQcm90b3MvRGVjaW1hbC5wcm90byJYChFBcHBsaWNhbnRQcm9maWxl",
            "cxJDChdBcHBsaWNhbnRQcm9maWxlUmVwbGllcxgBIAMoCzIiLmN1c3RvbVR5",
            "cGVzLkFwcGxpY2FudFByb2ZpbGVSZXBseSIYCgpJZFJlcXVlc3QyEgoKAklk",
            "GAEgASgJIvsBChVBcHBsaWNhbnRQcm9maWxlUmVwbHkSCgoCSWQYASABKAkS",
            "DQoFTG9naW4YAiABKAkSMAoNQ3VycmVudFNhbGFyeRgDIAEoCzIZLmN1c3Rv",
            "bVR5cGVzLkRlY2ltYWxWYWx1ZRIuCgtDdXJyZW50UmF0ZRgEIAEoCzIZLmN1",
            "c3RvbVR5cGVzLkRlY2ltYWxWYWx1ZRIQCghDdXJyZW5jeRgFIAEoCRIPCgdD",
            "b3VudHJ5GAYgASgJEhAKCFByb3ZpbmNlGAcgASgJEg4KBlN0cmVldBgIIAEo",
            "CRIMCgRDaXR5GAkgASgJEhIKClBvc3RhbENvZGUYCiABKAkytQMKEEFwcGxp",
            "Y2FudFByb2ZpbGUSUgoTR2V0QXBwbGljYW50UHJvZmlsZRIXLmN1c3RvbVR5",
            "cGVzLklkUmVxdWVzdDIaIi5jdXN0b21UeXBlcy5BcHBsaWNhbnRQcm9maWxl",
            "UmVwbHkSTgoUR2V0QXBwbGljYW50UHJvZmlsZXMSFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaHi5jdXN0b21UeXBlcy5BcHBsaWNhbnRQcm9maWxlcxJRChdB",
            "ZGRHZXRBcHBsaWNhbnRQcm9maWxlcxIeLmN1c3RvbVR5cGVzLkFwcGxpY2Fu",
            "dFByb2ZpbGVzGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElQKGlVwZGF0ZUdl",
            "dEFwcGxpY2FudFByb2ZpbGVzEh4uY3VzdG9tVHlwZXMuQXBwbGljYW50UHJv",
            "ZmlsZXMaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSVAoaRGVsZXRlR2V0QXBw",
            "bGljYW50UHJvZmlsZXMSHi5jdXN0b21UeXBlcy5BcHBsaWNhbnRQcm9maWxl",
            "cxoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIXQ2FyZWVyQ2xvdWQuR3Jw",
            "Yy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::CareerCloud.Grpc.Protos.DecimalReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.ApplicantProfiles), global::CareerCloud.Grpc.Protos.ApplicantProfiles.Parser, new[]{ "ApplicantProfileReplies" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.IdRequest2), global::CareerCloud.Grpc.Protos.IdRequest2.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.Grpc.Protos.ApplicantProfileReply), global::CareerCloud.Grpc.Protos.ApplicantProfileReply.Parser, new[]{ "Id", "Login", "CurrentSalary", "CurrentRate", "Currency", "Country", "Province", "Street", "City", "PostalCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ApplicantProfiles : pb::IMessage<ApplicantProfiles> {
    private static readonly pb::MessageParser<ApplicantProfiles> _parser = new pb::MessageParser<ApplicantProfiles>(() => new ApplicantProfiles());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantProfiles> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.ApplicantProfileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfiles() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfiles(ApplicantProfiles other) : this() {
      applicantProfileReplies_ = other.applicantProfileReplies_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfiles Clone() {
      return new ApplicantProfiles(this);
    }

    /// <summary>Field number for the "ApplicantProfileReplies" field.</summary>
    public const int ApplicantProfileRepliesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.Grpc.Protos.ApplicantProfileReply> _repeated_applicantProfileReplies_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.Grpc.Protos.ApplicantProfileReply.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.Grpc.Protos.ApplicantProfileReply> applicantProfileReplies_ = new pbc::RepeatedField<global::CareerCloud.Grpc.Protos.ApplicantProfileReply>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.Grpc.Protos.ApplicantProfileReply> ApplicantProfileReplies {
      get { return applicantProfileReplies_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantProfiles);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantProfiles other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!applicantProfileReplies_.Equals(other.applicantProfileReplies_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= applicantProfileReplies_.GetHashCode();
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
      applicantProfileReplies_.WriteTo(output, _repeated_applicantProfileReplies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += applicantProfileReplies_.CalculateSize(_repeated_applicantProfileReplies_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantProfiles other) {
      if (other == null) {
        return;
      }
      applicantProfileReplies_.Add(other.applicantProfileReplies_);
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
            applicantProfileReplies_.AddEntriesFrom(input, _repeated_applicantProfileReplies_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class IdRequest2 : pb::IMessage<IdRequest2> {
    private static readonly pb::MessageParser<IdRequest2> _parser = new pb::MessageParser<IdRequest2>(() => new IdRequest2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequest2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.ApplicantProfileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest2(IdRequest2 other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest2 Clone() {
      return new IdRequest2(this);
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
      return Equals(other as IdRequest2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequest2 other) {
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
    public void MergeFrom(IdRequest2 other) {
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

  public sealed partial class ApplicantProfileReply : pb::IMessage<ApplicantProfileReply> {
    private static readonly pb::MessageParser<ApplicantProfileReply> _parser = new pb::MessageParser<ApplicantProfileReply>(() => new ApplicantProfileReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantProfileReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.Grpc.Protos.ApplicantProfileReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileReply(ApplicantProfileReply other) : this() {
      id_ = other.id_;
      login_ = other.login_;
      currentSalary_ = other.currentSalary_ != null ? other.currentSalary_.Clone() : null;
      currentRate_ = other.currentRate_ != null ? other.currentRate_.Clone() : null;
      currency_ = other.currency_;
      country_ = other.country_;
      province_ = other.province_;
      street_ = other.street_;
      city_ = other.city_;
      postalCode_ = other.postalCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantProfileReply Clone() {
      return new ApplicantProfileReply(this);
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

    /// <summary>Field number for the "Login" field.</summary>
    public const int LoginFieldNumber = 2;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CurrentSalary" field.</summary>
    public const int CurrentSalaryFieldNumber = 3;
    private global::CareerCloud.Grpc.Protos.DecimalValue currentSalary_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CareerCloud.Grpc.Protos.DecimalValue CurrentSalary {
      get { return currentSalary_; }
      set {
        currentSalary_ = value;
      }
    }

    /// <summary>Field number for the "CurrentRate" field.</summary>
    public const int CurrentRateFieldNumber = 4;
    private global::CareerCloud.Grpc.Protos.DecimalValue currentRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CareerCloud.Grpc.Protos.DecimalValue CurrentRate {
      get { return currentRate_; }
      set {
        currentRate_ = value;
      }
    }

    /// <summary>Field number for the "Currency" field.</summary>
    public const int CurrencyFieldNumber = 5;
    private string currency_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Currency {
      get { return currency_; }
      set {
        currency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 6;
    private string country_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Country {
      get { return country_; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Province" field.</summary>
    public const int ProvinceFieldNumber = 7;
    private string province_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Province {
      get { return province_; }
      set {
        province_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Street" field.</summary>
    public const int StreetFieldNumber = 8;
    private string street_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Street {
      get { return street_; }
      set {
        street_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "City" field.</summary>
    public const int CityFieldNumber = 9;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PostalCode" field.</summary>
    public const int PostalCodeFieldNumber = 10;
    private string postalCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantProfileReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantProfileReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Login != other.Login) return false;
      if (!object.Equals(CurrentSalary, other.CurrentSalary)) return false;
      if (!object.Equals(CurrentRate, other.CurrentRate)) return false;
      if (Currency != other.Currency) return false;
      if (Country != other.Country) return false;
      if (Province != other.Province) return false;
      if (Street != other.Street) return false;
      if (City != other.City) return false;
      if (PostalCode != other.PostalCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (currentSalary_ != null) hash ^= CurrentSalary.GetHashCode();
      if (currentRate_ != null) hash ^= CurrentRate.GetHashCode();
      if (Currency.Length != 0) hash ^= Currency.GetHashCode();
      if (Country.Length != 0) hash ^= Country.GetHashCode();
      if (Province.Length != 0) hash ^= Province.GetHashCode();
      if (Street.Length != 0) hash ^= Street.GetHashCode();
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (PostalCode.Length != 0) hash ^= PostalCode.GetHashCode();
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
      if (Login.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Login);
      }
      if (currentSalary_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CurrentSalary);
      }
      if (currentRate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CurrentRate);
      }
      if (Currency.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Currency);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Country);
      }
      if (Province.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Province);
      }
      if (Street.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Street);
      }
      if (City.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(City);
      }
      if (PostalCode.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(PostalCode);
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
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (currentSalary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentSalary);
      }
      if (currentRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentRate);
      }
      if (Currency.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Currency);
      }
      if (Country.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (Province.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Province);
      }
      if (Street.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Street);
      }
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (PostalCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostalCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantProfileReply other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.currentSalary_ != null) {
        if (currentSalary_ == null) {
          CurrentSalary = new global::CareerCloud.Grpc.Protos.DecimalValue();
        }
        CurrentSalary.MergeFrom(other.CurrentSalary);
      }
      if (other.currentRate_ != null) {
        if (currentRate_ == null) {
          CurrentRate = new global::CareerCloud.Grpc.Protos.DecimalValue();
        }
        CurrentRate.MergeFrom(other.CurrentRate);
      }
      if (other.Currency.Length != 0) {
        Currency = other.Currency;
      }
      if (other.Country.Length != 0) {
        Country = other.Country;
      }
      if (other.Province.Length != 0) {
        Province = other.Province;
      }
      if (other.Street.Length != 0) {
        Street = other.Street;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.PostalCode.Length != 0) {
        PostalCode = other.PostalCode;
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
            Login = input.ReadString();
            break;
          }
          case 26: {
            if (currentSalary_ == null) {
              CurrentSalary = new global::CareerCloud.Grpc.Protos.DecimalValue();
            }
            input.ReadMessage(CurrentSalary);
            break;
          }
          case 34: {
            if (currentRate_ == null) {
              CurrentRate = new global::CareerCloud.Grpc.Protos.DecimalValue();
            }
            input.ReadMessage(CurrentRate);
            break;
          }
          case 42: {
            Currency = input.ReadString();
            break;
          }
          case 50: {
            Country = input.ReadString();
            break;
          }
          case 58: {
            Province = input.ReadString();
            break;
          }
          case 66: {
            Street = input.ReadString();
            break;
          }
          case 74: {
            City = input.ReadString();
            break;
          }
          case 82: {
            PostalCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
