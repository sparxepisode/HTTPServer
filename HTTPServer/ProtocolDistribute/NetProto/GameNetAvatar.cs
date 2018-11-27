// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: game_net_avatar.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Keep.NetProtocol.Proto {

  /// <summary>Holder for reflection information generated from game_net_avatar.proto</summary>
  public static partial class GameNetAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for game_net_avatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameNetAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVnYW1lX25ldF9hdmF0YXIucHJvdG8SFktlZXAuTmV0UHJvdG9jb2wuUHJv",
            "dG8aEWdhbWVfbmV0X2lkLnByb3RvIkEKGmdhbWVfYXZhdGFyX2NyZWF0ZV9u",
            "ZXdfcmVxEhAKCHJlZ2lzdGVyGAEgASgFEhEKCWV4dGVybmtleRgCIAEoCSJl",
            "ChpnYW1lX2F2YXRhcl9jcmVhdGVfbmV3X3JlcBI2CgRjb2RlGAEgASgOMigu",
            "S2VlcC5OZXRQcm90b2NvbC5Qcm90by5nYW1lX3Jlc3VsdF9jb2RlEg8KB3Vz",
            "ZXJfaWQYAiABKAUiQQocZ2FtZV9hdmF0YXJfbmlja25hbWVfc2V0X3JlcRIP",
            "Cgd1c2VyX2lkGAEgASgFEhAKCG5pY2tuYW1lGAIgASgJIlYKHGdhbWVfYXZh",
            "dGFyX25pY2tuYW1lX3NldF9yZXASNgoEY29kZRgBIAEoDjIoLktlZXAuTmV0",
            "UHJvdG9jb2wuUHJvdG8uZ2FtZV9yZXN1bHRfY29kZSInChVnYW1lX2F2YXRh",
            "cl9sb2dpbl9yZXESDgoGdXNlcmlkGAEgASgFIk8KFWdhbWVfYXZhdGVyX2xv",
            "Z2luX3JlcBI2CgRjb2RlGAEgASgOMiguS2VlcC5OZXRQcm90b2NvbC5Qcm90",
            "by5nYW1lX3Jlc3VsdF9jb2RlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Keep.NetProtocol.Proto.GameNetIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avatar_create_new_req), global::Keep.NetProtocol.Proto.game_avatar_create_new_req.Parser, new[]{ "Register", "Externkey" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avatar_create_new_rep), global::Keep.NetProtocol.Proto.game_avatar_create_new_rep.Parser, new[]{ "Code", "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avatar_nickname_set_req), global::Keep.NetProtocol.Proto.game_avatar_nickname_set_req.Parser, new[]{ "UserId", "Nickname" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avatar_nickname_set_rep), global::Keep.NetProtocol.Proto.game_avatar_nickname_set_rep.Parser, new[]{ "Code" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avatar_login_req), global::Keep.NetProtocol.Proto.game_avatar_login_req.Parser, new[]{ "Userid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.NetProtocol.Proto.game_avater_login_rep), global::Keep.NetProtocol.Proto.game_avater_login_rep.Parser, new[]{ "Code" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///c->s 10001 创造新账号
  /// </summary>
  public sealed partial class game_avatar_create_new_req : pb::IMessage<game_avatar_create_new_req> {
    private static readonly pb::MessageParser<game_avatar_create_new_req> _parser = new pb::MessageParser<game_avatar_create_new_req>(() => new game_avatar_create_new_req());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avatar_create_new_req> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_req() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_req(game_avatar_create_new_req other) : this() {
      register_ = other.register_;
      externkey_ = other.externkey_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_req Clone() {
      return new game_avatar_create_new_req(this);
    }

    /// <summary>Field number for the "register" field.</summary>
    public const int RegisterFieldNumber = 1;
    private int register_;
    /// <summary>
    ///注册方式
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Register {
      get { return register_; }
      set {
        register_ = value;
      }
    }

    /// <summary>Field number for the "externkey" field.</summary>
    public const int ExternkeyFieldNumber = 2;
    private string externkey_ = "";
    /// <summary>
    ///额外的key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Externkey {
      get { return externkey_; }
      set {
        externkey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avatar_create_new_req);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avatar_create_new_req other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Register != other.Register) return false;
      if (Externkey != other.Externkey) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Register != 0) hash ^= Register.GetHashCode();
      if (Externkey.Length != 0) hash ^= Externkey.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Register != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Register);
      }
      if (Externkey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Externkey);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Register != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Register);
      }
      if (Externkey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Externkey);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avatar_create_new_req other) {
      if (other == null) {
        return;
      }
      if (other.Register != 0) {
        Register = other.Register;
      }
      if (other.Externkey.Length != 0) {
        Externkey = other.Externkey;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Register = input.ReadInt32();
            break;
          }
          case 18: {
            Externkey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///s->c 10001 创建账号 callback
  /// </summary>
  public sealed partial class game_avatar_create_new_rep : pb::IMessage<game_avatar_create_new_rep> {
    private static readonly pb::MessageParser<game_avatar_create_new_rep> _parser = new pb::MessageParser<game_avatar_create_new_rep>(() => new game_avatar_create_new_rep());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avatar_create_new_rep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_rep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_rep(game_avatar_create_new_rep other) : this() {
      code_ = other.code_;
      userId_ = other.userId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_create_new_rep Clone() {
      return new game_avatar_create_new_rep(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Keep.NetProtocol.Proto.game_result_code code_ = 0;
    /// <summary>
    ///回调结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Keep.NetProtocol.Proto.game_result_code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private int userId_;
    /// <summary>
    ///user id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avatar_create_new_rep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avatar_create_new_rep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (UserId != other.UserId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (UserId != 0) hash ^= UserId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (UserId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UserId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avatar_create_new_rep other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            code_ = (global::Keep.NetProtocol.Proto.game_result_code) input.ReadEnum();
            break;
          }
          case 16: {
            UserId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///c->s 10002 设置nickname
  /// </summary>
  public sealed partial class game_avatar_nickname_set_req : pb::IMessage<game_avatar_nickname_set_req> {
    private static readonly pb::MessageParser<game_avatar_nickname_set_req> _parser = new pb::MessageParser<game_avatar_nickname_set_req>(() => new game_avatar_nickname_set_req());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avatar_nickname_set_req> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_req() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_req(game_avatar_nickname_set_req other) : this() {
      userId_ = other.userId_;
      nickname_ = other.nickname_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_req Clone() {
      return new game_avatar_nickname_set_req(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    /// <summary>
    ///注册方式
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 2;
    private string nickname_ = "";
    /// <summary>
    ///昵称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avatar_nickname_set_req);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avatar_nickname_set_req other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (Nickname != other.Nickname) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UserId);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avatar_nickname_set_req other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt32();
            break;
          }
          case 18: {
            Nickname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///s->c 10002 设置nickname callback
  /// </summary>
  public sealed partial class game_avatar_nickname_set_rep : pb::IMessage<game_avatar_nickname_set_rep> {
    private static readonly pb::MessageParser<game_avatar_nickname_set_rep> _parser = new pb::MessageParser<game_avatar_nickname_set_rep>(() => new game_avatar_nickname_set_rep());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avatar_nickname_set_rep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_rep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_rep(game_avatar_nickname_set_rep other) : this() {
      code_ = other.code_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_nickname_set_rep Clone() {
      return new game_avatar_nickname_set_rep(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Keep.NetProtocol.Proto.game_result_code code_ = 0;
    /// <summary>
    ///回调结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Keep.NetProtocol.Proto.game_result_code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avatar_nickname_set_rep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avatar_nickname_set_rep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avatar_nickname_set_rep other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            code_ = (global::Keep.NetProtocol.Proto.game_result_code) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///c->s 10003	登陆请求	
  /// </summary>
  public sealed partial class game_avatar_login_req : pb::IMessage<game_avatar_login_req> {
    private static readonly pb::MessageParser<game_avatar_login_req> _parser = new pb::MessageParser<game_avatar_login_req>(() => new game_avatar_login_req());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avatar_login_req> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_login_req() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_login_req(game_avatar_login_req other) : this() {
      userid_ = other.userid_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avatar_login_req Clone() {
      return new game_avatar_login_req(this);
    }

    /// <summary>Field number for the "userid" field.</summary>
    public const int UseridFieldNumber = 1;
    private int userid_;
    /// <summary>
    ///用户id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Userid {
      get { return userid_; }
      set {
        userid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avatar_login_req);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avatar_login_req other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Userid != other.Userid) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Userid != 0) hash ^= Userid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Userid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Userid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Userid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Userid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avatar_login_req other) {
      if (other == null) {
        return;
      }
      if (other.Userid != 0) {
        Userid = other.Userid;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Userid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///s->c 10003 登陆 callback
  /// </summary>
  public sealed partial class game_avater_login_rep : pb::IMessage<game_avater_login_rep> {
    private static readonly pb::MessageParser<game_avater_login_rep> _parser = new pb::MessageParser<game_avater_login_rep>(() => new game_avater_login_rep());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<game_avater_login_rep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.NetProtocol.Proto.GameNetAvatarReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avater_login_rep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avater_login_rep(game_avater_login_rep other) : this() {
      code_ = other.code_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public game_avater_login_rep Clone() {
      return new game_avater_login_rep(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Keep.NetProtocol.Proto.game_result_code code_ = 0;
    /// <summary>
    ///回调结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Keep.NetProtocol.Proto.game_result_code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as game_avater_login_rep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(game_avater_login_rep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(game_avater_login_rep other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            code_ = (global::Keep.NetProtocol.Proto.game_result_code) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
