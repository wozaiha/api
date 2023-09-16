﻿using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;
using MessagePack;

namespace MareSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupFullInfoDto(GroupData Group, UserData Owner, GroupPermissions GroupPermissions, GroupUserPreferredPermissions GroupUserPermissions, GroupUserInfo GroupUserInfo) : GroupInfoDto(Group, Owner, GroupPermissions)
{
    public GroupUserPreferredPermissions GroupUserPermissions { get; set; } = GroupUserPermissions;
    public GroupUserInfo GroupUserInfo { get; set; } = GroupUserInfo;
}