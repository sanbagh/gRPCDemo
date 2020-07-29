// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: greeting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Greet {

  /// <summary>Holder for reflection information generated from greeting.proto</summary>
  public static partial class GreetingReflection {

    #region Descriptor
    /// <summary>File descriptor for greeting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5ncmVldGluZy5wcm90bxIFZ3JlZXQiLwoIR3JlZXRpbmcSEQoJZmlyc3Ru",
            "YW1lGAEgASgJEhAKCGxhc3RuYW1lGAIgASgJIjMKD0dyZWV0aW5nUmVxdWVz",
            "dBIgCgdyZXF1ZXN0GAEgASgLMg8uZ3JlZXQuR3JlZXRpbmciJAoQR3JlZXRp",
            "bmdSZXNwb25zZRIQCghyZXNwb25zZRgBIAEoCSI8ChhHcmVldGluZ01hbnlU",
            "aW1lc1JlcXVlc3QSIAoHcmVxdWVzdBgBIAEoCzIPLmdyZWV0LkdyZWV0aW5n",
            "Ii0KGUdyZWV0aW5nTWFueVRpbWVzUmVzcG9uc2USEAoIcmVzcG9uc2UYASAB",
            "KAkyqgEKD0dyZWV0aW5nU2VydmljZRI+CglHcmVldEZ1bmMSFi5ncmVldC5H",
            "cmVldGluZ1JlcXVlc3QaFy5ncmVldC5HcmVldGluZ1Jlc3BvbnNlIgASVwoO",
            "R3JlZXRNYW55VGltZXMSHy5ncmVldC5HcmVldGluZ01hbnlUaW1lc1JlcXVl",
            "c3QaIC5ncmVldC5HcmVldGluZ01hbnlUaW1lc1Jlc3BvbnNlIgAwAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Greet.Greeting), global::Greet.Greeting.Parser, new[]{ "Firstname", "Lastname" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greet.GreetingRequest), global::Greet.GreetingRequest.Parser, new[]{ "Request" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greet.GreetingResponse), global::Greet.GreetingResponse.Parser, new[]{ "Response" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greet.GreetingManyTimesRequest), global::Greet.GreetingManyTimesRequest.Parser, new[]{ "Request" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greet.GreetingManyTimesResponse), global::Greet.GreetingManyTimesResponse.Parser, new[]{ "Response" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Greeting : pb::IMessage<Greeting> {
    private static readonly pb::MessageParser<Greeting> _parser = new pb::MessageParser<Greeting>(() => new Greeting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Greeting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greet.GreetingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Greeting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Greeting(Greeting other) : this() {
      firstname_ = other.firstname_;
      lastname_ = other.lastname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Greeting Clone() {
      return new Greeting(this);
    }

    /// <summary>Field number for the "firstname" field.</summary>
    public const int FirstnameFieldNumber = 1;
    private string firstname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Firstname {
      get { return firstname_; }
      set {
        firstname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastname" field.</summary>
    public const int LastnameFieldNumber = 2;
    private string lastname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lastname {
      get { return lastname_; }
      set {
        lastname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Greeting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Greeting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Firstname != other.Firstname) return false;
      if (Lastname != other.Lastname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Firstname.Length != 0) hash ^= Firstname.GetHashCode();
      if (Lastname.Length != 0) hash ^= Lastname.GetHashCode();
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
      if (Firstname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Firstname);
      }
      if (Lastname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Lastname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Firstname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Firstname);
      }
      if (Lastname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lastname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Greeting other) {
      if (other == null) {
        return;
      }
      if (other.Firstname.Length != 0) {
        Firstname = other.Firstname;
      }
      if (other.Lastname.Length != 0) {
        Lastname = other.Lastname;
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
            Firstname = input.ReadString();
            break;
          }
          case 18: {
            Lastname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GreetingRequest : pb::IMessage<GreetingRequest> {
    private static readonly pb::MessageParser<GreetingRequest> _parser = new pb::MessageParser<GreetingRequest>(() => new GreetingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greet.GreetingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest(GreetingRequest other) : this() {
      request_ = other.request_ != null ? other.request_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest Clone() {
      return new GreetingRequest(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private global::Greet.Greeting request_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Greet.Greeting Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Request, other.Request)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (request_ != null) hash ^= Request.GetHashCode();
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
      if (request_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Request);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (request_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingRequest other) {
      if (other == null) {
        return;
      }
      if (other.request_ != null) {
        if (request_ == null) {
          Request = new global::Greet.Greeting();
        }
        Request.MergeFrom(other.Request);
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
            if (request_ == null) {
              Request = new global::Greet.Greeting();
            }
            input.ReadMessage(Request);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GreetingResponse : pb::IMessage<GreetingResponse> {
    private static readonly pb::MessageParser<GreetingResponse> _parser = new pb::MessageParser<GreetingResponse>(() => new GreetingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greet.GreetingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse(GreetingResponse other) : this() {
      response_ = other.response_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse Clone() {
      return new GreetingResponse(this);
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 1;
    private string response_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Response {
      get { return response_; }
      set {
        response_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Response != other.Response) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Response.Length != 0) hash ^= Response.GetHashCode();
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
      if (Response.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Response);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Response.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Response);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingResponse other) {
      if (other == null) {
        return;
      }
      if (other.Response.Length != 0) {
        Response = other.Response;
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
            Response = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GreetingManyTimesRequest : pb::IMessage<GreetingManyTimesRequest> {
    private static readonly pb::MessageParser<GreetingManyTimesRequest> _parser = new pb::MessageParser<GreetingManyTimesRequest>(() => new GreetingManyTimesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingManyTimesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greet.GreetingReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesRequest(GreetingManyTimesRequest other) : this() {
      request_ = other.request_ != null ? other.request_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesRequest Clone() {
      return new GreetingManyTimesRequest(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private global::Greet.Greeting request_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Greet.Greeting Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingManyTimesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingManyTimesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Request, other.Request)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (request_ != null) hash ^= Request.GetHashCode();
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
      if (request_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Request);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (request_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingManyTimesRequest other) {
      if (other == null) {
        return;
      }
      if (other.request_ != null) {
        if (request_ == null) {
          Request = new global::Greet.Greeting();
        }
        Request.MergeFrom(other.Request);
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
            if (request_ == null) {
              Request = new global::Greet.Greeting();
            }
            input.ReadMessage(Request);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GreetingManyTimesResponse : pb::IMessage<GreetingManyTimesResponse> {
    private static readonly pb::MessageParser<GreetingManyTimesResponse> _parser = new pb::MessageParser<GreetingManyTimesResponse>(() => new GreetingManyTimesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingManyTimesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greet.GreetingReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesResponse(GreetingManyTimesResponse other) : this() {
      response_ = other.response_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingManyTimesResponse Clone() {
      return new GreetingManyTimesResponse(this);
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 1;
    private string response_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Response {
      get { return response_; }
      set {
        response_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingManyTimesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingManyTimesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Response != other.Response) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Response.Length != 0) hash ^= Response.GetHashCode();
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
      if (Response.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Response);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Response.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Response);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingManyTimesResponse other) {
      if (other == null) {
        return;
      }
      if (other.Response.Length != 0) {
        Response = other.Response;
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
            Response = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
