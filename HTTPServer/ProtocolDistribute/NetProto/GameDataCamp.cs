// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: game_data_camp.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Keep.DBData.Proto {

  /// <summary>Holder for reflection information generated from game_data_camp.proto</summary>
  public static partial class GameDataCampReflection {

    #region Descriptor
    /// <summary>File descriptor for game_data_camp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameDataCampReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRnYW1lX2RhdGFfY2FtcC5wcm90bxIRS2VlcC5EQkRhdGEuUHJvdG8iagoO",
            "Y2FtcGluZm9fY2hhaXISEgoKY2hhaXJfdHlwZRgBIAEoBRIMCgRzbG90GAIg",
            "ASgFEg4KBmlzX3NpdBgDIAEoCBIQCghldmVudF9pZBgEIAEoCRIUCgx0cmF2",
            "ZWxsZXJfaWQYBSABKAkiYwoVY2FtcGluZm9fb3JuYW1lbnRfcHV0Eg0KBWlu",
            "ZGV4GAEgASgFEg4KBnByb3BpZBgCIAEoCRINCgVwb3NfeBgDIAEoAhINCgVw",
            "b3NfeRgEIAEoAhINCgVwb3NfehgFIAEoAiK1AwoIY2FtcGluZm8SEQoJY2Ft",
            "cF90eXBlGAEgASgFEhEKCWNhbXBfbmFtZRgCIAEoCRIPCgdjYW1wX2lkGAMg",
            "ASgJEhMKC2NoYWlyX2xldmVsGAQgASgFEhIKCnRlbnRfbGV2ZWwYBSABKAUS",
            "FgoOY2FtcGZpcmVfbGV2ZWwYBiABKAUSEQoJYm94X2xldmVsGAcgASgFEjEK",
            "BmNoYWlycxgIIAMoCzIhLktlZXAuREJEYXRhLlByb3RvLmNhbXBpbmZvX2No",
            "YWlyEj8KDW9ybmFtZW50X3B1dHMYCSADKAsyKC5LZWVwLkRCRGF0YS5Qcm90",
            "by5jYW1waW5mb19vcm5hbWVudF9wdXQSGgoSYW5pbWFsX2tpbmRfdW5sb2Nr",
            "GAogAygJEiEKGWlzX2ZpbmlzaF9maXJzdF9pbml0X3RlbnQYCyABKAgSJQod",
            "aXNfZmluaXNoX2ZpcnN0X2luaXRfY2FtcGZpcmUYDCABKAgSIAoYaXNfZmlu",
            "aXNoX2ZpcnN0X2luaXRfYm94GA0gASgIEiIKGmlzX2ZpbmlzaF9maXJzdF9p",
            "bml0X2NoYWlyGA4gASgIImQKFGRiX2RhdGFfY2FtcGluZm9Db2xsEg8KB3Vz",
            "ZXJfaWQYASABKAUSKQoEY29sbBgCIAMoCzIbLktlZXAuREJEYXRhLlByb3Rv",
            "LmNhbXBpbmZvEhAKCGxhc3RDYW1wGAMgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.campinfo_chair), global::Keep.DBData.Proto.campinfo_chair.Parser, new[]{ "ChairType", "Slot", "IsSit", "EventId", "TravellerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.campinfo_ornament_put), global::Keep.DBData.Proto.campinfo_ornament_put.Parser, new[]{ "Index", "Propid", "PosX", "PosY", "PosZ" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.campinfo), global::Keep.DBData.Proto.campinfo.Parser, new[]{ "CampType", "CampName", "CampId", "ChairLevel", "TentLevel", "CampfireLevel", "BoxLevel", "Chairs", "OrnamentPuts", "AnimalKindUnlock", "IsFinishFirstInitTent", "IsFinishFirstInitCampfire", "IsFinishFirstInitBox", "IsFinishFirstInitChair" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Keep.DBData.Proto.db_data_campinfoColl), global::Keep.DBData.Proto.db_data_campinfoColl.Parser, new[]{ "UserId", "Coll", "LastCamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class campinfo_chair : pb::IMessage<campinfo_chair> {
    private static readonly pb::MessageParser<campinfo_chair> _parser = new pb::MessageParser<campinfo_chair>(() => new campinfo_chair());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<campinfo_chair> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCampReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_chair() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_chair(campinfo_chair other) : this() {
      chairType_ = other.chairType_;
      slot_ = other.slot_;
      isSit_ = other.isSit_;
      eventId_ = other.eventId_;
      travellerId_ = other.travellerId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_chair Clone() {
      return new campinfo_chair(this);
    }

    /// <summary>Field number for the "chair_type" field.</summary>
    public const int ChairTypeFieldNumber = 1;
    private int chairType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ChairType {
      get { return chairType_; }
      set {
        chairType_ = value;
      }
    }

    /// <summary>Field number for the "slot" field.</summary>
    public const int SlotFieldNumber = 2;
    private int slot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Slot {
      get { return slot_; }
      set {
        slot_ = value;
      }
    }

    /// <summary>Field number for the "is_sit" field.</summary>
    public const int IsSitFieldNumber = 3;
    private bool isSit_;
    /// <summary>
    ///是否有人坐着
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSit {
      get { return isSit_; }
      set {
        isSit_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 4;
    private string eventId_ = "";
    /// <summary>
    /// 坐着的旅人 event id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EventId {
      get { return eventId_; }
      set {
        eventId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "traveller_id" field.</summary>
    public const int TravellerIdFieldNumber = 5;
    private string travellerId_ = "";
    /// <summary>
    /// 旅人 id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TravellerId {
      get { return travellerId_; }
      set {
        travellerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as campinfo_chair);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(campinfo_chair other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChairType != other.ChairType) return false;
      if (Slot != other.Slot) return false;
      if (IsSit != other.IsSit) return false;
      if (EventId != other.EventId) return false;
      if (TravellerId != other.TravellerId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ChairType != 0) hash ^= ChairType.GetHashCode();
      if (Slot != 0) hash ^= Slot.GetHashCode();
      if (IsSit != false) hash ^= IsSit.GetHashCode();
      if (EventId.Length != 0) hash ^= EventId.GetHashCode();
      if (TravellerId.Length != 0) hash ^= TravellerId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ChairType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ChairType);
      }
      if (Slot != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Slot);
      }
      if (IsSit != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSit);
      }
      if (EventId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EventId);
      }
      if (TravellerId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TravellerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ChairType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChairType);
      }
      if (Slot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Slot);
      }
      if (IsSit != false) {
        size += 1 + 1;
      }
      if (EventId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventId);
      }
      if (TravellerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TravellerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(campinfo_chair other) {
      if (other == null) {
        return;
      }
      if (other.ChairType != 0) {
        ChairType = other.ChairType;
      }
      if (other.Slot != 0) {
        Slot = other.Slot;
      }
      if (other.IsSit != false) {
        IsSit = other.IsSit;
      }
      if (other.EventId.Length != 0) {
        EventId = other.EventId;
      }
      if (other.TravellerId.Length != 0) {
        TravellerId = other.TravellerId;
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
            ChairType = input.ReadInt32();
            break;
          }
          case 16: {
            Slot = input.ReadInt32();
            break;
          }
          case 24: {
            IsSit = input.ReadBool();
            break;
          }
          case 34: {
            EventId = input.ReadString();
            break;
          }
          case 42: {
            TravellerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class campinfo_ornament_put : pb::IMessage<campinfo_ornament_put> {
    private static readonly pb::MessageParser<campinfo_ornament_put> _parser = new pb::MessageParser<campinfo_ornament_put>(() => new campinfo_ornament_put());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<campinfo_ornament_put> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCampReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_ornament_put() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_ornament_put(campinfo_ornament_put other) : this() {
      index_ = other.index_;
      propid_ = other.propid_;
      posX_ = other.posX_;
      posY_ = other.posY_;
      posZ_ = other.posZ_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo_ornament_put Clone() {
      return new campinfo_ornament_put(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "propid" field.</summary>
    public const int PropidFieldNumber = 2;
    private string propid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Propid {
      get { return propid_; }
      set {
        propid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pos_x" field.</summary>
    public const int PosXFieldNumber = 3;
    private float posX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PosX {
      get { return posX_; }
      set {
        posX_ = value;
      }
    }

    /// <summary>Field number for the "pos_y" field.</summary>
    public const int PosYFieldNumber = 4;
    private float posY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PosY {
      get { return posY_; }
      set {
        posY_ = value;
      }
    }

    /// <summary>Field number for the "pos_z" field.</summary>
    public const int PosZFieldNumber = 5;
    private float posZ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PosZ {
      get { return posZ_; }
      set {
        posZ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as campinfo_ornament_put);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(campinfo_ornament_put other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (Propid != other.Propid) return false;
      if (PosX != other.PosX) return false;
      if (PosY != other.PosY) return false;
      if (PosZ != other.PosZ) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Propid.Length != 0) hash ^= Propid.GetHashCode();
      if (PosX != 0F) hash ^= PosX.GetHashCode();
      if (PosY != 0F) hash ^= PosY.GetHashCode();
      if (PosZ != 0F) hash ^= PosZ.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (Propid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Propid);
      }
      if (PosX != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(PosX);
      }
      if (PosY != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(PosY);
      }
      if (PosZ != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(PosZ);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Propid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Propid);
      }
      if (PosX != 0F) {
        size += 1 + 4;
      }
      if (PosY != 0F) {
        size += 1 + 4;
      }
      if (PosZ != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(campinfo_ornament_put other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Propid.Length != 0) {
        Propid = other.Propid;
      }
      if (other.PosX != 0F) {
        PosX = other.PosX;
      }
      if (other.PosY != 0F) {
        PosY = other.PosY;
      }
      if (other.PosZ != 0F) {
        PosZ = other.PosZ;
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
            Index = input.ReadInt32();
            break;
          }
          case 18: {
            Propid = input.ReadString();
            break;
          }
          case 29: {
            PosX = input.ReadFloat();
            break;
          }
          case 37: {
            PosY = input.ReadFloat();
            break;
          }
          case 45: {
            PosZ = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class campinfo : pb::IMessage<campinfo> {
    private static readonly pb::MessageParser<campinfo> _parser = new pb::MessageParser<campinfo>(() => new campinfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<campinfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCampReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo(campinfo other) : this() {
      campType_ = other.campType_;
      campName_ = other.campName_;
      campId_ = other.campId_;
      chairLevel_ = other.chairLevel_;
      tentLevel_ = other.tentLevel_;
      campfireLevel_ = other.campfireLevel_;
      boxLevel_ = other.boxLevel_;
      chairs_ = other.chairs_.Clone();
      ornamentPuts_ = other.ornamentPuts_.Clone();
      animalKindUnlock_ = other.animalKindUnlock_.Clone();
      isFinishFirstInitTent_ = other.isFinishFirstInitTent_;
      isFinishFirstInitCampfire_ = other.isFinishFirstInitCampfire_;
      isFinishFirstInitBox_ = other.isFinishFirstInitBox_;
      isFinishFirstInitChair_ = other.isFinishFirstInitChair_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public campinfo Clone() {
      return new campinfo(this);
    }

    /// <summary>Field number for the "camp_type" field.</summary>
    public const int CampTypeFieldNumber = 1;
    private int campType_;
    /// <summary>
    /// 营地类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "camp_name" field.</summary>
    public const int CampNameFieldNumber = 2;
    private string campName_ = "";
    /// <summary>
    /// 营地名字
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampName {
      get { return campName_; }
      set {
        campName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 3;
    private string campId_ = "";
    /// <summary>
    /// 营地地图id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampId {
      get { return campId_; }
      set {
        campId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chair_level" field.</summary>
    public const int ChairLevelFieldNumber = 4;
    private int chairLevel_;
    /// <summary>
    /// 椅子等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ChairLevel {
      get { return chairLevel_; }
      set {
        chairLevel_ = value;
      }
    }

    /// <summary>Field number for the "tent_level" field.</summary>
    public const int TentLevelFieldNumber = 5;
    private int tentLevel_;
    /// <summary>
    /// 帐篷等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TentLevel {
      get { return tentLevel_; }
      set {
        tentLevel_ = value;
      }
    }

    /// <summary>Field number for the "campfire_level" field.</summary>
    public const int CampfireLevelFieldNumber = 6;
    private int campfireLevel_;
    /// <summary>
    /// 篝火等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CampfireLevel {
      get { return campfireLevel_; }
      set {
        campfireLevel_ = value;
      }
    }

    /// <summary>Field number for the "box_level" field.</summary>
    public const int BoxLevelFieldNumber = 7;
    private int boxLevel_;
    /// <summary>
    /// 储物箱等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BoxLevel {
      get { return boxLevel_; }
      set {
        boxLevel_ = value;
      }
    }

    /// <summary>Field number for the "chairs" field.</summary>
    public const int ChairsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.campinfo_chair> _repeated_chairs_codec
        = pb::FieldCodec.ForMessage(66, global::Keep.DBData.Proto.campinfo_chair.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_chair> chairs_ = new pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_chair>();
    /// <summary>
    ///营地椅子数据 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_chair> Chairs {
      get { return chairs_; }
    }

    /// <summary>Field number for the "ornament_puts" field.</summary>
    public const int OrnamentPutsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.campinfo_ornament_put> _repeated_ornamentPuts_codec
        = pb::FieldCodec.ForMessage(74, global::Keep.DBData.Proto.campinfo_ornament_put.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_ornament_put> ornamentPuts_ = new pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_ornament_put>();
    /// <summary>
    ///放置的装饰物数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.campinfo_ornament_put> OrnamentPuts {
      get { return ornamentPuts_; }
    }

    /// <summary>Field number for the "animal_kind_unlock" field.</summary>
    public const int AnimalKindUnlockFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_animalKindUnlock_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> animalKindUnlock_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// 解锁动物吸引种类
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AnimalKindUnlock {
      get { return animalKindUnlock_; }
    }

    /// <summary>Field number for the "is_finish_first_init_tent" field.</summary>
    public const int IsFinishFirstInitTentFieldNumber = 11;
    private bool isFinishFirstInitTent_;
    /// <summary>
    /// 第一次实例化 帐篷
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFinishFirstInitTent {
      get { return isFinishFirstInitTent_; }
      set {
        isFinishFirstInitTent_ = value;
      }
    }

    /// <summary>Field number for the "is_finish_first_init_campfire" field.</summary>
    public const int IsFinishFirstInitCampfireFieldNumber = 12;
    private bool isFinishFirstInitCampfire_;
    /// <summary>
    /// 第一次实例化 篝火
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFinishFirstInitCampfire {
      get { return isFinishFirstInitCampfire_; }
      set {
        isFinishFirstInitCampfire_ = value;
      }
    }

    /// <summary>Field number for the "is_finish_first_init_box" field.</summary>
    public const int IsFinishFirstInitBoxFieldNumber = 13;
    private bool isFinishFirstInitBox_;
    /// <summary>
    /// 第一次实例化 储物箱
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFinishFirstInitBox {
      get { return isFinishFirstInitBox_; }
      set {
        isFinishFirstInitBox_ = value;
      }
    }

    /// <summary>Field number for the "is_finish_first_init_chair" field.</summary>
    public const int IsFinishFirstInitChairFieldNumber = 14;
    private bool isFinishFirstInitChair_;
    /// <summary>
    /// 第一次实例化 默认3个椅子
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFinishFirstInitChair {
      get { return isFinishFirstInitChair_; }
      set {
        isFinishFirstInitChair_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as campinfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(campinfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CampType != other.CampType) return false;
      if (CampName != other.CampName) return false;
      if (CampId != other.CampId) return false;
      if (ChairLevel != other.ChairLevel) return false;
      if (TentLevel != other.TentLevel) return false;
      if (CampfireLevel != other.CampfireLevel) return false;
      if (BoxLevel != other.BoxLevel) return false;
      if(!chairs_.Equals(other.chairs_)) return false;
      if(!ornamentPuts_.Equals(other.ornamentPuts_)) return false;
      if(!animalKindUnlock_.Equals(other.animalKindUnlock_)) return false;
      if (IsFinishFirstInitTent != other.IsFinishFirstInitTent) return false;
      if (IsFinishFirstInitCampfire != other.IsFinishFirstInitCampfire) return false;
      if (IsFinishFirstInitBox != other.IsFinishFirstInitBox) return false;
      if (IsFinishFirstInitChair != other.IsFinishFirstInitChair) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (CampName.Length != 0) hash ^= CampName.GetHashCode();
      if (CampId.Length != 0) hash ^= CampId.GetHashCode();
      if (ChairLevel != 0) hash ^= ChairLevel.GetHashCode();
      if (TentLevel != 0) hash ^= TentLevel.GetHashCode();
      if (CampfireLevel != 0) hash ^= CampfireLevel.GetHashCode();
      if (BoxLevel != 0) hash ^= BoxLevel.GetHashCode();
      hash ^= chairs_.GetHashCode();
      hash ^= ornamentPuts_.GetHashCode();
      hash ^= animalKindUnlock_.GetHashCode();
      if (IsFinishFirstInitTent != false) hash ^= IsFinishFirstInitTent.GetHashCode();
      if (IsFinishFirstInitCampfire != false) hash ^= IsFinishFirstInitCampfire.GetHashCode();
      if (IsFinishFirstInitBox != false) hash ^= IsFinishFirstInitBox.GetHashCode();
      if (IsFinishFirstInitChair != false) hash ^= IsFinishFirstInitChair.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CampType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CampType);
      }
      if (CampName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CampName);
      }
      if (CampId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CampId);
      }
      if (ChairLevel != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ChairLevel);
      }
      if (TentLevel != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TentLevel);
      }
      if (CampfireLevel != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CampfireLevel);
      }
      if (BoxLevel != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(BoxLevel);
      }
      chairs_.WriteTo(output, _repeated_chairs_codec);
      ornamentPuts_.WriteTo(output, _repeated_ornamentPuts_codec);
      animalKindUnlock_.WriteTo(output, _repeated_animalKindUnlock_codec);
      if (IsFinishFirstInitTent != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsFinishFirstInitTent);
      }
      if (IsFinishFirstInitCampfire != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsFinishFirstInitCampfire);
      }
      if (IsFinishFirstInitBox != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsFinishFirstInitBox);
      }
      if (IsFinishFirstInitChair != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinishFirstInitChair);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CampType);
      }
      if (CampName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CampName);
      }
      if (CampId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CampId);
      }
      if (ChairLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChairLevel);
      }
      if (TentLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TentLevel);
      }
      if (CampfireLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CampfireLevel);
      }
      if (BoxLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BoxLevel);
      }
      size += chairs_.CalculateSize(_repeated_chairs_codec);
      size += ornamentPuts_.CalculateSize(_repeated_ornamentPuts_codec);
      size += animalKindUnlock_.CalculateSize(_repeated_animalKindUnlock_codec);
      if (IsFinishFirstInitTent != false) {
        size += 1 + 1;
      }
      if (IsFinishFirstInitCampfire != false) {
        size += 1 + 1;
      }
      if (IsFinishFirstInitBox != false) {
        size += 1 + 1;
      }
      if (IsFinishFirstInitChair != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(campinfo other) {
      if (other == null) {
        return;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.CampName.Length != 0) {
        CampName = other.CampName;
      }
      if (other.CampId.Length != 0) {
        CampId = other.CampId;
      }
      if (other.ChairLevel != 0) {
        ChairLevel = other.ChairLevel;
      }
      if (other.TentLevel != 0) {
        TentLevel = other.TentLevel;
      }
      if (other.CampfireLevel != 0) {
        CampfireLevel = other.CampfireLevel;
      }
      if (other.BoxLevel != 0) {
        BoxLevel = other.BoxLevel;
      }
      chairs_.Add(other.chairs_);
      ornamentPuts_.Add(other.ornamentPuts_);
      animalKindUnlock_.Add(other.animalKindUnlock_);
      if (other.IsFinishFirstInitTent != false) {
        IsFinishFirstInitTent = other.IsFinishFirstInitTent;
      }
      if (other.IsFinishFirstInitCampfire != false) {
        IsFinishFirstInitCampfire = other.IsFinishFirstInitCampfire;
      }
      if (other.IsFinishFirstInitBox != false) {
        IsFinishFirstInitBox = other.IsFinishFirstInitBox;
      }
      if (other.IsFinishFirstInitChair != false) {
        IsFinishFirstInitChair = other.IsFinishFirstInitChair;
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
            CampType = input.ReadInt32();
            break;
          }
          case 18: {
            CampName = input.ReadString();
            break;
          }
          case 26: {
            CampId = input.ReadString();
            break;
          }
          case 32: {
            ChairLevel = input.ReadInt32();
            break;
          }
          case 40: {
            TentLevel = input.ReadInt32();
            break;
          }
          case 48: {
            CampfireLevel = input.ReadInt32();
            break;
          }
          case 56: {
            BoxLevel = input.ReadInt32();
            break;
          }
          case 66: {
            chairs_.AddEntriesFrom(input, _repeated_chairs_codec);
            break;
          }
          case 74: {
            ornamentPuts_.AddEntriesFrom(input, _repeated_ornamentPuts_codec);
            break;
          }
          case 82: {
            animalKindUnlock_.AddEntriesFrom(input, _repeated_animalKindUnlock_codec);
            break;
          }
          case 88: {
            IsFinishFirstInitTent = input.ReadBool();
            break;
          }
          case 96: {
            IsFinishFirstInitCampfire = input.ReadBool();
            break;
          }
          case 104: {
            IsFinishFirstInitBox = input.ReadBool();
            break;
          }
          case 112: {
            IsFinishFirstInitChair = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 营地数据集合
  /// </summary>
  public sealed partial class db_data_campinfoColl : pb::IMessage<db_data_campinfoColl> {
    private static readonly pb::MessageParser<db_data_campinfoColl> _parser = new pb::MessageParser<db_data_campinfoColl>(() => new db_data_campinfoColl());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<db_data_campinfoColl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Keep.DBData.Proto.GameDataCampReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public db_data_campinfoColl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public db_data_campinfoColl(db_data_campinfoColl other) : this() {
      userId_ = other.userId_;
      coll_ = other.coll_.Clone();
      lastCamp_ = other.lastCamp_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public db_data_campinfoColl Clone() {
      return new db_data_campinfoColl(this);
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

    /// <summary>Field number for the "coll" field.</summary>
    public const int CollFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Keep.DBData.Proto.campinfo> _repeated_coll_codec
        = pb::FieldCodec.ForMessage(18, global::Keep.DBData.Proto.campinfo.Parser);
    private readonly pbc::RepeatedField<global::Keep.DBData.Proto.campinfo> coll_ = new pbc::RepeatedField<global::Keep.DBData.Proto.campinfo>();
    /// <summary>
    /// 数据集合
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Keep.DBData.Proto.campinfo> Coll {
      get { return coll_; }
    }

    /// <summary>Field number for the "lastCamp" field.</summary>
    public const int LastCampFieldNumber = 3;
    private int lastCamp_;
    /// <summary>
    /// 上一个营地类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LastCamp {
      get { return lastCamp_; }
      set {
        lastCamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as db_data_campinfoColl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(db_data_campinfoColl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if(!coll_.Equals(other.coll_)) return false;
      if (LastCamp != other.LastCamp) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0) hash ^= UserId.GetHashCode();
      hash ^= coll_.GetHashCode();
      if (LastCamp != 0) hash ^= LastCamp.GetHashCode();
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
      coll_.WriteTo(output, _repeated_coll_codec);
      if (LastCamp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(LastCamp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
      }
      size += coll_.CalculateSize(_repeated_coll_codec);
      if (LastCamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LastCamp);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(db_data_campinfoColl other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      coll_.Add(other.coll_);
      if (other.LastCamp != 0) {
        LastCamp = other.LastCamp;
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
            coll_.AddEntriesFrom(input, _repeated_coll_codec);
            break;
          }
          case 24: {
            LastCamp = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
