// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/duration.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  /// <summary>Holder for reflection information generated from google/protobuf/duration.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DurationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/protobuf/duration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8SD2dvb2dsZS5wcm90",
            "b2J1ZiIqCghEdXJhdGlvbhIPCgdzZWNvbmRzGAEgASgDEg0KBW5hbm9zGAIg",
            "ASgFQlAKE2NvbS5nb29nbGUucHJvdG9idWZCDUR1cmF0aW9uUHJvdG9QAaAB",
            "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Duration), global::Google.Protobuf.WellKnownTypes.Duration.Parser, new[]{ "Seconds", "Nanos" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A Duration represents a signed, fixed-length span of time represented
  ///  as a count of seconds and fractions of seconds at nanosecond
  ///  resolution. It is independent of any calendar and concepts like "day"
  ///  or "month". It is related to Timestamp in that the difference between
  ///  two Timestamp values is a Duration and it can be added or subtracted
  ///  from a Timestamp. Range is approximately +-10,000 years.
  ///
  ///  Example 1: Compute Duration from two Timestamps in pseudo code.
  ///
  ///      Timestamp start = ...;
  ///      Timestamp end = ...;
  ///      Duration duration = ...;
  ///
  ///      duration.seconds = end.seconds - start.seconds;
  ///      duration.nanos = end.nanos - start.nanos;
  ///
  ///      if (duration.seconds &lt; 0 &amp;&amp; duration.nanos > 0) {
  ///        duration.seconds += 1;
  ///        duration.nanos -= 1000000000;
  ///      } else if (durations.seconds > 0 &amp;&amp; duration.nanos &lt; 0) {
  ///        duration.seconds -= 1;
  ///        duration.nanos += 1000000000;
  ///      }
  ///
  ///  Example 2: Compute Timestamp from Timestamp + Duration in pseudo code.
  ///
  ///      Timestamp start = ...;
  ///      Duration duration = ...;
  ///      Timestamp end = ...;
  ///
  ///      end.seconds = start.seconds + duration.seconds;
  ///      end.nanos = start.nanos + duration.nanos;
  ///
  ///      if (end.nanos &lt; 0) {
  ///        end.seconds -= 1;
  ///        end.nanos += 1000000000;
  ///      } else if (end.nanos >= 1000000000) {
  ///        end.seconds += 1;
  ///        end.nanos -= 1000000000;
  ///      }
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Duration : pb::IMessage<Duration> {
    private static readonly pb::MessageParser<Duration> _parser = new pb::MessageParser<Duration>(() => new Duration());
    public static pb::MessageParser<Duration> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Duration() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Duration(Duration other) : this() {
      seconds_ = other.seconds_;
      nanos_ = other.nanos_;
    }

    public Duration Clone() {
      return new Duration(this);
    }

    /// <summary>Field number for the "seconds" field.</summary>
    public const int SecondsFieldNumber = 1;
    private long seconds_;
    /// <summary>
    ///  Signed seconds of the span of time. Must be from -315,576,000,000
    ///  to +315,576,000,000 inclusive.
    /// </summary>
    public long Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 2;
    private int nanos_;
    /// <summary>
    ///  Signed fractions of a second at nanosecond resolution of the span
    ///  of time. Durations less than one second are represented with a 0
    ///  `seconds` field and a positive or negative `nanos` field. For durations
    ///  of one second or more, a non-zero value for the `nanos` field must be
    ///  of the same sign as the `seconds` field. Must be from -999,999,999
    ///  to +999,999,999 inclusive.
    /// </summary>
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Duration);
    }

    public bool Equals(Duration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Seconds != other.Seconds) return false;
      if (Nanos != other.Nanos) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Seconds != 0L) hash ^= Seconds.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Seconds != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Nanos);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Seconds != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Seconds);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      return size;
    }

    public void MergeFrom(Duration other) {
      if (other == null) {
        return;
      }
      if (other.Seconds != 0L) {
        Seconds = other.Seconds;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Seconds = input.ReadInt64();
            break;
          }
          case 16: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
