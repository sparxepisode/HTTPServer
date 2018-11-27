// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: game_data_career.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Keep.DBData.Proto {

  /// <summary>Holder for reflection information generated from game_data_career.proto</summary>
  public static partial class GameDataCareerReflection {

    #region Descriptor
    /// <summary>File descriptor for game_data_career.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameDataCareerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZnYW1lX2RhdGFfY2FyZWVyLnByb3RvEhFLZWVwLkRCRGF0YS5Qcm90byI0",
            "Cg9wbGFjZV9wcm9wX2RhdGESDwoHcHJvcF9pZBgBIAEoCRIQCghwcm9wX251",
            "bRgCIAEoBSJgCg9jYXJlZXJpbmZvX2RhdGESEgoKcHJvZmVzc2lvbhgBIAEo",
            "BRINCgVsZXZlbBgCIAEoBRILCgNleHAYAyABKAUSDQoFdGl0bGUYBCABKAkS",
            "DgoGdW5sb2NrGAUgASgIIpwBChJkYXRhX3N0b3J5X2VwaXNvZGUSDwoHaXNf",
            "aGlkZRgCIAEoCBISCgpsaWNrX2NvdW50GAMgASgFEgwKBG5hbWUYBCABKAkS",
            "DwoHY29sb3JfchgGIAEoBRIPCgdjb2xvcl9nGAcgASgFEg8KB2NvbG9yX2IY",
            "CCABKAUSDwoHY29sb3JfYRgJIAEoBRIPCgdjb250ZW5zGAogAygJIsACChJk",
            "YV9kYXRhX2NhcmVlcmluZm8SDwoHdXNlcl9pZBgBIAEoBRIWCg5jdXJyZW50",
            "X2NhcmVlchgCIAEoBRIUCgxoYXNfZm9vZF9ib3gYAyABKAgSOwoPc2VsbF9w",
            "cm9wX2RhdGFzGAQgAygLMiIuS2VlcC5EQkRhdGEuUHJvdG8ucGxhY2VfcHJv",
            "cF9kYXRhEjYKCmZvb2RfZGF0YXMYBSADKAsyIi5LZWVwLkRCRGF0YS5Qcm90",
            "by5wbGFjZV9wcm9wX2RhdGESOAoMY2FyZWVyX2RhdGFzGAYgAygLMiIuS2Vl",
            "cC5EQkRhdGEuUHJvdG8uY2FyZWVyaW5mb19kYXRhEjwKDXN0b3J5X2VwaXNv",
            "ZGUYByADKAsyJS5LZWVwLkRCRGF0YS5Qcm90by5kYXRhX3N0b3J5X2VwaXNv",
            "ZGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.place_prop_data), global::Keep.DBData.Proto.place_prop_data.Parser, new[]{ "PropId", "PropNum" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.careerinfo_data), global::Keep.DBData.Proto.careerinfo_data.Parser, new[]{ "Profession", "Level", "Exp", "Title", "Unlock" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.data_story_episode), global::Keep.DBData.Proto.data_story_episode.Parser, new[]{ "IsHide", "LickCount", "Name", "ColorR", "ColorG", "ColorB", "ColorA", "Contens" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.da_data_careerinfo), global::Keep.DBData.Proto.da_data_careerinfo.Parser, new[]{ "UserId", "CurrentCareer", "HasFoodBox", "SellPropDatas", "FoodDatas", "CareerDatas", "StoryEpisode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class place_prop_data : pb::IMessage<place_prop_data> {
    private static readonly pb::MessageParser<place_prop_data> _parser = new pb::MessageParser<place_prop_data>(() => new place_prop_data());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<place_prop_data> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCareerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public place_prop_data() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public place_prop_data(place_prop_data other) : this() {
      propId_ = other.propId_;
      propNum_ = other.propNum_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public place_prop_data Clone() {
      return new place_prop_data(this);
    }

    /// <summary>Field number for the "prop_id" field.</summary>
    public const int PropIdFieldNumber = 1;
    private string propId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PropId {
      get { return propId_; }
      set {
        propId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "prop_num" field.</summary>
    public const int PropNumFieldNumber = 2;
    private int propNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PropNum {
      get { return propNum_; }
      set {
        propNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as place_prop_data);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(place_prop_data other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PropId != other.PropId) return false;
      if (PropNum != other.PropNum) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PropId.Length != 0) hash ^= PropId.GetHashCode();
      if (PropNum != 0) hash ^= PropNum.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PropId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PropId);
      }
      if (PropNum != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PropNum);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PropId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PropId);
      }
      if (PropNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PropNum);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(place_prop_data other) {
      if (other == null) {
        return;
      }
      if (other.PropId.Length != 0) {
        PropId = other.PropId;
      }
      if (other.PropNum != 0) {
        PropNum = other.PropNum;
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
          case 10: {
            PropId = input.ReadString();
            break;
          }
          case 16: {
            PropNum = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class careerinfo_data : pb::IMessage<careerinfo_data> {
    private static readonly pb::MessageParser<careerinfo_data> _parser = new pb::MessageParser<careerinfo_data>(() => new careerinfo_data());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<careerinfo_data> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCareerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public careerinfo_data() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public careerinfo_data(careerinfo_data other) : this() {
      profession_ = other.profession_;
      level_ = other.level_;
      exp_ = other.exp_;
      title_ = other.title_;
      unlock_ = other.unlock_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public careerinfo_data Clone() {
      return new careerinfo_data(this);
    }

    /// <summary>Field number for the "profession" field.</summary>
    public const int ProfessionFieldNumber = 1;
    private int profession_;
    /// <summary>
    ///  职业类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Profession {
      get { return profession_; }
      set {
        profession_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private int level_;
    /// <summary>
    ///  职业等级 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 3;
    private int exp_;
    /// <summary>
    ///  职业经验
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 4;
    private string title_ = "";
    /// <summary>
    ///  职业称号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unlock" field.</summary>
    public const int UnlockFieldNumber = 5;
    private bool unlock_;
    /// <summary>
    ///  是否解锁
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Unlock {
      get { return unlock_; }
      set {
        unlock_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as careerinfo_data);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(careerinfo_data other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Profession != other.Profession) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Title != other.Title) return false;
      if (Unlock != other.Unlock) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Profession != 0) hash ^= Profession.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Unlock != false) hash ^= Unlock.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Profession != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Profession);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Exp);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Title);
      }
      if (Unlock != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unlock);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Profession != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Profession);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Exp);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Unlock != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(careerinfo_data other) {
      if (other == null) {
        return;
      }
      if (other.Profession != 0) {
        Profession = other.Profession;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Unlock != false) {
        Unlock = other.Unlock;
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
            Profession = input.ReadInt32();
            break;
          }
          case 16: {
            Level = input.ReadInt32();
            break;
          }
          case 24: {
            Exp = input.ReadInt32();
            break;
          }
          case 34: {
            Title = input.ReadString();
            break;
          }
          case 40: {
            Unlock = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class data_story_episode : pb::IMessage<data_story_episode> {
    private static readonly pb::MessageParser<data_story_episode> _parser = new pb::MessageParser<data_story_episode>(() => new data_story_episode());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<data_story_episode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCareerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public data_story_episode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public data_story_episode(data_story_episode other) : this() {
      isHide_ = other.isHide_;
      lickCount_ = other.lickCount_;
      name_ = other.name_;
      colorR_ = other.colorR_;
      colorG_ = other.colorG_;
      colorB_ = other.colorB_;
      colorA_ = other.colorA_;
      contens_ = other.contens_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public data_story_episode Clone() {
      return new data_story_episode(this);
    }

    /// <summary>Field number for the "is_hide" field.</summary>
    public const int IsHideFieldNumber = 2;
    private bool isHide_;
    /// <summary>
    /// 是否隐藏
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsHide {
      get { return isHide_; }
      set {
        isHide_ = value;
      }
    }

    /// <summary>Field number for the "lick_count" field.</summary>
    public const int LickCountFieldNumber = 3;
    private int lickCount_;
    /// <summary>
    /// 点赞个数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LickCount {
      get { return lickCount_; }
      set {
        lickCount_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// 章节名字
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "color_r" field.</summary>
    public const int ColorRFieldNumber = 6;
    private int colorR_;
    /// <summary>
    /// 色卡 color.r
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ColorR {
      get { return colorR_; }
      set {
        colorR_ = value;
      }
    }

    /// <summary>Field number for the "color_g" field.</summary>
    public const int ColorGFieldNumber = 7;
    private int colorG_;
    /// <summary>
    /// 色卡 color.g
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ColorG {
      get { return colorG_; }
      set {
        colorG_ = value;
      }
    }

    /// <summary>Field number for the "color_b" field.</summary>
    public const int ColorBFieldNumber = 8;
    private int colorB_;
    /// <summary>
    /// 色卡 color.b
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ColorB {
      get { return colorB_; }
      set {
        colorB_ = value;
      }
    }

    /// <summary>Field number for the "color_a" field.</summary>
    public const int ColorAFieldNumber = 9;
    private int colorA_;
    /// <summary>
    /// 色卡 color.a
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ColorA {
      get { return colorA_; }
      set {
        colorA_ = value;
      }
    }

    /// <summary>Field number for the "contens" field.</summary>
    public const int ContensFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_contens_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> contens_ = new pbc::RepeatedField<string>();
    /// <summary>
    ///故事内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Contens {
      get { return contens_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as data_story_episode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(data_story_episode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsHide != other.IsHide) return false;
      if (LickCount != other.LickCount) return false;
      if (Name != other.Name) return false;
      if (ColorR != other.ColorR) return false;
      if (ColorG != other.ColorG) return false;
      if (ColorB != other.ColorB) return false;
      if (ColorA != other.ColorA) return false;
      if(!contens_.Equals(other.contens_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsHide != false) hash ^= IsHide.GetHashCode();
      if (LickCount != 0) hash ^= LickCount.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ColorR != 0) hash ^= ColorR.GetHashCode();
      if (ColorG != 0) hash ^= ColorG.GetHashCode();
      if (ColorB != 0) hash ^= ColorB.GetHashCode();
      if (ColorA != 0) hash ^= ColorA.GetHashCode();
      hash ^= contens_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsHide != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsHide);
      }
      if (LickCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(LickCount);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (ColorR != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ColorR);
      }
      if (ColorG != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ColorG);
      }
      if (ColorB != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(ColorB);
      }
      if (ColorA != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ColorA);
      }
      contens_.WriteTo(output, _repeated_contens_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsHide != false) {
        size += 1 + 1;
      }
      if (LickCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LickCount);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ColorR != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ColorR);
      }
      if (ColorG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ColorG);
      }
      if (ColorB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ColorB);
      }
      if (ColorA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ColorA);
      }
      size += contens_.CalculateSize(_repeated_contens_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(data_story_episode other) {
      if (other == null) {
        return;
      }
      if (other.IsHide != false) {
        IsHide = other.IsHide;
      }
      if (other.LickCount != 0) {
        LickCount = other.LickCount;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ColorR != 0) {
        ColorR = other.ColorR;
      }
      if (other.ColorG != 0) {
        ColorG = other.ColorG;
      }
      if (other.ColorB != 0) {
        ColorB = other.ColorB;
      }
      if (other.ColorA != 0) {
        ColorA = other.ColorA;
      }
      contens_.Add(other.contens_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 16: {
            IsHide = input.ReadBool();
            break;
          }
          case 24: {
            LickCount = input.ReadInt32();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 48: {
            ColorR = input.ReadInt32();
            break;
          }
          case 56: {
            ColorG = input.ReadInt32();
            break;
          }
          case 64: {
            ColorB = input.ReadInt32();
            break;
          }
          case 72: {
            ColorA = input.ReadInt32();
            break;
          }
          case 82: {
            contens_.AddEntriesFrom(input, _repeated_contens_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 单条记录
  /// </summary>
  public sealed partial class da_data_careerinfo : pb::IMessage<da_data_careerinfo> {
    private static readonly pb::MessageParser<da_data_careerinfo> _parser = new pb::MessageParser<da_data_careerinfo>(() => new da_data_careerinfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<da_data_careerinfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCareerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public da_data_careerinfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public da_data_careerinfo(da_data_careerinfo other) : this() {
      userId_ = other.userId_;
      currentCareer_ = other.currentCareer_;
      hasFoodBox_ = other.hasFoodBox_;
      sellPropDatas_ = other.sellPropDatas_.Clone();
      foodDatas_ = other.foodDatas_.Clone();
      careerDatas_ = other.careerDatas_.Clone();
      storyEpisode_ = other.storyEpisode_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public da_data_careerinfo Clone() {
      return new da_data_careerinfo(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private int userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "current_career" field.</summary>
    public const int CurrentCareerFieldNumber = 2;
    private int currentCareer_;
    /// <summary>
    /// 主职业
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentCareer {
      get { return currentCareer_; }
      set {
        currentCareer_ = value;
      }
    }

    /// <summary>Field number for the "has_food_box" field.</summary>
    public const int HasFoodBoxFieldNumber = 3;
    private bool hasFoodBox_;
    /// <summary>
    /// 是否有食物箱
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasFoodBox {
      get { return hasFoodBox_; }
      set {
        hasFoodBox_ = value;
      }
    }

    /// <summary>Field number for the "sell_prop_datas" field.</summary>
    public const int SellPropDatasFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.place_prop_data> _repeated_sellPropDatas_codec
        = pb::FieldCodec.ForMessage(34, global::Keep.DBData.Proto.place_prop_data.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data> sellPropDatas_ = new pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data>();
    /// <summary>
    /// 放置出售的道具信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data> SellPropDatas {
      get { return sellPropDatas_; }
    }

    /// <summary>Field number for the "food_datas" field.</summary>
    public const int FoodDatasFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.place_prop_data> _repeated_foodDatas_codec
        = pb::FieldCodec.ForMessage(42, global::Keep.DBData.Proto.place_prop_data.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data> foodDatas_ = new pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data>();
    /// <summary>
    /// 放置食物信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.place_prop_data> FoodDatas {
      get { return foodDatas_; }
    }

    /// <summary>Field number for the "career_datas" field.</summary>
    public const int CareerDatasFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.careerinfo_data> _repeated_careerDatas_codec
        = pb::FieldCodec.ForMessage(50, global::Keep.DBData.Proto.careerinfo_data.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.careerinfo_data> careerDatas_ = new pbc::RepeatedField<global::Keep.DBData.Proto.careerinfo_data>();
    /// <summary>
    /// 职业信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.careerinfo_data> CareerDatas {
      get { return careerDatas_; }
    }

    /// <summary>Field number for the "story_episode" field.</summary>
    public const int StoryEpisodeFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.data_story_episode> _repeated_storyEpisode_codec
        = pb::FieldCodec.ForMessage(58, global::Keep.DBData.Proto.data_story_episode.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.data_story_episode> storyEpisode_ = new pbc::RepeatedField<global::Keep.DBData.Proto.data_story_episode>();
    /// <summary>
    /// 编写故事内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.data_story_episode> StoryEpisode {
      get { return storyEpisode_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as da_data_careerinfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(da_data_careerinfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (CurrentCareer != other.CurrentCareer) return false;
      if (HasFoodBox != other.HasFoodBox) return false;
      if(!sellPropDatas_.Equals(other.sellPropDatas_)) return false;
      if(!foodDatas_.Equals(other.foodDatas_)) return false;
      if(!careerDatas_.Equals(other.careerDatas_)) return false;
      if(!storyEpisode_.Equals(other.storyEpisode_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (CurrentCareer != 0) hash ^= CurrentCareer.GetHashCode();
      if (HasFoodBox != false) hash ^= HasFoodBox.GetHashCode();
      hash ^= sellPropDatas_.GetHashCode();
      hash ^= foodDatas_.GetHashCode();
      hash ^= careerDatas_.GetHashCode();
      hash ^= storyEpisode_.GetHashCode();
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
      if (CurrentCareer != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurrentCareer);
      }
      if (HasFoodBox != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasFoodBox);
      }
      sellPropDatas_.WriteTo(output, _repeated_sellPropDatas_codec);
      foodDatas_.WriteTo(output, _repeated_foodDatas_codec);
      careerDatas_.WriteTo(output, _repeated_careerDatas_codec);
      storyEpisode_.WriteTo(output, _repeated_storyEpisode_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      if (CurrentCareer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentCareer);
      }
      if (HasFoodBox != false) {
        size += 1 + 1;
      }
      size += sellPropDatas_.CalculateSize(_repeated_sellPropDatas_codec);
      size += foodDatas_.CalculateSize(_repeated_foodDatas_codec);
      size += careerDatas_.CalculateSize(_repeated_careerDatas_codec);
      size += storyEpisode_.CalculateSize(_repeated_storyEpisode_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(da_data_careerinfo other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.CurrentCareer != 0) {
        CurrentCareer = other.CurrentCareer;
      }
      if (other.HasFoodBox != false) {
        HasFoodBox = other.HasFoodBox;
      }
      sellPropDatas_.Add(other.sellPropDatas_);
      foodDatas_.Add(other.foodDatas_);
      careerDatas_.Add(other.careerDatas_);
      storyEpisode_.Add(other.storyEpisode_);
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
          case 16: {
            CurrentCareer = input.ReadInt32();
            break;
          }
          case 24: {
            HasFoodBox = input.ReadBool();
            break;
          }
          case 34: {
            sellPropDatas_.AddEntriesFrom(input, _repeated_sellPropDatas_codec);
            break;
          }
          case 42: {
            foodDatas_.AddEntriesFrom(input, _repeated_foodDatas_codec);
            break;
          }
          case 50: {
            careerDatas_.AddEntriesFrom(input, _repeated_careerDatas_codec);
            break;
          }
          case 58: {
            storyEpisode_.AddEntriesFrom(input, _repeated_storyEpisode_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code