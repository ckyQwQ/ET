// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: UnitConfig.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ETModel {

  #region Messages
  public partial class UnitConfigCollection : pb::IMessage {
    private static readonly pb::MessageParser<UnitConfigCollection> _parser = new pb::MessageParser<UnitConfigCollection>(() => (UnitConfigCollection)MessagePool.Instance.Fetch(typeof(UnitConfigCollection)));
    public static pb::MessageParser<UnitConfigCollection> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::ETModel.UnitConfig> _repeated_configs_codec
        = pb::FieldCodec.ForMessage(10, global::ETModel.UnitConfig.Parser);
    private pbc::RepeatedField<global::ETModel.UnitConfig> configs_ = new pbc::RepeatedField<global::ETModel.UnitConfig>();
    public pbc::RepeatedField<global::ETModel.UnitConfig> Configs {
      get { return configs_; }
      set { configs_ = value; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      configs_.WriteTo(output, _repeated_configs_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += configs_.CalculateSize(_repeated_configs_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      for (int i = 0; i < configs_.Count; i++) { MessagePool.Instance.Recycle(configs_[i]); }
      configs_.Clear();
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            configs_.AddEntriesFrom(input, _repeated_configs_codec);
            break;
          }
        }
      }
    }

  }

  public partial class UnitConfig : pb::IMessage {
    private static readonly pb::MessageParser<UnitConfig> _parser = new pb::MessageParser<UnitConfig>(() => (UnitConfig)MessagePool.Instance.Fetch(typeof(UnitConfig)));
    public static pb::MessageParser<UnitConfig> Parser { get { return _parser; } }

    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string desc_ = "";
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private int position_;
    public int Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    private int height_;
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    private int weight_;
    public int Weight {
      get { return weight_; }
      set {
        weight_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Desc);
      }
      if (Position != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Position);
      }
      if (Height != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Height);
      }
      if (Weight != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Weight);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Desc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      if (Position != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Position);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (Weight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Weight);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      id_ = 0;
      name_ = "";
      desc_ = "";
      position_ = 0;
      height_ = 0;
      weight_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Desc = input.ReadString();
            break;
          }
          case 40: {
            Position = input.ReadInt32();
            break;
          }
          case 48: {
            Height = input.ReadInt32();
            break;
          }
          case 56: {
            Weight = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code